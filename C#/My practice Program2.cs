using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_practiceConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# program to accept two integer numbers from the user and display their sum. */
            /*int a;
            int b;
            Console.WriteLine("enter 1st no");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd no");
            b = Convert.ToInt32(Console.ReadLine());
            int Sum = a + b;
            Console.WriteLine("sum of two no is " + Sum);*/

            /*Write a C# program to accept two integers and display their addition, subtraction, multiplication, and division.*/

            /*int c;
            int d;
            Console.WriteLine("enter 1st no");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd no");
            d = Convert.ToInt32(Console.ReadLine());
            int Sum = c + d;
            int mul = c * d;
            int sub = c - d;
            int div = c / d;
            Console.WriteLine("sum of two no is " + Sum);
            Console.WriteLine("mul of two no is " + mul);
            Console.WriteLine("sub of two no is " + sub);
            Console.WriteLine("div of two no is " + div);*/

            /*Write a C# program to accept principal amount, rate of interest, and time as float values and calculate simple interest.*/
            /*float p , r, t, SI;
            Console.WriteLine("enter principle amount");
            p = float.Parse(Console.ReadLine());
            Console.WriteLine("enter rate of interest");
            r = float.Parse(Console.ReadLine());
            Console.WriteLine("enter time");
            t = float.Parse(Console.ReadLine());
            SI = (p * r * t) / 100;
            Console.WriteLine("Simple Interest = " + SI);*/

            /*Write a C# program to accept the radius of a circle as a float value and calculate its area.*/

            /*float r , area;
            Console.WriteLine("enter radius of the circle");
            r = float.Parse(Console.ReadLine());
            area = 3.14f * r * r;
            Console.WriteLine("area of circle is = " + area);*/

            /*Write a C# program to accept marks of three subjects as float values and calculate their total and average.*/
            /* float hindi, english, maths , total, avg;
             Console.WriteLine("enter marks of hindi");
             hindi= float.Parse(Console.ReadLine());
             Console.WriteLine("enter marks of english");
             english= float.Parse(Console.ReadLine());
             Console.WriteLine("enter marks of maths");
             maths= float.Parse(Console.ReadLine());
             total = hindi + english + maths;
             Console.WriteLine("Total is = " +  total);
             avg = total / 3;
             Console.WriteLine("avg is = " +  avg);*/

            /*Write a C# program to accept a student's name as a string and display the name.*/
            /*string name;
            Console.WriteLine("enter the name");
            name = Console.ReadLine();
            Console.WriteLine("student name is" +  name);*/

            /*Write a C# program to accept first name and last name as strings and display the complete name using string concatenation.*/
            /* string first ,second, name ;
             Console.WriteLine("enter your first name");
             first = Console.ReadLine();
             Console.WriteLine("enter your second name");
             second = Console.ReadLine();
             name = first + second;
             Console.WriteLine("name is " + name);*/

            /* Write a C# program to accept a string from the user and display the number of characters in the string.*/
            /* string text;
            Console.WriteLine("enter your name");
             text = Console.ReadLine();
            Console.WriteLine("lenght of your name is " + text.Length);*/

            /*Write a C# program to accept temperature in Celsius as a float value and convert it into Fahrenheit.*/

            /* float c, f;
             Console.WriteLine("enter the temperature");
             c= float.Parse(Console.ReadLine());
             f = (c * 9 / 5) + 32;
             Console.WriteLine("temparature in fahrenheit" + f);*/

            /* Write a C# program to accept the price and quantity of a product and calculate the total bill amount. Use appropriate int and float variables.*/
            float price, quantity,
                total;
            Console.WriteLine("enter the price");
            price = float.Parse(Console.ReadLine());
            Console.WriteLine("enter quantity of the product");
            quantity = float.Parse(Console.ReadLine());

            total = price * quantity;
            Console.WriteLine("total is = " +  total);












}


}
}
