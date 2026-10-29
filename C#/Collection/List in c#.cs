using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_in_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  List<string> names = new List<string>();
              names.Add("rahul");
              names.Add("rohan");
              names.Add("priya");

              foreach(string name in names)
              {
                  Console.WriteLine(name);
              }*/

            /*Add and remove numbers*/

            /*  List<int> numbers = new List<int>();
              numbers.Add(10);
              numbers.Add(20);
              numbers.Add(30);

              Console.WriteLine("total =" + numbers.Count);
              numbers.Remove(20);
              foreach (int i in numbers) {
                  Console.WriteLine(i);
              }*/


            /*Create a List<int>, add 5 numbers, and display all numbers using foreach.*/

            /*   List<int> numbers = new List<int>();
               numbers.Add(10);
               numbers.Add(20);
               numbers.Add(30);
               numbers.Add(40);
               numbers.Add(50);

               foreach (int i in numbers)
               {
                   Console.WriteLine(i);
               }*/

            /*  Ask the user how many numbers they want to enter. Store the numbers in a List and display them.*/

            /*    Console.WriteLine("how many numbers you want to enter");
                int n = Convert.ToInt32(Console.ReadLine());

                List<int> numbers = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("enter number" +(i + 1)+ ":");
                    int num = Convert.ToInt32(Console.ReadLine());
                    numbers.Add(num);
                }
                Console.WriteLine("numbers in the list");
                foreach (int i in numbers)
                {
                    Console.WriteLine(i);
                }*/

            /*Store 5 numbers in a List and calculate their sum and average.*/

            /*  List<int> number = new List<int>();
              number .Add(10);
              number.Add(20);
              number.Add(30);
              number.Add(40);
              number.Add(50);
              int sum = 0;

              foreach (int i in number)
              {
                   sum = sum + i;

              }
              double avg = sum / 5;
              Console.WriteLine("sum=" + sum);
              Console.WriteLine("avg=" + avg);*/

            /*Accept 5 numbers from the user and find the largest and smallest */

            /*   List<int> number = new List<int>();

               Console.WriteLine("Enter 5 numbers:");

               for (int j = 0; j < 5; j++)
               {
                   int n = Convert.ToInt32(Console.ReadLine());
                   number.Add(n);
               }

               int largest = number[0];
               int smallest = number[0];

               foreach (int i in number)
               {
                   if (i > largest)
                   {
                       largest = i;
                   }

                   if (i < smallest)
                   {
                       smallest = i;
                   }
               }

               Console.WriteLine("Largest = " + largest);
               Console.WriteLine("Smallest = " + smallest);*/

            /* Accept numbers from the user, ask for a number to search for, and display whether it exists in the List.*/

            /*  List<int> number = new List<int>();

              Console.WriteLine("How many numbers do you want to enter?");
              int n = Convert.ToInt32(Console.ReadLine());

              for (int j = 0; j < n; j++)
              {
                  Console.WriteLine("Enter number " + (j + 1) + ":");
                  int num = Convert.ToInt32(Console.ReadLine());
                  number.Add(num);

              }
              Console.WriteLine("Enter number to search:");
              int search = Convert.ToInt32(Console.ReadLine());

              if (number.Contains(search))
              {
                  Console.WriteLine("Number found in the List.");
              }
              else
              {
                  Console.WriteLine("Number not found in the List.");
              }*/

            /*Store 10 numbers in a List and count how many are even and how many are odd.*/

            /*    List<int> number = new List<int>();
                int even = 0;
                int odd = 0;

                for (int i =0; i < 10; i++)

                {
                    Console.WriteLine("enter number" +(i +1) +":");
                    int num = Convert .ToInt32(Console.ReadLine());
                    number.Add(num);
                }
                foreach (int n in number) { 

                    if (n % 2 == 0)
                    {
                        even++;
                    }
                    else
                    {
                        odd++;
                    }
                }

                Console.WriteLine("even" + even);
                Console.WriteLine("odd" + odd);*/

            /*Create a List containing repeated numbers and remove the duplicates.*/

            /*    List<int> number = new List<int>()
                {
                    10,20,10,10,20,10,10
                };
                Console.WriteLine("original list");

                foreach (int num in number)
                {
                    Console.WriteLine(num + "");
                }

                List<int> numbers = new List<int>();
                foreach (int num in number)
                {
                    if (!numbers.Contains(num))
                    {
                        numbers.Add(num);
                    }
                }
                Console.WriteLine("list after removing duplicates");
                foreach (int num in numbers) 
                {
                    Console.WriteLine(num + "");
                }*/

            /*Accept 5 numbers and display them in reverse order.*/

            /*   List<int> number = new List<int>();

                   for (int i=0; i < 5; i++)

               {
                   Console.WriteLine("enter number" + (i + 1) + ":");
                   int num = Convert.ToInt32(Console.ReadLine());
                   number.Add(num);
               }

               foreach (int num in number)
               {
                   Console.WriteLine(num);
               }
               Console.WriteLine("\nReverse order:");
               for (int i=number.Count - 1; i >=0; i--)
               {
                   Console.WriteLine(number[i]);
               }*/

            /* Accept 5 numbers and display them in ascending and descending order.*/

            /*   List<int> number = new List<int>();
               for (int i = 0; i < 5; i++)
               {
                   Console.WriteLine("enter number" +(i + 1) +":");
                   int num = Convert.ToInt32(Console.ReadLine());
                   number.Add(num);
               }

               number.Sort();
               Console.WriteLine("Ascending order");
               foreach (int i in number)
               {
                   Console.WriteLine(i);
               }
               number.Reverse();
               Console.WriteLine("descending order");
               foreach(int i in number)
               {
                   Console.WriteLine(i);
               }*/

         






}



}
}
