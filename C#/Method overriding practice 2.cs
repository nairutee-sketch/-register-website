using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overriding_practice_2
{
    class Program
    {
        /*Create a Payment class with a virtual Pay() method. Create CashPayment, CardPayment, and UPIPayment classes.*/
        /* class Payment
         {
             public virtual void pay()
             {
                 Console.WriteLine("this is the pay method");
             }
         }

         class CashPayment : Payment
         {
             public override void pay()
             {
                 Console.WriteLine("this is cashpayment");
             }
         }
         class cardpayment : Payment
         {
             public override void pay()
             {
                 Console.WriteLine("this is cardpayment");
             }
         }
         class UPIPayment : Payment
         {
             public override void pay()
             {
                 Console.WriteLine("this is UPIpayment");
             }
         } */

        /*Create a Person class with a virtual Role() method.Create Student, Teacher, and Doctor classes and override Role().*/
        /* class Person
              {
                  public virtual void role()
                  {
                      Console.WriteLine("this is the role");
                  }
              }
              class student:Person
              {
                  public override void role()
                  {
                      Console.WriteLine("this is the student role");
                  }
              }
              class Teacher : Person
              {
                  public override void role()
                  {
                      Console.WriteLine("this is the teacher role");
                  }
              }
      class Doctor : Person
              {
                  public override void role()
                  {
                      Console.WriteLine("this is the doctor role");
                  }
              }*/

        /* Create a Mobile class with a virtual Brand() method.Create Samsung and Apple classes and override Brand().*/
        /* class Mobile
             {
                 public virtual void Brand()
                 {
                     Console.WriteLine("this is the brand");
                 }
             }
             class Samsung : Mobile
             {
                 public override void Brand()
                 {
                     Console.WriteLine("this is the samsung brand");
                 }
             }
             class Apple : Mobile
             {
                 public override void Brand()
                 {
                     Console.WriteLine("this is the apple brand");
                 }
             }*/

        /*Create an Employee class with a virtual Salary() method. Create Manager and Developer classes with different salary outputs.*/
        /* class Employee
                {
                    public virtual void Salary()
                    {
                        Console.WriteLine("employee salary");
                    }
                }
                class Manager : Employee
                {
                    public override void Salary()
                    {
                        Console.WriteLine("manager salary is 80,000");
                    }
                }
                class Developer : Employee
                {
                    public override void Salary()
                    {
                        Console.WriteLine("developer salary is 60,000");
                    }
                }*/

    /*    Create a Food class with a virtual Taste() method.Create Pizza, Burger, and IceCream classes and override Taste().*/
         class food
        {
            public virtual void Taste()
            {
                Console.WriteLine("this is the taste");
            }
        }

        class pizza : food
        {
            public override void Taste()
            {
                Console.WriteLine("this is the pizza taste");



            }
        }
        class burger: food
        {
            public override void Taste()
            {
                Console.WriteLine("this is the burger food");


            }
        }

        class icecream : food
        {
            public override void Taste()
            {
                Console.WriteLine("this is the ice-cream taaste");
            }
        }


        static void Main(string[] args)
        {
            /*  Payment p1 = new CashPayment();
              Payment p2 = new cardpayment();
              Payment p3 = new UPIPayment();
              p1.pay();
              p2.pay();
              p3.pay();
              Console.ReadLine();*/

            /* Person p1 = new student();
             Person p2 = new Teacher();
             Person p3 = new Doctor();
             p1.role();
             p2.role();
             p3.role();
             Console.ReadLine();*/

            /* Mobile m1 = new Samsung();
             m1.Brand();
             Mobile m2 = new Apple();
             m2.Brand();
             Console.ReadLine();*/

            /*  Employee e = new Manager();
                  e.Salary();
              Employee e1 = new Developer();
              e1.Salary();
              Console.ReadLine(); */

            food f = new pizza();
            f.Taste();
            food f1 = new burger();
            f1.Taste();
            food f2 = new icecream();
            f2.Taste();
            Console.ReadLine();



        }
}
}
