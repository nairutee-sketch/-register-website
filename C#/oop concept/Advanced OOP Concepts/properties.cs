using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties_c_
{
    internal class Program

    {
        /* properties*/
        class student
        {
            public string Name { get; set; }
            public int age { get; set; }
        }
        static void Main(string[] args)

        {
            student s = new student();
            s.Name = "Developer";
            s.age = 34;

            Console.WriteLine("student name =" +  s.Name);
            Console.WriteLine("age =" + s.age);

        }
    }
}
