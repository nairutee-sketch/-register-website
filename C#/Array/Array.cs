using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_C_
{
    internal class Program
    {
        static void Main(string[] args)

        {
            /* array */

            int[] marks = { 70, 80, 65, 90, 75 };
            Console.WriteLine("first marks:" + marks[0]);
            Console.WriteLine("third mark:" + marks[2]);

            /* using loop */

            int[] marks2 = { 10, 20, 30, 40, 50 };
            for (int i = 0; i < marks2.Length; i++)
            {
                Console.WriteLine(marks2[i]);
            }

            /* multidimensional array */

            int[,] matrix =
                {
                {10,20, 30, },
                {40,50,60 }
                };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(matrix[i, j] + "");
                }
                Console.WriteLine();
            }

            /* jagged array */

            int[][] number = new int[3][];
            number[0] = new int[] { 10, 20 };
            number[1] = new int[] { 30, 40, 50 };
            number[2] = new int[] { 60, 70, 80, 90 };

            for (int i = 0;i < number.Length; i++)
            {
                for (int j = 0;j < number[i].Length; j++)
                {
                    Console.WriteLine(number[i][j] + "");
                }
                Console.WriteLine() ;
            }

            /* array class (methods and properties)*/

            int[] numbers = { 10, 20, 30, 40, 50 };
            Console.WriteLine("length:" +  numbers.Length);
            Console.WriteLine("Rank:" + numbers.Rank);

            Array.Sort(numbers);
            Console.WriteLine("sorted array:");
            foreach(int n  in numbers)
            {
                Console.WriteLine(n + "");
            }
            Array.Reverse(numbers);
            Console.WriteLine("descending order:");
            foreach(int n in numbers)
            {
                Console.WriteLine(n + "");
            }

            

        }
    }
}
