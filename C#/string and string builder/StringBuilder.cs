using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace stringbuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("hello");
            sb.Append("developer");
            Console.WriteLine(sb);


            StringBuilder sb1 = new StringBuilder("hello world");
            sb1.Insert(6, "C#");
            Console.WriteLine(sb1);

            StringBuilder sb2 = new StringBuilder("i like java");
            sb2.Replace("java", "C#");
            Console.WriteLine(sb2);

            StringBuilder sb3 = new StringBuilder("hello world");
            sb3.Remove(5, 6);
            Console.WriteLine(sb3);

            /*Reverse a string using StringBuilder*/

            Console.WriteLine("enter a string");
            string str = Console.ReadLine();

            StringBuilder sb4 = new StringBuilder(str);
                for (int i = sb4.Length - 1; i >= 0; i--) {
                Console.Write(sb4[i]);
            }


            /* Accept a sentence from the user. Display the total number of characters using Length. */

            Console.WriteLine("enter a string");
            string str1 = Console.ReadLine();

            StringBuilder sb5 = new StringBuilder(str1);

            Console.WriteLine(sb5.Length);

            /* Accept a string from the user.Convert it to uppercase using ToString() and ToUpper().Display the result.*/
            Console.WriteLine("enter a string");
            string str2 = Console.ReadLine();

            StringBuilder sb6 = new StringBuilder(str2);

            Console.WriteLine(sb6.ToString().ToUpper());

            /* Create a StringBuilder with "Welcome to C#". Use Clear() to remove all content. Display the result.*/

            StringBuilder sb7 = new StringBuilder("welcome to C#");
            Console.WriteLine("before clear" + sb7);
            sb7.Clear();
            Console.WriteLine("after clear" + sb7);

            /* Accept first name and last name from the user. Combine them using Append(). Display the full name.*/

            Console.WriteLine("enter first name");
            string str3 = Console.ReadLine();

            Console.WriteLine("enter last name");
            string str4 = Console.ReadLine();

            StringBuilder sb8 = new StringBuilder();

            sb8.Append(str3);
            sb8.Append(str4);

            Console.WriteLine("full name" + sb8.ToString());

            /*  Accept a sentence from the user. Append " in C#". Replace one word. Display the final sentence.*/

            Console.WriteLine("enter a string");
            string str5 = Console.ReadLine();

            StringBuilder sb9 = new StringBuilder(str5);

            sb9.Append("in C#");
            sb9.Replace("java", "Asp.net");

            Console.WriteLine("final sentence:" + sb9.ToString());

            /*Accept a sentence from the user. Remove all spaces using Replace(). Display the result.*/

            Console.WriteLine("enter a string");
            string str6 = Console.ReadLine();

            StringBuilder sb10 = new StringBuilder(str6);
            sb10.Replace(" ", "");
            Console.WriteLine(sb10.ToString());

            /* Accept a word from the user. Reverse the word using StringBuilder. Check whether the original and reversed words are equal.*/
            Console.WriteLine("enter a word");
            string str7 = Console.ReadLine();

            StringBuilder sb11 = new StringBuilder(str7);
            for (int i = sb11.Length-1;  i >= 0; i--)
            {
                sb11.Append(sb11[i]);
            }
            Console.WriteLine("original word=" + str7);
            Console.WriteLine("reserved word =" +sb11.ToString());

            if (str7 == sb11.ToString())
            {
                Console.WriteLine("the word is a palindrome");
            }
            else
            {
                Console.WriteLine("the word is not palindrome");
            }


        }
    }
}
