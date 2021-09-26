using System;
using System.Collections.Generic;

namespace VPI_dict
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Привет, это ИТ-словарь\n");
            while (n!=101)
            {
                Console.WriteLine("Выбери номер понятия, о котором хочешь больше узнать. для закрытия программы введи 101");
                Dictionary<int, string> openWith = new Dictionary<int, string>();
                openWith.Add(1, "Kotlin:It should be without the \bin. Hadoop will look for java in %JAVA_HOME%\bin");
                openWith.Add(2, "Android:It should be without the \bin. Hadoop will look for java in %JAVA_HOME%\bin");
                openWith.Add(3, "Java:Java - это технология, используемая для разработки приложений, которые делают работу в сети Интернет более увлекательной и удобной. Java отличается от языка программирования javascript, который представляет собой простую технологию для создания веб-страниц и выполняется только в браузере.\n" +
                    "public class HelloWorld \n { public static void main(String[] args)\n  {\nSystem.out.println(Hello World!);\n  }\n}");
                openWith.Add(4, "IndexOutOfRangeException:It should be without the \bin. Hadoop will look for java in %JAVA_HOME%\bin");
                openWith.Add(5, "NullReferenceException:It should be without the \bin. Hadoop will look for java in %JAVA_HOME%\bin");
                openWith.Add(6, "java_home is incorrectly set:It should be without the \bin. Hadoop will look for java in %JAVA_HOME%\bin");
                openWith.Add(7, "path must start with / character:It should be without the \bin. Hadoop will look for java in %JAVA_HOME%\bin");
                openWith.Add(8, "mssql server is not configured for rpc:It should be without the \bin. Hadoop will look for java in %JAVA_HOME%\bin");
                openWith.Add(9, "iOS:It should be without the \bin. Hadoop will look for java in %JAVA_HOME%\bin");
                openWith.Add(10, "Swift:It should be without the \bin. Hadoop will look for java in %JAVA_HOME%\bin");
                openWith.Add(11, "Assembler:It should be without the \bin. Hadoop will look for java in %JAVA_HOME%\bin");

                for (int i = 1; i <= openWith.Count; i++)
                {
                    Console.WriteLine(Convert.ToString(i) + ". " + (openWith[i].Split(':')[0]));
                }
                n = Convert.ToInt32(Console.ReadLine());
                try
                {
                    Console.WriteLine(openWith[n]);
                }
                catch
                {
                    if (n!=101)
                    {
                        Console.WriteLine("Выбор некорректен");
                    }
                }
            }
        }
            
    }
}
