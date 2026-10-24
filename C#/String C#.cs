using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_C_
{
    internal class Program
    {
        static void Main(string[] args)

        {
            /* string */
            /*string name = "developer";
            string city = "mumbai";
                Console.WriteLine(name);
            Console.WriteLine(city);*/


            /* Accessing characters */
            /*  string name = "Hello";
              Console.WriteLine(name[0]);
              Console.WriteLine(name[1]);*/

            /* string formatting */
            string name = "developer";
            int age = 34;
            string result = string.Format("My name is {0} and my age is {1}", name, age);
            Console.WriteLine(result);

            /* string builder */

            StringBuilder sb = new StringBuilder();
            sb.Append("software");
            sb.Append("developer");
            Console.WriteLine(sb);

            /* string methods and properties*/
            string text = "hello C#";

            Console.WriteLine(text.Length);
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.Contains("C#"));
            Console.WriteLine(text.Replace("C#", "Programming"));

        }
    }
}
