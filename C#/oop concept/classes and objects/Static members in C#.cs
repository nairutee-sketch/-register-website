using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Static_members_in_C_
{
    internal class Program
    {
       /* class student
        {
            public string Name;
            public static int studentcount = 0;

            public student(string name) {
                Name = name;
                studentcount++;
            

            }
            public static void displaystudentcount()
            {
                Console.WriteLine("total student=" + studentcount);
            }

        }*/

        class calculator
        {
            public static int add(int x, int y)
            {
                return x + y;

            }
        }
        static void Main(string[] args)
        {
            /* student s1 = new student("rahul");
             student s2 = new student("priya");
             student s3 = new student("amit");
             student.displaystudentcount();
             Console.ReadLine();*/

            /* no need to make object in static method */
            int result = calculator.add(10, 20);
            Console.WriteLine("sum =" +  result);

        }
    }
}
