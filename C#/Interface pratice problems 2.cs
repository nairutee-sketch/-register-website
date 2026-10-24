using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_problems_2
{
    internal class Program
    {
        /*Create an interface IPerson containing a Name property and a Display() method. Create a Person class.*/
        /*  interface Iperson
          {
              string name { get; set; }
              void method ();
          }
          class person : Iperson
          {
              public string  name { get; set; }

              public void method()
              {
                  Console.WriteLine("name: " + name);
              }

          } */

        /* Create an interface IProduct containing Name and Price properties. Create a Product class and display the details.*/

        /*  interface Iproduct
          {
              string name { get; set; } 
              float price { get; set; }

          }
          class Product : Iproduct
          {
             public  string name { get; set; }
            public   float price { get; set; }
              public void display()
              {
                  Console.WriteLine("name = " + name);
                  Console.WriteLine("price =" + price);
              }
          } */
        /* Create an interface IStudent containing Name and Marks properties. Display the student's details.*/
        /*   interface Istudent { 
               string name { get; set;  }
               int marks { get; set; }
           }
           class student : Istudent
           {
               public string name { get; set; }
               public int marks { get; set; }
               public void display()
               {
                   Console.WriteLine("name = " + name);
                   Console.WriteLine("marks = " + marks);
               }
           }*/
        /* Create an interface IEmployee containing Id, Name, and Salary properties. Display employee details*/
        /*  interface Iemplyoee
          {
              string name { get; set; }
              int id { get; set; }
              float salary { get; set; }

          }
          class employee : Iemplyoee
          {
              public string name { get; set; }
              public int id { get; set; }
              public float salary { get; set; }

              public void display()
              {
                  Console.WriteLine("name= " +  name);
                  Console.WriteLine("id =" +  id);
                  Console.WriteLine("salary=" + salary);
              }
          }*/

        /* Create an interface ICar containing Brand, Model, and Price properties. Create a Car class. */
        /*  interface Icar
          {
              string brand {  get; set; }
              string model { get; set; }
              float price { get; set; }
          }

          class car : Icar
          {
              public string brand { get; set; }
              public float price { get; set; }
              public string model { get; set; }

              public void display()
              {
                  Console.WriteLine("brand =" + brand);
                  Console.WriteLine("price =" + price);
                  Console.WriteLine("model=" + model);
              }
          }*/
        /*  Create two interfaces IAnimal and IMovable. Create a Dog class that implements both interfaces.*/

        /*  interface Ianimal
          {
              void sound();
          }
          interface Imovable
          {
              void move();
          }
          class dog : Ianimal, Imovable
          {
              public void sound()
              {
                  Console.WriteLine("dog barks");

              }
              public void move()
              {
                  Console.WriteLine("dog runs");
              }

          }*/

        /* Create two interfaces IPayment and IReceipt. Create a Payment class that implements both interfaces.*/
        /*   interface Ipayment
           {
               void pay();
           }
           interface Ireceipt
           {
               void receipt();
           }
           class Payment : Ipayment, Ireceipt
           {
               public void pay()
               {
                   Console.WriteLine("this is the payment ");
               }

               public void receipt()
               {
                   Console.WriteLine("this is the receipt");
               }
           }*/
        /* Create two interfaces IShape and IColor. Create a Circle class that implements both interfaces.*/
        /*   interface Ishape
           {
               void shape();
           }
           interface Icolor
           {
               void color ();
           }

           class circle : Ishape, Icolor
           {
               public void shape()
               {
                   Console.WriteLine("this is the shape ");
               }
               public void color()
               {
                   Console.WriteLine("this is the color");
               }
           } */

        /* Create interfaces IPrintable and IScannable. Create a Printer class that implements both interfaces */

        /*   interface Iprintable
           {
               void print();
           }
           interface Iscannable
           {
               void scan ();
           }

           class printer : Iprintable, Iscannable
           {
               public void print()
               {
                   Console.WriteLine("this is the printer");
               }
               public void scan()
               {
                   Console.WriteLine("this is the scanner");
               }
           }*/

        /* Create interfaces IEmployee and IManager. Create a Manager class that implements both interfaces.*/

interface Iemplyoee
        {
            void emplyoee();
        }
        interface Imanager
        {
            void manage();
        }

        class manager : Iemplyoee, Imanager
        {
            public void emplyoee()
            {
                Console.WriteLine("emplyoee salary is 34000");
            }
            public void manage()
            {
                Console.WriteLine("manager salary is 78000");
            }
        }










                               
        static void Main(string[] args)
                                {
                    /* person p = new person();
                       p.name = "test";
                   Console.WriteLine(p.name);*/

        /*  Product p = new Product();
          p.name = "test";
           p.price = 34.5f;
            p.display();*/

        /*  student stu = new student();
          stu.marks = 67;
          stu.name = "test";
          stu.display();*/

        /* employee e = new employee();

         e.name = "developer";
         e.id = 345;
         e.salary = 23400;
         e.display();*/

        /*  car c = new car();
          c.price = 100;
          c.model = "mnv";
          c.brand = "honda";
          c.display(); */

        /* dog d = new dog();
             d.sound();
             d.move();*/

        /*   Payment p = new Payment();
           p.receipt();
           p.pay();*/

        /*   circle c = new circle();
           c.shape();
           c.color(); */


      /*  printer pr = new printer();
            pr.print();
            pr.scan(); */


manager m = new manager();
            m.manage();
            m.emplyoee();



    }
}
}
