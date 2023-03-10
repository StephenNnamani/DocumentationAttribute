using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DocumentTool
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public class DocumentationAttribute : Attribute
    {
        public string Description { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }

        public DocumentationAttribute(string description)
        {
            Description = description;
        }

        public DocumentationAttribute(string description, string input = "", string output = "")
        {
            Description = description;
            Input = input;
            Output = output;
        }

        private static void GetDocs1(Type classtype)
        {
            DisplayClassAttr(classtype);
            DisplayPropAttr(classtype);
            DisplayMethodAttr(classtype);
        }

        public static void GetDocs()
        {
            GetDocs1(typeof(PersonModel));
        }

        public static void DisplayClassAttr(Type classtype)
        {
            Console.WriteLine("Assembly: {0}", Assembly.GetExecutingAssembly());
            Console.WriteLine("\nClass: \n\n{0}", classtype.Name);

            object[] classAttr = classtype.GetCustomAttributes(true);

            foreach (Attribute item in classAttr)
            {
                if (item is DocumentationAttribute)
                {
                    DocumentationAttribute doc = (DocumentationAttribute)item;
                    Console.WriteLine("\nDescription:\n\t{0}", doc.Description);
                }
            }
        }

        public static void DisplayPropAttr(Type classtype)
        {
            Console.WriteLine("\n\nProperties: ");
            Console.WriteLine();

            PropertyInfo[] properties = classtype.GetProperties();

            for (int i = 0; i < properties.GetLength(0); i++)
            {
                object[] propAttr = properties[i].GetCustomAttributes(true);

                foreach (Attribute item in propAttr)
                {
                    if (item is DocumentationAttribute)
                    {
                        DocumentationAttribute doc = (DocumentationAttribute)item;
                        Console.WriteLine("{0}\nDescription:\n\t{1}\nInput:\n\t{2}\n", properties[i].Name, doc.Description, doc.Input);
                    }
                }
            }
        }

        public static void DisplayMethodAttr(Type classtype)
        {
            Console.WriteLine("\nMethods:\n");
            MethodInfo[] methods = classtype.GetMethods();


            for (int i = 0; i < methods.GetLength(0); i++)
            {
                object[] methAttr = methods[i].GetCustomAttributes(true);

                foreach (Attribute item in methAttr)
                {
                    if (item is DocumentationAttribute)
                    {
                        DocumentationAttribute doc = (DocumentationAttribute)item;
                        Console.WriteLine("{0}\nDescription:\n\t{1}\nInput:\n\t{2}", methods[i].Name, doc.Description, doc.Input);
                    }
                }
            }
        }
    }
}
