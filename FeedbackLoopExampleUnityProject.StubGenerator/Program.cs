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
        public static void Main(string[] args)
        {
            string outputDirectory = "Stubs";
            if (Directory.Exists(outputDirectory))
            {
                Directory.Delete(outputDirectory, true);
            }

            GenerateStubClassesForAssembly(typeof(UnityEngine.MonoBehaviour).Assembly, "UnityEngine", outputDirectory);
        }

        private static void GenerateStubClassesForAssembly(Assembly assembly, string namespacePrefix, string outputDirectory)
        {
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                if (!type.IsClass)
                {
                    continue;
                }

                if (!type.Namespace.StartsWith(namespacePrefix))
                {
                    continue;
                }

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
                                builder.AppendLine($"\t\tpublic{modifier} {GetTypeFriendlyName(field.FieldType)} {field.Name};");
                            }
                            break;
                        case MemberTypes.Property:
                            {
                                var property = (PropertyInfo)member;
                                if (property.CanRead & property.CanWrite)
                                {
                                    var modifier = (property.GetGetMethod().IsStatic ? " static" : "");
                                    builder.AppendLine($"\t\tpublic{modifier} {GetTypeFriendlyName(property.PropertyType)} {property.Name} {{ get => thrown new NotImplementedException(); set => thrown new NotImplementedException(); }};");
                                }
                                else if (property.CanRead)
                                {
                                    var modifier = (property.GetGetMethod().IsStatic ? " static" : "");
                                    builder.AppendLine($"\t\tpublic{modifier} {GetTypeFriendlyName(property.PropertyType)} {property.Name} => thrown new NotImplementedException();");
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
                                builder.AppendLine($"\t\tpublic{modifier} event {GetTypeFriendlyName(eventInfo.EventHandlerType)} {eventInfo.Name};");
                            }
                            break;
                        case MemberTypes.Constructor:
                            {

                                var constructor = (ConstructorInfo)member;
                                builder.AppendLine($"\t\tpublic {type.Name}({string.Join(", ", constructor.GetParameters().Select(p => $"{GetTypeFriendlyName(p.ParameterType)} {p.Name}"))}) {{ }}");
                            }
                            break;
                        case MemberTypes.Method:
                            {
                                var method = (MethodInfo)member;

                                // ignore get/set property methods
                                if (!method.IsSpecialName)
                                {
                                    var modifier = (method.IsStatic ? " static" : "");
                                    builder.AppendLine($"\t\tpublic{modifier} {GetTypeFriendlyName(method.ReturnType)} {method.Name}{GetMethodGenericParameters(method)}({string.Join(", ", method.GetParameters().Select(p => $"{GetTypeFriendlyName(p.ParameterType)} {p.Name}"))}) => thrown new NotImplementedException();");
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

                string contents = string.Format(format, GetClassFriendlyName(type), type.BaseType == typeof(object) ? "" : ": " + GetTypeFriendlyName(type.BaseType), builder.ToString());


                Directory.CreateDirectory(outputDirectory);
                using (var writer = new StreamWriter(new FileStream(Path.Combine(outputDirectory, GetFileFriendlyName(type.FullName) + ".cs"), FileMode.Create, FileAccess.Write, FileShare.None)))
                {
                    writer.Write(contents);
                }
            }
        }

        private static string GetMethodGenericParameters(MethodInfo method)
        {
            if (method.ContainsGenericParameters)
            {
                return '<' + string.Join(", ", method.GetGenericArguments().Select(t => GetTypeFriendlyName(t))) +'>';
            }

            return "";
        }

        private static bool HasAttribute(MemberInfo member, Type attributeType)
        {
            return member.CustomAttributes.Any(a => a.AttributeType == attributeType);
        }

        private static string GetClassFriendlyName(Type type)
        {
            if (type.IsGenericType)
            {

            }

            return type.Name;
        }

        private static string GetFileFriendlyName(string fullName)
        {
            foreach (var ch in Path.GetInvalidFileNameChars())
            {
                fullName = fullName.Replace(ch, '_');
            }
            return fullName;
        }

        private static string GetTypeFriendlyName(Type type)
        {
            var codeDomProvider = CodeDomProvider.CreateProvider("C#");
            var typeReferenceExpression = new CodeTypeReferenceExpression(new CodeTypeReference(type));
            using (var writer = new StringWriter())
            {
                codeDomProvider.GenerateCodeFromExpression(typeReferenceExpression, writer, new CodeGeneratorOptions());
                return writer.GetStringBuilder().ToString();
            }
        }
    }
}