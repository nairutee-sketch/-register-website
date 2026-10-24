using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
     /*   interface vehicle
        {
            void start();
            void stop();
        }
        class car : vehicle
        {
            public void start()
            {
                Console.WriteLine("car starts");
            }
            public void stop ()
            {
                Console.WriteLine("car stops");
            }
        } */

        abstract class emplyoee
        {
            protected string name;
            public emplyoee (string name)
            {
                this.name = name;
            }
            public abstract void calculatesalary();

            public void displayname()
            {
                Console.WriteLine ("emplyoee" +  name);
            }
        }
         interface bonus
        {
            void calculatebonus();
        }
        class manager : emplyoee, bonus
        {
            public manager(string name) : base(name) { }
            public override void calculatesalary()
            {
                Console.WriteLine("manager salary =8000");

            }
            public void calculatebonus()
            {
                Console.WriteLine("manager bonus = 2000");
            }

        }
          
        static void Main(string[] args)
        {
            /*  car c = new car();
              c.start();
              c.stop(); */

            manager m = new manager("developer");
            m.calculatesalary();
            m.calculatebonus();
            m.displayname();
        }
    }
}
