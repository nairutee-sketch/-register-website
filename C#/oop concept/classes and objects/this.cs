using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace my_practice_constructor_problems2
{
    internal class Program
{

        /*  class product
          {
              int id;
              string name;
              int price;

              public product(int id, string name, int price)
              {
                  this .id = id;
                  this.name = name;
                  this.price = price;
              }

              public void  Display()
              {
                  Console.WriteLine("id is " + id);
                  Console.WriteLine("name is" + name);
                  Console.WriteLine("price is " +  price);

              }

          }*/

        /* class car
         {
             string model;
             int price;


             public car () {
                 model ="bmw";
                 price= 20000;
             }

             public car(string model, int price)
             {
                 this.model = model;
                 this.price = price;
             }

             public void display()
             {
                 Console.WriteLine("model is " + model);
                 Console.WriteLine("price is" + price);
             }
         }*/

        /*  class BankAccount
          {
              int accountno;
              string name;
              int balance;


              public  BankAccount(int accountno, string name , int balance)
              {
                      this.accountno = accountno;
                      this.name = name;
                      this.balance  = balance;
              }

              public void display()
              {
                  Console.WriteLine("accountno =" + accountno);
                  Console.WriteLine("name =" + name);
                  Console.WriteLine("balance =" + balance);
              }

          }*/

        class CollegeStudent
        {
            int rollnumber;
            string name;
            string course;


            public CollegeStudent(int rollnumber, string name, string course)
            {
                this.rollnumber = rollnumber;
                this.name = name;
                this.course = course;
            }

            public void display()
            {
                Console.WriteLine("rollnumber = " + rollnumber);
                Console.WriteLine("name =" + name);
                Console.WriteLine("course =" + course);
            }
        }

        class Student
        {

            int maths;
            int english;
            int hindi;

            public Student (int maths , int english, int hindi)
            {
                this.maths = maths;
                this.english = english;
                this.hindi = hindi;
            }

            public void display ()
            {
                int total = maths + english + hindi;
                Console.WriteLine( "total = " + total );
            }
        }

        static void Main(string[] args)
        {
            /*Create a Product class with product ID, product name, and price.Initialize these values using a parameterized constructor and display them.*/

            /* product p = new product(1, "lays", 100);
             p.Display();*/

            /* Create a Car class containing model name and price.Implement both a default constructor and a parameterized constructor.Display the values using both constructors.*/
            /*  car c = new car();
                  c.display();

              car c1 = new car("honda", 100000);
              c1.display();*/

            /*Create a BankAccount class with account number, account holder name, and balance. Use a parameterized constructor and the this keyword to initialize the data members. */
            /* BankAccount ba = new BankAccount(32,"xv", 3000);
                     ba.display();*/

            /* Create a CollegeStudent class with roll number, name, and course. Use a parameterized constructor with the this keyword to initialize and display the student details. */
           /* CollegeStudent cs = new CollegeStudent(12,"vfg","maths");
            cs.display();*/

          /*  Create a Student class with name and marks of three subjects.Use a parameterized constructor and the this keyword to initialize the values.Calculate and display the total marks. */
          Student s = new Student( 23, 78, 80);
            s.display();


}
}
}
