using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program

    {
        abstract class animal
        {
            public abstract void sound();
                public void eat()
            {
                Console.WriteLine("animal is eating");
            }
        }
        class dog : animal
        {
            public override void sound()
            {
                Console.WriteLine("Dog barks");
            }
        }
        static void Main(string[] args)
        {
            dog d = new dog();
            d.eat();
            d.sound();
        }
    }
}
