using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_practice_program_2
{
    internal class Program
    {
        /*Create an abstract class Person with an abstract method Role(). Create Student, Teacher, and Doctor classes.*/
        /*   abstract class person
           {
               public abstract void role();
           }

           class student : person
           {
               public override void role()
               {
                   Console.WriteLine("this is the student role");
               }
           }
           class teacher: person
           {
               public override void role()
               {
                   Console.WriteLine("this is the teacher role");
               }
           }
           class doctor : person
           {
               public override void role()
               {
                   Console.WriteLine("this is the doctor role");
               }
           }*/

        /* Create an abstract class Bank with an abstract method GetInterestRate(). Create SBI and HDFC classes with different interest rates.*/

        /*    abstract class bank
            {
                public abstract void GetInterestRate();
            }
            class sbi : bank
            {
                public override void GetInterestRate()
                {

                    Console.WriteLine("interest rate is 3000");
                }
            }
            class hdfc : bank
            {
                public override void GetInterestRate()
                {
                    Console.WriteLine("interest rate is 40000");
                }
            }*/
        /* Create an abstract class Animal containing: Abstract method Sound() Normal method Eat().  Create a Dog class and call both methods.*/
        /*    abstract class animal
            {
                public abstract void sound();

            public void eat()
            {
                Console.WriteLine("this is the eat method");
            }
            }
            class dog : animal
            {
            public override void sound() {
                Console.WriteLine("this is the dog method");
            }

            }*/
        /* Create an abstract class Appliance with an abstract method TurnOn(). Create TV, Fan, and WashingMachine classes.*/

        /*  abstract class appliance
          {
              public abstract void turnon();
          }
          class tv : appliance
          {
              public override void turnon()
              {
                  Console.WriteLine("this is the TV ");
              }
          }
          class fan : appliance
          {
              public override void turnon()
              {
                  Console.WriteLine("this is the fan");
              }
          }
          class washingmachine : appliance
          {
              public override void turnon()
              {

                  Console.WriteLine("this is the washing machine");
              }
          } */

        /* Create an abstract class Calculator with an abstract method Calculate(). Create Addition and Subtraction classes.*/
        abstract class calculator
        {
            public abstract void calculate();
        }
        class addition : calculator
        {
            public override void calculate()
            {
                int x = 10;
                int y = 10;
                int add = x + y;
                Console.WriteLine("addition =" + add);
            }
        }
        class subtraction : calculator
        {
            public override void calculate()
            {
                int x = 10;
                int y = 10;
                int sub = x - y;
                Console.WriteLine("subtraction =" + sub);
            }
        }



        static void Main(string[] args)
            {
                /*  student s = new student();
                  s.role();
                  teacher t = new teacher();
                  t.role();
                  doctor d = new doctor();
                  d.role();*/

        /* sbi s = new sbi();
         s.GetInterestRate();
         hdfc h = new hdfc();
         h.GetInterestRate();*/

        /*   dog d = new dog();
           d.sound();
           d.eat(); */

        /*  washingmachine washingmachine = new washingmachine();
          washingmachine.turnon();
          fan fan = new fan();
          fan.turnon();
          tv tv = new tv();
          tv.turnon();*/

            addition ad = new addition();
            ad.calculate();
            subtraction sb = new subtraction();
            sb.calculate();





    }
}
}
