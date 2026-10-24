using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding___Runtime_Polymorphism
{
    class Program
    {

        /* Create an Animal class with a virtual Sound() method.Create Dog and Cat classes and override Sound().*/
        /* class animal
          {
              public virtual void sound()
              {
                  Console.WriteLine("animal makes sound");
              }

          }
          class dog : animal
          {
              public override void sound()
              {
                  Console.WriteLine("dog barks");
              }
          }
          class cat : animal
          {
              public override void sound()
              {
                  Console.WriteLine("cat meows");
              }
          }*/

        /*Create a Vehicle class with a virtual Start() method. Create Car and Bike classes and override Start().*/
        /*   class vehicle
           {
               public virtual void Start()
               {
                   Console.WriteLine("this is a vehicle");
               }
           }
           class Car: vehicle
           {
               public override void Start()
               {
                   Console.WriteLine("this is a car");
               }
           }
           class bike : vehicle
           {
               public override void Start()
               {
                   Console.WriteLine("this is a bike");
               }
           }*/
        /* Create a Shape class with a virtual Draw() method.Create Circle and Rectangle classes and override Draw().*/
        /*class shape
        {
            public virtual void Draw()
            {
                Console.WriteLine("this is drawing");
            }
        }
        class circle: shape
        {
            public override void Draw()
            {
                Console.WriteLine("this is a circle shape");     
            }
        }
        class rectangle : shape
        {
            public override void Draw()
            {
                Console.WriteLine("this is a rectangle shape");
            }
        }*/

        /*Create an Employee class with a virtual Work() method. Create Manager and Developer classes and override Work().*/
        /*  class Employee
          {
              public virtual void Work()
              {
                  Console.WriteLine("this is the employee");
              }
          }
          class Manager : Employee
          {
              public override void Work()
              {
                  Console.WriteLine("this is the manager");
              }
          }
          class Developer : Employee
          {
              public override void Work()
              {
                  Console.WriteLine("this is the developer");
              }
          }*/
        /*Create a Bank class with a virtual Interest() method. Create SBI and HDFC classes and override Interest().*/
        class Bank
        {
            public virtual void Interest()
            {

            }


        }
        class SBI: Bank
        {
            public override void Interest()
            {
                Console.WriteLine("this is SBI bank");
            }
        }
        class HDFC : Bank
        {
            public override void Interest()
            {
                Console.WriteLine("this is the hdfc bank");
            }
        }

        static void Main(string[] args)
                  {
            /* animal a1 = new dog();
             animal a2 = new cat();
             a1.sound();
             a2.sound();
             Console.ReadLine();*/

            /* vehicle v1 = new Car();
             vehicle v2 = new bike();
             v1.Start();
             v2.Start();
             Console.ReadLine();*/

            /* shape s1 = new circle();
             shape s2 = new rectangle();
             s1.Draw();
             s2.Draw();
             Console.ReadLine();*/

            /*Employee e1 = new Manager(); means the reference type is Employee, but the actual object is Manager. Therefore, at runtime, the Manager's Work() method is called.*/
            /*Employee e1 = new Manager();
            Employee e2 = new Developer();
            e1.Work();
            e2.Work();
            Console.ReadLine();*/

            Bank b1 = new SBI();
            Bank b2 = new HDFC();
            b1.Interest();
            b2.Interest();
            Console.ReadLine();




    }
}
}
