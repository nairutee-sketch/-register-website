using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract__practice_program
{
    internal class Program
    {
        /*Create an abstract class Animal with an abstract method Sound(). Create Dog and Cat classes and override Sound().*/

        /*  abstract class animal
          {
              public abstract void sound();
          }
          class dog : animal
          {
              public override void sound()
              {
                  Console.WriteLine("dog is barking");
              }
          }
          class cat : animal
          {
              public override void sound()
              {
                  Console.WriteLine("cat is meow");
              }
          }*/

        /*2. Vehicle – Start

/*Create an abstract class Vehicle with an abstract method Start(). Create Car and Bike classes and display different starting messages.*/
        /*   abstract class vehicle
           {
               public abstract void start();
           }
           class car : vehicle
           {
               public override void start()
               {
                   Console.WriteLine("car is bmw");
               }
           }
           class bike : vehicle
           {
               public override void start()
               {
                   Console.WriteLine("bike is honda");
               }
           }*/

        /*Create an abstract class Shape with an abstract method Area(). Create Circle and Rectangle classes and calculate their areas.*/
        /*    abstract class shape
            {
                public abstract void area();
            }
            class circle : shape
            {
                public override void area()
                {
                    float r = 10;
                    float a = 3.14f * r * r;
                    Console.WriteLine("area of circle is =" + a);

                }
            }
            class rectangle :shape
            {
                public override void area()
                {
                    int l = 20;
                    int w = 20;
                    int a = l * w;
                    Console.WriteLine("area of rectangle =" + a);

                }
            }*/

        /*Create an abstract class Employee with an abstract method Work(). Create Manager and Developer classes and display their work.*/
        /*   abstract class emplyoee
           {
               public abstract void work();
           }
           class manager: emplyoee
           {
               public override void work()
               {
                   Console.WriteLine("manager salary is 6000");
               }
           }
           class developer: emplyoee
           {
               public override void work()
               {
                   Console.WriteLine("developer salary is 3000");
               }
           }*/

      /*  Create an abstract class Payment with an abstract method Pay(). Create CashPayment, CardPayment, and UPIPayment classes.*/

     /*   abstract class payment
        {
            public abstract void pay();

        }
        class cashpayment : payment
        {
            public override void pay()
            {
                Console.WriteLine("this is the cash payment");
            }
        }
        class cardpayment : payment
        {
            public override void pay()
            {
                Console.WriteLine("this is the card payment");
            }
        }
        class UPIpayment : payment
        {
            public override void pay()
            {
                Console.WriteLine("this is the upi payment");
            }
        }*/

                static void Main(string[] args)
                {
            /*  dog d = new dog();
              d.sound ();
              cat c = new cat ();
              c.sound();*/

            /*  car c = new car();
              c.start();
              bike b = new bike();
              b.start();*/

            /*  circle c = new circle();
              c.area();
              rectangle r = new rectangle();
              r.area();*/

            /*  manager m = new manager();
              m.work();
              developer d = new developer();
              d.work();*/

         /*   cardpayment c = new cardpayment();
            c.pay();
            cashpayment ch = new cashpayment();
            ch.pay();
            UPIpayment u = new UPIpayment();
            u.pay();*/




    }
}
}
