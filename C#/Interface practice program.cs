using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_practice_problem
{
    internal class Program
    {
        /* Create an interface IAnimal with a method Sound(). Create a Dog class and implement the interface.*/
        /*   interface Ianimal
             {
            void sound();
            }   
            
                 
            class dog : Ianimal
              {
                     public void sound()
                   {
                        Console.WriteLine("dog barks");
                    }

                } */

        /* Create an interface IVehicle with a method Start(). Create Car and Bike classes and implement the interface. */
        /*   interface Ivehicle
           {
               void start();
           }
           class car : Ivehicle
           {
               public void start() {
                   Console.WriteLine("car started");
               }
           }
           class bike : Ivehicle
           {
               public void start()
               {
                   Console.WriteLine("bike started");
               }
           } */


        /*   Create an interface IStudent with a method Display(). Create a Student class and display student details.*/
        /*  interface Istudent
             {
                 void display();
             }

             class student : Istudent
             {
                 public void display() {
                     Console.WriteLine("student name: developer");
                     Console.WriteLine("student age : 34");
                     Console.WriteLine("student course: asp.net");
                 }

             }*/

        /* Create an interface IPayment with a method Pay(). Create CashPayment and CardPayment classes.*/
        /*   interface Ipayment
           {
               void pay();
           }
           class cashpayment : Ipayment
           {
               public void pay()
               {
                   Console.WriteLine("thsi is the cashpayment");
               }
           }
           class cardpayment : Ipayment
           {
               public void pay()
               {
                   Console.WriteLine("this is the cardpayment");
               }
           }*/

        /*Create an interface IShape with a method Area(). Create a Circle class and calculate its area.*/
        /*  interface Ishape
          {
              void area();
          }
          class circle : Ishape
          {
              public void area()
              {
                  float r = 34;
                  float area = 3.14f * r * r;
                  Console.WriteLine("area of circle =" + area);
              }
          } */

        /* Create an interface IAnimal with a method Sound(). Create Dog, Cat, and Cow classes and implement the interface.*/

        /*   interface Ianimal
           {
               void sound();
           }

           class dog : Ianimal
           {
               public void sound()
               {
                   Console.WriteLine("dog barks");
               }
           }
           class cat : Ianimal
           {
               public void sound()
               {
                   Console.WriteLine("cat meows");
               }
           }
           class cow : Ianimal
           {
               public void sound()
               {
                   Console.WriteLine("cow sound");
               }
           } */

        /*Create an interface IVehicle with a method Start(). Create Car, Bike, and Bus classes with different starting messages.*/
        /*  interface Ivehicle
          {
              void start();
          }
          class car : Ivehicle
          {
              public void start() {
                  Console.WriteLine("this is the car");
              }
          }
          class bike : Ivehicle
          {
              public void start()
              {
                  Console.WriteLine("this is the bike");
              }
          }
          class bus : Ivehicle
          {
              public void start()
              {
                  Console.WriteLine("this is the bus");
              }
          }*/

        /* Create an interface IEmployee with a method Work(). Create Manager and Developer classes and display their work.*/

        /*   interface Iemployee
           {
               void work();
           }
           class manager : Iemployee
           {
               public void work()
               {
                   Console.WriteLine("manager manages the work");
               }
           }
           class developer : Iemployee
           {
               public void work()
               {
                   Console.WriteLine("developer develops the code");
               }
           } */
        /* Create an interface IPayment with a method Pay(). Create CashPayment, CardPayment, and UPIPayment classes.*/

        /*   interface Ipayment
           {
               void pay();
           }
           class cashpayment : Ipayment
           {
               public void pay()
               {
                   Console.WriteLine("this is the cashpayment");
               }
           }

           class cardpayment : Ipayment
           {
               public void pay()
               {
                   Console.WriteLine("this is the cardpayment");
               }
           }
           class UPIpayment : Ipayment
           {
               public void pay()
               {
                   Console.WriteLine("this is the UPIpayment");
               }
           }*/
        /* Create an interface IShape with a method Area(). Create Circle, Rectangle, and Square classes.*/

        interface Ishape
        {
            void area();
        }
        class circle : Ishape
        {
            public void area()
            {
                float r = 30;
                float area = 3.14f * r * r;
                Console.WriteLine("area of circle =" + area);

            }
        }
        class rectangle : Ishape
        {
            public void area()
            {
                float l = 23;
                float b = 90;
                float area = l * b;
                Console.WriteLine("area of rectangle =" + area);
            }
        }
        class square : Ishape
        {
            public void area()
            {
                float a = 45;
                float area = a * a;
                Console.WriteLine("area of a square =" + area);
            }
        }




           static void Main(string[] args)
                              {
       /*  dog g = new dog();
            g.sound(); */

        /* car c = new car();
         c.start();
         bike b = new bike();
         b.start();*/

        /*  student s = new student();
          s.display();*/

        /*   cashpayment cp = new cashpayment();
           cp.pay();
           cardpayment p = new cardpayment();
           p.pay();*/

        /*  circle c = new circle();
              c.area(); */

        /*    dog d = new dog();
            d.sound();
            cat c = new cat ();
            c.sound ();
            cow  w = new cow ();
            w.sound (); */

        /*  car c = new car();
          c.start();
          bike b = new bike();
          b.start();
          bus  bus = new bus();
          bus .start(); */

        /*  manager manager = new manager();
          manager.work();
          developer d = new developer();
          d.work(); */

        /*  cashpayment cp = new cashpayment();
          cp.pay();
          cardpayment c = new cardpayment();
          c.pay();
          UPIpayment uPIpayment = new UPIpayment();
          uPIpayment.pay(); */

            circle c = new circle();
            c.area();
            rectangle r = new rectangle();
            r.area();
            square square = new square();
            square.area();  












    }
}
}
