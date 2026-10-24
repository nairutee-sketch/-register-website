using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor

{
    /* single inheritance */
    public class A
    {
        /*  public void d()
          {
              Console.WriteLine("I am a single inheritance");
          }*/
      }
        internal class Program : A
        {

            /* void disp1()
             {
                 Console.WriteLine("i am a class program");
             }*/


            /* public Program()
             {
                 string name = "programmer";
                 Console.WriteLine(name);
             }*/

            /* parameter constructor */
            /* int x, y;
             public Program (int a, int b) 
             {
                 x = a; y = b;
             }
             void disp2()
             {
                 int add = x + y;
                 Console.WriteLine(add);
             }*/

            /* using this */

            /* int a , b ;
             public Program (int a , int b)
             {
                 this.a = a;
                 this.b = b;
             }
             void disp3()
             {
                 int add = this.a + this.b;
                 Console.WriteLine(add);
             }*/

            /* constructor*/

            class student
            {
              public  string name;

            
            public student()
            {
                name = "developer";
               /* Console.WriteLine(name);*/
            }
        }



        static void Main(string[] args)
        {
            /* Program p1 = new Program(10,20);
             p1.disp2();*/

            /*Program p1 = new Program(40, 20);
            p1.disp3 ();*/

         /*  Program p1 = new Program();
            p1.disp1(); /* parent class object is created and we can also use child class object in it */
           /* p1.d();*/

            student s = new student();
                Console.WriteLine(s.name);


        }
    }
}
