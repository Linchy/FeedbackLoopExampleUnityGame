using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackLoopExampleUnityProject.StubGenerator
{
    public class Program
    {
        private static HashSet<Type> stubbedUnityTypes;

        public static void Main(string[] args)
        {
            string outputDirectory = @"C:\git\FeedbackLoopExampleUnityGame\FeedbackLoopExampleUnityProject.Injected\addedstubs";// "Stubs";
            if (Directory.Exists(outputDirectory))
            {
                Directory.Delete(outputDirectory, true);
            }

            stubbedUnityTypes = new HashSet<Type>();

            var typesUnityEngine = GetTypesToConvertForAssembly(typeof(UnityEngine.MonoBehaviour).Assembly, "UnityEngine");
            foreach (var type in typesUnityEngine)
            {
                stubbedUnityTypes.Add(type);
            }
            GenerateStubClassesForAssembly(typesUnityEngine, outputDirectory);
        }

        private static Type[] GetTypesToConvertForAssembly(Assembly assembly, string namespacePrefix)
        {
            var types = assembly.GetTypes();
            return types.Where(t => t.IsClass 
                                 && !IsDelegate(t) 
                                 && !HasAttribute(t, typeof(ObsoleteAttribute))
                                 && t.Namespace.StartsWith(namespacePrefix) 
                                 && !t.Name.StartsWith("<"))
                        .ToArray();
        }

        private static void GenerateStubClassesForAssembly(Type[] types, string outputDirectory)
        {
            foreach (var type in types)
            {
                var builder = new StringBuilder();

                builder.Append(
$@"using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_{type.Namespace}
{{
");

                var typeNestingList = GetTypeNestingList(type);
                foreach (var typeDef in typeNestingList)
                {
                    bool hasBaseType = type.BaseType != null && type.BaseType != typeof(object);
                    string baseTypeString = (hasBaseType ? " : " + GetTypeFriendlyName(type.BaseType) : "");

                    builder.AppendLine($"\tpublic unsafe partial class {GetTypeFriendlyName(typeDef, false)}{baseTypeString} {{");
                }

                var members = type.GetMembers(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
                    .OrderBy(m => m.MemberType)
                    .ThenBy(m => m.Name)
                    .ToList();

                int processedCount = 0;

                foreach (var member in members)
                {
                    if (HasAttribute(member, typeof(ObsoleteAttribute)))
                    {
                        continue;
                    }

                    processedCount++;

                    switch (member.MemberType)
                    {
                        case MemberTypes.Field:
                            {
                                var field = (FieldInfo)member;
                                var modifier = (field.IsStatic ? " static" : "");
                                builder.AppendLine($"\t\tpublic{modifier} {GetTypeFriendlyName(field.FieldType)} {GetSafeName(field.Name)};");
                            }
                            break;
                        case MemberTypes.Property:
                            {
                                var property = (PropertyInfo)member;
                                if (property.CanRead & property.CanWrite)
                                {
                                    var modifier = (property.GetGetMethod().IsStatic ? " static" : "");
                                    builder.AppendLine($"\t\tpublic{modifier} {GetTypeFriendlyName(property.PropertyType)} {GetSafeName(property.Name)} {{ get => throw new NotImplementedException(); set => throw new NotImplementedException(); }}");
                                }
                                else if (property.CanRead)
                                {
                                    var modifier = (property.GetGetMethod().IsStatic ? " static" : "");
                                    builder.AppendLine($"\t\tpublic{modifier} {GetTypeFriendlyName(property.PropertyType)} {GetSafeName(property.Name)} => throw new NotImplementedException();");
                                }
                                else
                                {
                                    throw new NotSupportedException();
                                }
                            }
                            break;
                        case MemberTypes.Event:
                            {
                                var eventInfo = (EventInfo)member;
                                var modifier = (eventInfo.GetAddMethod().IsStatic ? " static" : "");
                                builder.AppendLine($"\t\tpublic{modifier} event {GetTypeFriendlyName(eventInfo.EventHandlerType)} {GetSafeName(eventInfo.Name)};");
                            }
                            break;
                        case MemberTypes.Constructor:
                            {

                                var constructor = (ConstructorInfo)member;
                                builder.AppendLine($"\t\tpublic {GetTypeSimpleName(type)}({string.Join(", ", constructor.GetParameters().Select(p => $"{GetTypeFriendlyName(p.ParameterType)} {GetSafeName(p.Name)}"))}) {{ }}");
                            }
                            break;
                        case MemberTypes.Method:
                            {
                                var method = (MethodInfo)member;

                                // ignore get/set property methods
                                if (!method.IsSpecialName)
                                {
                                    var modifier = (method.IsStatic ? " static" : "");

                                    var genericParametersString = GetMethodGenericParameters(method);
                                    var parametersString = string.Join(", ", method.GetParameters().Select(p => $"{GetTypeFriendlyName(p.ParameterType)} {GetSafeName(p.Name)}"));

                                    builder.AppendLine($"\t\tpublic{modifier} {GetTypeFriendlyName(method.ReturnType)} {method.Name}{genericParametersString}({parametersString}){GetMethodGenericConstraints(method)} => throw new NotImplementedException();");
                                }
                            }
                            break;
                        //case MemberTypes.TypeInfo:
                        //    break;
                        //case MemberTypes.Custom:
                        //    break;
                        case MemberTypes.NestedType:
                            // ignore
                            processedCount--;
                            break;
                        //case MemberTypes.All:
                        //    break;
                        default:
                            throw new NotSupportedException();
                    }
                }

                if (processedCount == 0)
                {
                    if (type == typeof(UnityEngine.Coroutine))
                    {
                        // allow, has no members though
                    }
                    else
                    {
                        continue;
                    }
                }

                foreach (var typeDef in typeNestingList)
                {
                    builder.AppendLine("\t}");
                }
                builder.AppendLine("}");

                Directory.CreateDirectory(outputDirectory);
                using (var writer = new StreamWriter(new FileStream(Path.Combine(outputDirectory, GetFileFriendlyName(type.FullName) + ".cs"), FileMode.Create, FileAccess.Write, FileShare.None)))
                {
                    writer.Write(builder.ToString());
                }
            }
        }

        private static List<Type> GetTypeNestingList(Type type)
        {
            var types = new List<Type>();

            var currentType = type;
            while (currentType != null)
            {
                types.Add(currentType);
                currentType = currentType.DeclaringType;
            }

            types.Reverse();
            return types;
        }

        private static object GetSafeName(string name)
        {
            if (name == "object")
            {
                return '@' + name;
            }

            return name;
        }

        private static string GetMethodGenericParameters(MethodInfo method)
        {
            var genericArguments = method.GetGenericArguments();
            if (genericArguments.Length > 0)
            {
                return '<' + string.Join(", ", genericArguments.Select(t => GetTypeFriendlyName(t))) + '>';
            }

            return "";
        }

        // where T : class where T2 : class
        private static string GetMethodGenericConstraints(MethodInfo method)
        {
            var result = "";

            var genericArguments = method.GetGenericArguments();
            if (genericArguments.Length > 0)
            {
                foreach (var genericArg in genericArguments)
                {
                    var constraints = genericArg.GetGenericParameterConstraints();
                    if (constraints.Length > 0)
                    {
                        result += $" where {GetTypeFriendlyName(genericArg)} : {string.Join(",", constraints.Select(c => GetGenericConstraintTypeFriendlyName(c)))}";
                    }
                }
            }

            return result;
        }

        private static string GetGenericConstraintTypeFriendlyName(Type type)
        {
            if (type == typeof(ValueType))
                return "struct";
            else
            {
                return GetTypeFriendlyName(type);
            }
        }

        private static bool HasAttribute(MemberInfo member, Type attributeType)
        {
            return member.CustomAttributes.Any(a => a.AttributeType == attributeType);
        }

        private static string GetFileFriendlyName(string fullName)
        {
            foreach (var ch in Path.GetInvalidFileNameChars())
            {
                fullName = fullName.Replace(ch, '_');
            }
            return fullName;
        }

        public static string GetTypeSimpleName(Type type)
        {
            return type.Name.Split('`')[0];
        }

        public static string GetTypeFriendlyName(Type type, bool? overrideGetFullName = null)
        {
            if (type == typeof(void))
                return "void";
            else if (type == typeof(byte))
                return "byte";
            else if (type == typeof(bool))
                return "bool";
            else if (type == typeof(short))
                return "short";
            else if (type == typeof(int))
                return "int";
            else if (type == typeof(long))
                return "long";
            else if (type == typeof(float))
                return "float";
            else if (type == typeof(double))
                return "double";
            else if (type == typeof(decimal))
                return "decimal";
            else if (type == typeof(string))
                return "string";
            else if (type.IsPointer)
            {
                var elementType = type.GetElementType();
                return GetTypeFriendlyName(elementType) + '*';
            }
            else if (type.IsArray)
            {
                var elementType = type.GetElementType();
                return GetTypeFriendlyName(elementType) + "[]";
            }
            else if (type.IsByRef)
            {
                var elementType = type.GetElementType();
                return "ref " + GetTypeFriendlyName(elementType);
            }
            else
            {
                string name = type.Name;

                bool getFullName = overrideGetFullName ?? !type.IsGenericParameter;
                if (getFullName)
                {
                    if (type.FullName != null)
                    {
                        name = type.FullName;
                    }
                    else if (type.Namespace != null)
                    {
                        name = type.Namespace + '.' + type.Name;
                    }

                    if (stubbedUnityTypes.Contains(type))
                    {
                        name = "FL_" + name;
                    }
                }

                // trim end in case of byref
                name = name.TrimEnd('&');

                // in case of nested types
                name = name.Replace('+', '.');

                if (type.IsGenericType)
                {
                    return name.Split('`')[0] + "<" + string.Join(", ", type.GetGenericArguments().Select(a => GetTypeFriendlyName(a)).ToArray()) + ">";
                }
                else
                {
                    return name;
                }
            }
        }

        public static bool IsDelegate(Type type)
        {
            return typeof(MulticastDelegate).IsAssignableFrom(type.BaseType);
        }
    }
}