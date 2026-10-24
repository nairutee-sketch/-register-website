using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifier_in_C_
{
    internal class Program
    {     /* public*/
        /* class student
         {
             public string name = "developer";
         }*/

        /*private */

      /*  class student
        {
            private int age = 34;

            public void display()
            {
                Console.WriteLine(age);
            }
        }*/

        /* protected */

      /*  class animal
        {
            protected string name = "puppy";

        }
        class dog : animal
        {
            public void display()
            {
                Console.WriteLine(name);
            }
        } */

        /* internal */

       /* class student
        {
            internal string name = "developer";
        }*/

        /* protected internal*/

        class parent
        {
            protected internal int age = 100;

        }
        class child :parent
        {
            public void display()
            {
                Console.WriteLine(age);
            }
        }

        static void Main(string[] args)
        {
           /*  student s = new student(); /*public*/
          /* Console.WriteLine(s.name);*/

           /* student s = new student(); /*private*/
           /* s.display();*/ 

           /* dog d = new dog(); /*protected */
            /*d.display();*/
            
           /* student s = new student(); /*internal*/
           /* Console.WriteLine(s.name);*/

            child c = new child(); /* protected internal*/
            c.display();

        }
    }
}
