using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_and_Await
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            /*Display a message after 2 seconds*/
            /*  Console.WriteLine("hello");
             await Task.Delay(1000);
             Console.WriteLine("welcome to c#");*/

            /*Create an asynchronous method*/
            /*await Display();*/

            /* Add two numbers asynchronously*/
            /*  int result = await Add(10, 60);
            Console.WriteLine("sum =" + result);*/

            /*Find the square of a number*/
            /*int result = await Square(5);
            Console.WriteLine(result);*/

            /*Check whether a number is even or odd*/
            /* string result = await CheckNumber(7);
             Console.WriteLine(result);*/

            /*Display numbers from 1 to 5*/
            /* await DisplayNumber();*/

            /*Accept a name and display it asynchronously*/
            /* Console.WriteLine("enter name");
             string name = Console.ReadLine();
             await Showname(name);*/

            /*Calculate the average of marks*/
            /* int[] marks = { 10, 20, 30 };
             double average = await calculate(marks);
             Console.WriteLine(average);*/

            /*Run two asynchronous tasks together*/

            /* Task task1 = Display("task1");
             Task task2 = Display("task2");
             await Task.WhenAll(task1, task2);
             Console.WriteLine("both task completed");*/

            /*Handle an error in an asynchronous method*/

            try
            {
                await Checkage(15);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


          }

        /*  static async Task Display()
          {
              await Task.Delay(1000);
              Console.WriteLine("welcome to c#");
          }*/

        /* static async Task<int> Add(int a,int b)
         {
             await Task.Delay(1000);
             return a + b;
         }*/
        /*  static async Task<int> Square(int x)
          {
              await Task.Delay(1000);
              return x * x;
          }*/

        /*  static async Task<string> CheckNumber(int x) {
              await Task.Delay(1000);
                  if (x % 2 == 0)
              {
                  return "Even number";
              }
              else
              {
                 return "Odd number";
              }
          }*/

        /* static async Task DisplayNumber() {
             for (int i = 1; i <= 5; i++)
             {
                 await Task.Delay(1000);
                 Console.WriteLine(i);
             }
         }*/
        /*  static async Task Showname(string name)
          {
              await Task.Delay(1000);
              Console.WriteLine("welcome" + name);
          }*/

        /*  static async Task<double> calculate(int[] marks)
          {
              await Task.Delay(1000);
              return marks.Average();
          }*/

        /*  static async Task Display(string name) {
          await Task.Delay(1000);
          Console.WriteLine(name);
           }*/


        static async Task Checkage(int age) { 
            await Task.Delay(1000);
            if (age < 18)
            {
                throw new Exception("age must be 18 or above");
            }
            Console.WriteLine("eligible");
        }

        }
    }
