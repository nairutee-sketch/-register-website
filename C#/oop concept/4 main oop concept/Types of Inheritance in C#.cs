using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_of_Inheritance_in_C_
{
    internal class Program
    {
        /* single inheritance */
        /* class animal
         {
             public void eat ()
             {
                 Console.WriteLine("animal is eating");
             }
         }

         class dog : animal
         {
             public void bark()
             {
                 Console.WriteLine("dog is barking");
             }
         }*/

        /* multilevel inheritance */

        /*  class animal
          {
                  public void eat()
              {
                  Console.WriteLine("animal is eating");
              }
          }
          class mammal:animal
          {
              public void walk() 
              {
                  Console.WriteLine("mammal is walking");
              }
          }
          class dog : mammal
          {
              public void bark()
              {
                  Console.WriteLine("dog is barking");
              }
          }*/

        /* Hierarchical Inheritance */

        class animal
        {
            public void eat()
            {
                Console.WriteLine("animal is eating");

            }
        }
        class dog:animal
        {
            public void bark()
            {
                Console.WriteLine("dog is barking");
            }
         }
        class cat :animal
        {
            public void meow()
            {
                Console.WriteLine("cat is meowing");
            }
        }

        static void Main(string[] args)
        {
            /*single inheritance */
            /*  dog d = new dog();
              d.eat();
              d.bark();*/

            /* multilevel inheritance */
            /*  dog d = new dog();
              d.bark();
              d.eat();
              d.walk();*/

            /*Hierarchical Inheritance*/

            dog d = new dog();
            d.eat ();
            d.bark();

            cat c =new cat();
            c.eat();
            c.meow();


}
}
}
