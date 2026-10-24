using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NairutiConsoleApp2
{
    internal class Program
     {
        void display()
        {
            Console.WriteLine("I am a software developer");
        }
        static void Main(string[] args)
        {
            Console.Write("hello world");
            Console.WriteLine("hello I am learning c#");

            int a = 10;
            int b = 20;
            int add = a + b;
            Console.WriteLine(add); /* writeline used to bring data in newline */

            Double c = 10.2;
            String d = "programmer";
            Console.WriteLine("my salary is" + c);
            Console.WriteLine("my name is" + d);

            String name;
            Console.WriteLine("enter your name");
            name = Console.ReadLine();
            Console.WriteLine("my name is" + name);


            int e, f;
            Console.WriteLine("enter 1st no");
            e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd no");
            f = Convert.ToInt32(Console.ReadLine());
            int addition = e + f;
            Console.WriteLine("addition of two no is" + addition);


            Program p1 = new Program();
            p1.display();
            Console.ReadKey();




        }
    }
}
