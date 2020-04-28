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
            string outputDirectory = "Stubs";
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
            return types.Where(t => t.IsClass && t.Namespace.StartsWith(namespacePrefix)).ToArray();
        }

        private static void GenerateStubClassesForAssembly(Type[] types, string outputDirectory)
        {
            foreach (var type in types)
            {
                var builder = new StringBuilder();

                var members = type.GetMembers(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
                    .OrderBy(m => m.MemberType)
                    .ThenBy(m => m.Name)
                    .ToList();

                foreach (var member in members)
                {
                    if (HasAttribute(member, typeof(ObsoleteAttribute)))
                    {
                        continue;
                    }

                    switch (member.MemberType)
                    {
                        case MemberTypes.Field:
                            {
                                var field = (FieldInfo)member;
                                var modifier = (field.IsStatic ? " static" : "");
                                builder.AppendLine($"\t\tpublic{modifier} {GetTypeFriendlyName(field.FieldType, true)} {GetSafeName(field.Name)};");
                            }
                            break;
                        case MemberTypes.Property:
                            {
                                var property = (PropertyInfo)member;
                                if (property.CanRead & property.CanWrite)
                                {
                                    var modifier = (property.GetGetMethod().IsStatic ? " static" : "");
                                    builder.AppendLine($"\t\tpublic{modifier} {GetTypeFriendlyName(property.PropertyType, true)} {GetSafeName(property.Name)} {{ get => throw new NotImplementedException(); set => throw new NotImplementedException(); }}");
                                }
                                else if (property.CanRead)
                                {
                                    var modifier = (property.GetGetMethod().IsStatic ? " static" : "");
                                    builder.AppendLine($"\t\tpublic{modifier} {GetTypeFriendlyName(property.PropertyType, true)} {GetSafeName(property.Name)} => throw new NotImplementedException();");
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
                                builder.AppendLine($"\t\tpublic{modifier} event {GetTypeFriendlyName(eventInfo.EventHandlerType, true)} {GetSafeName(eventInfo.Name)};");
                            }
                            break;
                        case MemberTypes.Constructor:
                            {

                                var constructor = (ConstructorInfo)member;
                                builder.AppendLine($"\t\tpublic {type.Name}({string.Join(", ", constructor.GetParameters().Select(p => $"{GetTypeFriendlyName(p.ParameterType, true)} {GetSafeName(p.Name)}"))}) {{ }}");
                            }
                            break;
                        case MemberTypes.Method:
                            {
                                var method = (MethodInfo)member;

                                // ignore get/set property methods
                                if (!method.IsSpecialName)
                                {
                                    var modifier = (method.IsStatic ? " static" : "");
                                    builder.AppendLine($"\t\tpublic{modifier} {GetTypeFriendlyName(method.ReturnType, true)} {method.Name}{GetMethodGenericParameters(method)}({string.Join(", ", method.GetParameters().Select(p => $"{GetTypeFriendlyName(p.ParameterType, true)} {GetSafeName(p.Name)}"))}) => throw new NotImplementedException();");
                                }
                            }
                            break;
                        //case MemberTypes.TypeInfo:
                        //    break;
                        //case MemberTypes.Custom:
                        //    break;
                        case MemberTypes.NestedType:
                            // ignore
                            break;
                        //case MemberTypes.All:
                        //    break;
                        default:
                            throw new NotSupportedException();
                    }
                }

                if (builder.Length == 0)
                {
                    continue;
                }

                string format =
@"using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL
{{
    public class {0} {1}
    {{
{2}
    }}
}}";

                bool hasBaseType = type.BaseType != null && type.BaseType != typeof(object);
                string contents = string.Format(format, GetTypeFriendlyName(type, false), hasBaseType ? ": " + GetTypeFriendlyName(type.BaseType, true) : "", builder.ToString());


                Directory.CreateDirectory(outputDirectory);
                using (var writer = new StreamWriter(new FileStream(Path.Combine(outputDirectory, GetFileFriendlyName(type.FullName) + ".cs"), FileMode.Create, FileAccess.Write, FileShare.None)))
                {
                    writer.Write(contents);
                }
            }
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
            if (method.ContainsGenericParameters)
            {
                return '<' + string.Join(", ", method.GetGenericArguments().Select(t => GetTypeFriendlyName(t, true))) +'>';
            }

            return "";
        }

        private static bool HasAttribute(MemberInfo member, Type attributeType)
        {
            return member.CustomAttributes.Any(a => a.AttributeType == attributeType);
        }

        //private static string GetClassFriendlyName(Type type)
        //{
        //    if (type.IsGenericType)
        //    {

        //    }

        //    return type.Name;
        //}

        private static string GetFileFriendlyName(string fullName)
        {
            foreach (var ch in Path.GetInvalidFileNameChars())
            {
                fullName = fullName.Replace(ch, '_');
            }
            return fullName;
        }

        //private static string GetTypeFriendlyName(Type type)
        //{
        //    var codeDomProvider = CodeDomProvider.CreateProvider("C#");
        //    var typeReferenceExpression = new CodeTypeReferenceExpression(new CodeTypeReference(type));
        //    using (var writer = new StringWriter())
        //    {
        //        codeDomProvider.GenerateCodeFromExpression(typeReferenceExpression, writer, new CodeGeneratorOptions());
        //        return writer.GetStringBuilder().ToString();
        //    }
        //}

        public static string GetTypeFriendlyName(Type type, bool startWithFullName)
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
            else
            {
                string name = type.Name;
                if (startWithFullName)
                {
                    if (stubbedUnityTypes.Contains(type))
                    {
                        name = "FL." + type.Name;
                    }
                    else if (type.FullName != null)
                    {
                        name = type.FullName;
                    }
                }

                if (type.IsGenericType)
                    return name.Split('`')[0] + "<" + string.Join(", ", type.GetGenericArguments().Select(x => GetTypeFriendlyName(x, false)).ToArray()) + ">";
                else
                    return name;
            }
        }
    }
}