using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_in_C_
{
    /*Overloading: same name, different parameters, decided at compile time.
Overriding: child replaces the parent's method, decided at runtime.*/

    internal class Program
    {  /* method overloading - same method name can have different parameter*/
    /* class calculator
     {
         public int add(int x, int y)
         {
         return x+y; 

     }
     public int add(int a,int b,int c)
         {
             return a+b+c;
         }

}*/

    /* method overriding - occurs when a child class provides its own version of a method already defined in its parent class.
     * diffrent class with same method
     */
    class animal
        {
            public virtual void sound()
            {
                Console.WriteLine("animal makes a sound");
            }

        }

        class dog : animal
        {
            public override void sound()
            {
                Console.WriteLine("dog barks");
            }
        }

        class cat:animal
        {
            public override void sound()
            {
                Console.WriteLine("cats meow");
            }
        }
         static void Main(string[] args)
         {

            /* calculator c = new calculator();
            Console.WriteLine("sum of 2 no ="+ c.add(10, 20));
           Console.WriteLine ("sum of 3 no =" +c.add(10, 20, 30));*/

            animal a1 = new dog();
            animal a2 = new cat();
            a1.sound();
            a2.sound();







    }
}
}
