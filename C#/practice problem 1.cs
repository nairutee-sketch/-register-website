using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_problems_1
{
    internal class Program
    {
 
        
        
        static void Main(string[] args)
        {
            /*Write a C# program to accept a student's name and marks in five subjects. Calculate and display the total marks, average, and percentage using appropriate data types. */

            /*  string name;
              float m1 , m2,m3,m4,m5;
              float total, average, percentage;

              Console.WriteLine("enter student name");
              name = Console.ReadLine();

              Console.WriteLine("enter marks in subject 1");
              m1 = Convert .ToSingle(Console.ReadLine());
              Console.WriteLine("enter marks in subject 2");
              m2 = Convert.ToSingle(Console.ReadLine());
              Console.WriteLine("enter marks in subject 3");
              m3 = Convert.ToSingle(Console.ReadLine());
              Console.WriteLine("enter marks in subject 4");
              m4 = Convert.ToSingle(Console.ReadLine());
              Console.WriteLine("enter marks in subject 5");
              m5 = Convert.ToSingle(Console.ReadLine());

              total = m1 + m2 + m3 + m4 +m5;
              average = total / 5;
              percentage= (total/500) * 100;

              Console.WriteLine("student name =" + name);
              Console.WriteLine("total marks=" + total);
              Console.WriteLine("average =" + average);
              Console.WriteLine("percentage= " +  percentage +"%");*/

            /* 2. Accept the number of electricity units consumed and the cost per unit as floating-point values. Calculate the total bill, including a fixed charge entered by the user. */

            /*  float unit, costperunit, totalbill, fixedcharge;
              Console.WriteLine("enter electricity units consumed");
              unit = Convert.ToSingle(Console.ReadLine());

              Console.WriteLine("enter cost per unit");
              costperunit = Convert.ToSingle(Console.ReadLine());

              Console.WriteLine("enter fixed charge");
              fixedcharge = Convert.ToSingle(Console.ReadLine());

              totalbill = (unit * costperunit)+ fixedcharge;
              Console.WriteLine("total bill = " + totalbill); */

            /*  Accept the principal amount, annual interest rate, and time in years from the user. Calculate and display the simple interest and total amount using double. */

            /*  double amount, interestrate, time;

              Console.WriteLine("enter principal amount");
              amount = Convert.ToDouble(Console.ReadLine());

              Console.WriteLine("enter interest rate");
              interestrate = Convert.ToDouble(Console.ReadLine());

              Console.WriteLine("enter time in years");
              time = Convert.ToDouble(Console.ReadLine());



            double SI = amount * interestrate * time / 100;
              double total = amount + SI;

              Console.WriteLine("simple interest =" + SI);
              Console.WriteLine("total amount =" + total); */

            /*  Accept an employee's basic salary, HRA percentage, and DA percentage. Calculate the HRA, DA, gross salary, and net salary after deducting a userentered tax percentage. */

            /*  double   basicsalary, hrapercentage, dapercentage,taxpercentage;
              double   hra, da, grosssalary, netsalary, tax;

              Console.WriteLine("enter basic salary");
              basicsalary = Convert.ToDouble(Console.ReadLine());

              Console.WriteLine("enter hra percentage");
              hrapercentage = Convert.ToDouble(Console.ReadLine());

              Console.WriteLine("enter da percentage");
              dapercentage = Convert.ToDouble(Console.ReadLine());

              Console.WriteLine("enter taxpercentage");
              taxpercentage = Convert.ToDouble(Console.ReadLine());

              hra = basicsalary * hrapercentage / 100;
              da = basicsalary * dapercentage / 100;

              grosssalary = basicsalary * hra * da;
              tax = (grosssalary *  taxpercentage) / 100;
              netsalary = grosssalary - tax;

              Console.WriteLine("hra :" + hra);
              Console.WriteLine("da:" + da);
              Console.WriteLine("gross salary" + grosssalary);
              Console.WriteLine("tax deducted" +  tax);
              Console.WriteLine("netsalary" + netsalary);*/

            /*Create a C# program that accepts a temperature in Celsius as a floating-point value and converts it into Fahrenheit and Kelvin. Display all three temperatures with two decimal places. */

          /*  double celsius , fahrenheit, kelvin;

            Console.WriteLine("enter temperature in celsius");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = (celsius * 9 / 5) + 32;
            kelvin = celsius + 273.15;

            Console.WriteLine("Celsius: " + celsius);
            Console.WriteLine("Fahrenheit: " + fahrenheit);
            Console.WriteLine("Kelvin:  "+ kelvin);*/







}
}
}
