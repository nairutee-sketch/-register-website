using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try__catch__finally__throw_in_c_
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            /* try
             {
                 int a = 10;
                 int b = 0;
                 int result = a / b;
                 Console.WriteLine(result);
             }
             catch (Exception ex)
             {
                 Console.WriteLine("cannot divide by zero");
             }*/

            /*Simple program using finally*/
            /*  try
              {
                  int a = 10;
                  int b = 2;
                  Console.WriteLine(a / b);

              }
              catch (Exception e) 
              {
                  Console.WriteLine("error occured");
              }
              finally
              {
                  Console.WriteLine("program completed");
              }*/

            /*Simple program using throw*/
            /*  try
              {
                  int age = 15;
                  if (age < 18)
                  {
                      throw new Exception("you are not eligible");

                  }
                  Console.WriteLine("you are eligible");
              }
              catch (Exception ex)
              {
                  Console.WriteLine(ex.Message);
              }*/

            /*Divide two numbers and handle division by zero using try and catch.*/
            /*  try
              {
                  Console.WriteLine("enter number1");
                  int num1 = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("enter number2");
                  int num2 = Convert.ToInt32(Console.ReadLine());

                  int result = num1 / num2;
                  Console.WriteLine("result: " + result);
              }
              catch (Exception ex)
              {
                  Console.WriteLine("cannot divide by zero");*/

            /*Accept a number and handle invalid input.*/

            /* try
             {
                     Console.WriteLine("enter number");
                     int num = Convert.ToInt32(Console.ReadLine());
             }
                 catch(Exception)
                 {
                     Console.WriteLine("invalid input");
                 }*/

            /*Accept an age and use throw if the age is less than 18.*/
            /* try
             {
                 Console.WriteLine("enter age");
                 int age = Convert.ToInt32(Console.ReadLine());
                 if (age < 18)
                 {
                     throw new Exception("you are not eligible");
                 }
                 Console.WriteLine("you are eligible");
             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex.Message);


             }*/

            /*Display a message using finally after dividing two numbers.*/
            /*  try
              {
                  Console.WriteLine("Enter first number:");
                  int a = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("Enter second number:");
                  int b = Convert.ToInt32(Console.ReadLine());

                  int result = a / b;

                  Console.WriteLine("Result = " + result);
              }
              catch (DivideByZeroException)
              {
                  Console.WriteLine("Cannot divide by zero.");
              }
              finally
              {
                  Console.WriteLine("Division operation completed.");
              }*/

            /*Accept a product price and use throw if the price is negative.*/

            try
            {
                Console.WriteLine("enter product price");
                int price = Convert.ToInt32(Console.ReadLine());
                if (price < 0)
                {
                    throw new Exception("price is negative");
                }
                Console.WriteLine("price is correct");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


    }
}
}
