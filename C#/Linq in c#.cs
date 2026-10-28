using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Display numbers greater than 10.*/

            /* int[] number = { 10, 20, 34, 11, 23 };
             var result = number.Where(n => n > 10);
             foreach (var i in result) {
                 Console.WriteLine(i);*/

            /*Display only odd numbers from an array.*/
            /*   int[] numbers = { 1, 3, 4, 5, 6, 7, 8, };
               var result = from n in numbers
                            where n%2 !=0
                            select n;
                  foreach (int i in result)
               {
                   Console.WriteLine(i);
               }*/

            /*Sort numbers in ascending order.*/

            /*  int[] number = { 1, 3, 4, 6, 5, 2 };
              var result = from n in number
                           orderby n ascending
                           select n;
              foreach (int i in result)
              {
                  Console.WriteLine(i);
              }*/

            /*Find the largest and smallest numbers.*/
            /*  int[] number = { 1, 3, 4, 7, 6, 5, 2 };
              int largest = number.Max();
              int smallest = number.Min();

              Console.WriteLine("largests number is" + largest);
              Console.WriteLine("smallest number is " + smallest);*/

            /*Calculate the sum of all numbers.*/

            /*  int[] number = { 1, 2, 3 };
              int sum = (from n in number
                        select n).Sum();

              Console.WriteLine(sum);*/


            /*Count numbers greater than 50.*/

            /*    int[] number = { 89, 45, 21, 51, 51 };
                int count = (from n in number
                             where n> 50
                             select n).Count();
                Console.WriteLine(count);*/

            /* Display student names starting with "A".*/
            /*  string[] student = { "Amit", "Priya", "Anjali", "Rahul", "Akash", "Sneha" };
              var result = from name in student
                           where name.StartsWith("A")
                           select name;
              foreach(string s in result)
              {
                  Console.WriteLine(s);
              }*/

            /*Find the average of student marks.*/
            /*   int[] number = { 12, 34, 12 };
               double result = (from num in number
                            select num).Average();

               Console.WriteLine(result);*/

            /*Sort student names alphabetically.*/
            /*string[] student = { "Amit", "Priya", "Anjali", "Rahul", "Akash", "Sneha" };
                        var result = from name in student
                                     orderby name ascending
                                     select name;
                        foreach (var item in result) {
                            Console.WriteLine(item);
                        }*/
            /*Find all numbers divisible by 5.*/

            int[] numb = { 5, 10, 15, 7, 8 };

            var result = from n in numb
                         where n % 5 == 0
                         select n;
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }


        }
}
}
