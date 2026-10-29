using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Array_practice_problems
{
    internal class Program
    {
    static void Main(string[] args)
        {
            /* Create an integer array of 5 elements and display all elements.*/
            /* int[] numbers = { 10, 20, 30, 40, 50 };
             for (int i = 0; i < numbers.Length; i++)
             {
                 Console.WriteLine(numbers[i]);
             }*/


            /*  Create an array of 10 integers and take values from the user.Display the elements.*/
            /*  int[] numbers = new int [10];
              for (int i = 0;i < numbers.Length; i++)
              {
                  Console.WriteLine("enter number" + (i + 1) + ":");
                  numbers[i] = Convert.ToInt32(Console.ReadLine());
              }
              Console.WriteLine("array elements are:");
              for (int i = 0; i < numbers.Length; i++)
              {
                  Console.WriteLine(numbers[i]);
              } */

            /*Find the sum of all elements in an integer array.*/

            /* int[] number = new int[5];
             int sum = 0;
             for (int i = 0; i < number.Length; i++)
             {
                 Console.WriteLine("enter number" + (i + 1) + ": ");
                 number[i] = Convert.ToInt32(Console.ReadLine());
             }
             for (int i = 0; i < number.Length; i++)
             {
                 sum = sum + number[i];
             }
             Console.WriteLine("sum of all integers=" + sum);*/

            /* Find the average of elements in an array.*/
            /* int[] number = new int[5];
             int sum = 0;
             float avg;
             for (int i = 0; i < number.Length; i++)
             {
                 Console.WriteLine("enter number" + (i + 1) + ":");
                 number[i] = Convert.ToInt32(Console.ReadLine());
             }
             for (int i = 0; i < number.Length; i++)
             {
                 sum += number[i];
             }
             avg = sum / number.Length;
             Console.WriteLine("sum =" + sum);
             Console.WriteLine("average=" +  avg);*/

            /* Find the largest element in an array.*/
            /*  int[] number = new int[5];
              for (int i = 0; i < number.Length; i++)
              {
                  Console.WriteLine("enter number" + (i + 1) + ":");
                  number[i] = Convert.ToInt32(Console.ReadLine());
              }
              int largest = number[0];
                  for (int i = 1; i < number.Length; i++) {
                  if (number[i] > largest)
                  {
                      largest = number[i];
                  }
              }
              Console.WriteLine("largest= " + largest);*/

            /* Find the smallest element in an array.*/
            /* int[] number = new int[5];
                        for (int i = 0; i < number.Length; i++) {
                            Console.WriteLine("enter number" + (i + 1) + ":");
                                number[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        int smallest = number[0];
                        for (int i = 1; i<number.Length; i++)
                        {
                            if (number[i] < smallest)
                            {
                                smallest = number[i];
                            }

                        }
                        Console.WriteLine("smallest =" + smallest);*/

            /*Count how many even numbers are present in an array.*/
            /* int[] number = new int[5];
             int count = 0;
             for (int i = 0; i < number.Length; i++)
             {
                 Console.WriteLine("enter number" + (i + 1) + ":");
                 number[i] = Convert.ToInt32(Console.ReadLine());
             }
             for (int i = 0; i < number.Length; i++)
             {
                 if (number[i] % 2 == 0)
                 {
                     count++;

                     Console.WriteLine("even number=" + count);
                 }
             }*/
            /*Count how many odd numbers are present in an array.*/
            /*  int[] number = new int[5];
              int count = 0;
              for (int i = 0; i < number.Length; i++)
              {
                  Console.WriteLine("enter number" + (i + 1) + ":");
                  number[i] = Convert.ToInt32(Console.ReadLine());
              }
              for (int i = 0; i < number.Length; i++)
              {
                  if (number[i] % 2 != 0)
                  {
                      count++;
                  }
              }
              Console.WriteLine("odd number=" + count);*/
            /* Count the number of positive and negative numbers in an array.*/
            /*  int[] number = new int[5];
              int positive = 0;
              int negative = 0;
              for (int i = 0; i < number.Length; i++)
              {
                  Console.WriteLine("enter number" + (i + 1) + ":");
                  number[i] = Convert.ToInt32(Console.ReadLine());
              }
              for (int i = 0;i < number.Length; i++)
              {
                  if (number[i] > 0)
                  {
                      positive ++;

                  }
                  else if (number[i] <0);
                  {
                      negative--; 
                  }
              }
              Console.WriteLine("total positive number" + positive);
              Console.WriteLine("total negative number" +  negative);*/

            /*Find the length of an array and display it.*/
            int[] number = new int[5];
            Console.WriteLine("length of an arrary=" +  number.Length);

}
}
}
