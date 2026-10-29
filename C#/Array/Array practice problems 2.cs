using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Search for a given number in an array and display whether it is found or not found.*/
            /*   int[] number = new int[5];
               for (int i = 0; i < number.Length; i++)
               {
                   Console.WriteLine("enter number" + (i + 1) + ":");
                   number[i] = Convert.ToInt32(Console.ReadLine());

               }
               Console.WriteLine("Enter number to search");
               int search = Convert.ToInt32(Console.ReadLine());

               bool found = false;

               for (int i = 0; i < number.Length; i++) {
                   if (number[i] == search)
                   {

                       found = true;
                       break;
                   }
                   }

               if (found)
               {
                   Console.WriteLine("number is found");
               }
               else
               {
                   Console.WriteLine("number is not found");
               } */

            /* Count how many times a particular number occurs in an array.*/
            /*  int[] number = new int[5];
              int count = 0;
              for (int i = 0; i < number.Length; i++)
              {
                  Console.WriteLine("enter number" + (i + 1) + ":");
                  number[i] = Convert.ToInt32(Console.ReadLine());

              }
              Console.WriteLine("enter number to count");
              int search = Convert.ToInt32(Console.ReadLine());

              for (int i = 0; i < number.Length; i++)
              {
                      if (number[i] == search)
                  {
                      count++;
                  }
              }
              Console.WriteLine(search + "occurs" +  count +"times");*/

            /*Reverse an array and display the reversed elements.*/

            /*   int[] number = new int[5];
               for (int i = 0; i < number.Length; i++)
               {
                   Console.WriteLine("enter number" + (i + 1) + ":");
                   number[i] = Convert.ToInt32(Console.ReadLine());
               }
               Console.WriteLine("reserved array");
               for (int i=number.Length-1; i>=0; i-- ) 
               {
                   Console.WriteLine(number[i]);
               }*/

            /*Copy all elements from one array into another array.*/
            /*  int[] number1 = new int[5];
              int [] number2 = new int[5];

              for (int i = 0; i < number1.Length; i++)
              {
                  Console.WriteLine("enter number" + (i + 1) + ":");
                  number1[i] = Convert.ToInt32(Console.ReadLine());
              }

              for (int i = 0; i < number1.Length; i++)
              {
                  number2[i] = number1[i];
              }
              for(int i = 0;i < number2.Length; i++)
              {
                  Console.WriteLine(number2[i]+" ");
              } */
            /* Find the second-largest element in an array.*/

            int[] number = new int[5];
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine("enter number" + (i + 1) + ":");
                number[i] = Convert.ToInt32(Console.ReadLine());
            }

            int largest = number[0];
            int secondlargest = number[0];

            for (int i = 1; i < number.Length; i++)
            {
                if (number[i] > largest)
                {
                    secondlargest = largest;
                    largest = number[i];


                }
                else if (number[i] > secondlargest && number[i] != largest)
                {
                    secondlargest = number[i];
                }
            }

            Console.WriteLine("largest element:" + largest);
            Console.WriteLine("second largest number" + secondlargest);


 }
}
}
