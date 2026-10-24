using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_in_c_
{
    internal class Program
    {
        class student
        {
            public static string collegename = "Atharva college";
            public string name;

            public static void display()
            {
                Console.WriteLine("college name =" + collegename);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(student.collegename);

            student.display();

            student s=new student();
            s.name = "developer";
            Console.WriteLine("student name = " + s.name);
        }
    }
}
