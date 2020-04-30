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
            string outputDirectory = @"C:\git\FeedbackLoopExampleUnityGame\FeedbackLoopExampleUnityProject.Injected\Stubs.Generated";// "Stubs";
            if (Directory.Exists(outputDirectory))
            {
                Directory.Delete(outputDirectory, true);
            }

            var typesToConvertByAssembly = new []
            {
                GetTypesToConvertForAssembly(typeof(UnityEngine.MonoBehaviour).Assembly, "UnityEngine"),
                GetTypesToConvertForAssembly(typeof(UnityEngine.Physics).Assembly, "UnityEngine"),
                GetTypesToConvertForAssembly(typeof(UnityEngine.Animator).Assembly, "UnityEngine")
            };

            stubbedUnityTypes = new HashSet<Type>();
            foreach (var type in typesToConvertByAssembly.SelectMany(asm => asm.Types))
            {
                stubbedUnityTypes.Add(type);
            }

            foreach (var asm in typesToConvertByAssembly)
            {
                GenerateStubClassesForAssembly(asm.Types, Path.Combine(outputDirectory, asm.AsmName));
            }
        }

        private static (string AsmName, Type[] Types) GetTypesToConvertForAssembly(Assembly assembly, string namespacePrefix)
        {
            var types = assembly.GetTypes();

            return (
                assembly.GetName().Name,
                types.Where(t => t.IsClass
                                 && !IsDelegate(t)
                                 && !HasAttribute(t, typeof(ObsoleteAttribute))
                                 && t.Namespace.StartsWith(namespacePrefix)
                                 && !t.Name.StartsWith("<"))
                     .ToArray()
                );
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

                bool hasInAccessibleType = false;

                var typeNestingList = GetTypeNestingList(type);
                foreach (var typeDef in typeNestingList)
                {
                    // check is part of public API
                    if (typeDef.IsNotPublic)
                    {
                        hasInAccessibleType = true;
                        break;
                    }

                    bool hasBaseType = type.BaseType != null && type.BaseType != typeof(object);
                    string baseTypeString = "";
                    if (hasBaseType)
                    {
                        // check is part of public API
                        if (type.BaseType.IsNotPublic)
                        {
                            hasInAccessibleType = true;
                            break;
                        }

                        baseTypeString = " : " + GetTypeFriendlyName(type.BaseType);
                    }

                    builder.AppendLine($"\tpublic unsafe partial class {GetTypeFriendlyName(typeDef, false)}{baseTypeString} {{");
                }

                if (hasInAccessibleType)
                {
                    continue;
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

                                bool isOverride = field.DeclaringType != type;
                                var modifiersString = GetModifiers(field.IsStatic, isOverride, false);

                                builder.AppendLine($"\t\tpublic{modifiersString} {GetTypeFriendlyName(field.FieldType)} {GetSafeName(field.Name)};");
                            }
                            break;
                        case MemberTypes.Property:
                            {
                                var property = (PropertyInfo)member;
                                if (property.CanRead)
                                {
                                    var getter = property.GetGetMethod();

                                    bool isOverride = getter.GetBaseDefinition() != getter;
                                    var modifiersString = GetModifiers(getter.IsStatic, isOverride, getter.IsVirtual);
                                   
                                    if (property.CanWrite)
                                    {
                                        builder.AppendLine($"\t\tpublic{modifiersString} {GetTypeFriendlyName(property.PropertyType)} {GetSafeName(property.Name)} {{ get => throw new NotImplementedException(); set => throw new NotImplementedException(); }}");
                                    }
                                    else
                                    {
                                        builder.AppendLine($"\t\tpublic{modifiersString} {GetTypeFriendlyName(property.PropertyType)} {GetSafeName(property.Name)} => throw new NotImplementedException();");
                                    }
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

                                var add = eventInfo.GetAddMethod();
                                bool isOverride = add.GetBaseDefinition() != add;

                                var modifiersString = GetModifiers(add.IsStatic, isOverride, add.IsVirtual);

                                builder.AppendLine($"\t\tpublic{modifiersString} event {GetTypeFriendlyName(eventInfo.EventHandlerType)} {GetSafeName(eventInfo.Name)};");
                            }
                            break;
                        case MemberTypes.Constructor:
                            {

                                var constructor = (ConstructorInfo)member;
                                builder.AppendLine($"\t\t//public {GetTypeSimpleName(type)}({string.Join(", ", constructor.GetParameters().Select(p => $"{GetTypeFriendlyName(p.ParameterType)} {GetSafeName(p.Name)}"))}) {{ }}");
                            }
                            break;
                        case MemberTypes.Method:
                            {
                                var method = (MethodInfo)member;

                                // ignore get/set property methods
                                if (!method.IsSpecialName)
                                {
                                    bool isOverride = method.GetBaseDefinition() != method;

                                    var modifiersString = GetModifiers(method.IsStatic, isOverride, method.IsVirtual);

                                    var genericParametersString = GetMethodGenericParameters(method);
                                    var parametersString = string.Join(", ", method.GetParameters().Select(p => $"{GetParameterModifier(p)}{GetTypeFriendlyName(p.ParameterType)} {GetSafeName(p.Name)}"));

                                    builder.AppendLine($"\t\tpublic{modifiersString} {GetTypeFriendlyName(method.ReturnType)} {method.Name}{genericParametersString}({parametersString}){GetMethodGenericConstraints(method)} => throw new NotImplementedException();");
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

        private static object GetParameterModifier(ParameterInfo parameter)
        {
            string modifiers = "";

            if (parameter.ParameterType.IsByRef)
            {
                if (parameter.IsOut)
                {
                    modifiers += "out ";
                }
                else
                {
                    modifiers += "ref ";
                }
            }

            return modifiers;
        }

        private static string GetModifiers(bool isStatic, bool isOverride, bool isVirtual)
        {
            string modifiers = "";
            if (isStatic)
            {
                modifiers += " static";
            }
          
            if (isOverride)
            {
                modifiers += " override";
            }
            else if (isVirtual)
            {
                modifiers += " virtual";
            }

            return modifiers;
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
                return GetTypeFriendlyName(elementType);
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