using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties_practice
{
    internal class Program
    {

        /* Create a Student class with a Name property.Accept the student's name and display it.*/
        /*  class student
           {
               public string name {  get; set; }
           }*/

        /*Create a Person class with Name and Age properties. Set and display both values.*/
        /* class person
         {
             public string name { get; set; }
             public int age { get; set; }

         }*/

        /*Create a Car class with Brand, Model, and Price properties. Display the car details.*/
        /* class car
         {
             public string Brand { get; set; }
             public string model { get; set; }
             public int price { get; set; }
         }*/

        /*  Create an Employee class with Id, Name, and Salary properties.Set and display the employee details*/

        /*    class Employee
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public int salary {  get; set; }
            }*/

        /*Create a Book class with Title, Author, and Price properties. Display the book information.*/
        /*  class Book
          {
              public string title {  get; set; }
              public string Author { get; set; }
              public int price { get; set; }
          }*/

        /*Create a Student class with Name and Marks properties using get and set.*/
        /*  class Student
          {
              private string name;
              private int marks;
              public string Name
              {
                  get
                  {
                      return name;
                  }
                  set
                  {
                      name = value;
                  }
              }
              public int Marks
              {
                  get
                  {
                      return marks;
                  }
                  set
                  {
                      marks = value;
                  }
              }
          } */


        /*   Create a Rectangle class with Length and Breadth properties.Create an Area property that returns the calculated area.*/

        /*    class rectangle
            {
                public int length {  get; set; }
                public int breadth { get ; set; }
                    public int Area
                {
                    get
                    {
                        return length * breadth;
                    }
                }
            }*/
        /*Create a Circle class with a Radius property and an Area property. Calculate and display the area.*/

        /*  class circle
          {
              public float radius {  get; set; }

              public float Area
              {
                  get
                  {
                      return 3.14f * radius * radius;
                  }
              }
          }*/

        /*Create a Product class with ProductName, Price, and Quantity properties. Create a TotalPrice property that calculates price × quantity.*/
        /* class product
         {
             public string productname {  get; set; }
             public int price { get; set; }
             public int quantity { get; set; }

             public int totalprice
             {
                 get
                 {
                     return  price * quantity;
                 }
             }
         }*/


        /*Create a BankAccount class with AccountNumber, AccountHolder, and Balance properties. Display the account details.*/

        class bankaccount
        {
            public int accountnumber {  get; set; }
            public string accountholder { get; set; }
            public int balance { get; set; }
        }

                    static void Main(string[] args)

                            {
            /*student s = new student();
             Console.WriteLine("enter the student name");
             s.name = Console.ReadLine();
            Console.WriteLine("student name is ="+ s.name);*/

            /*  person p = new person();
              p.name = "developer";
              p.age = 34;
              Console.WriteLine("name=" + p.name);
              Console.WriteLine("age = " + p.age);*/

            /*   car c = new car();
               c.Brand = "BMW";
               c.model = "xx";
               c.price = 100000;
               Console.WriteLine("price ="+c.price);
               Console.WriteLine("model ="+c.model);
               Console.WriteLine("brand name =" +c.Brand);*/


            /*  Employee e = new Employee();
              e.Id = 101;
              e.Name = "test";
              e.salary = 1000;
              Console.WriteLine("id=" +e.Id);
              Console.WriteLine("name=" + e.Name);
              Console.WriteLine("salary=" +e.salary);*/

            /*   Book b = new Book();
               b.title = "xxx";
               b.Author = "jjj";
               b.price = 1000;
               Console.WriteLine("title=" + b.title);
               Console.WriteLine("author=" +b.Author);
               Console.WriteLine("price=" + b.price);*/

            /* Student s = new Student();
               s.Name = "test";
               s.Marks = 1;
               Console.WriteLine("name =" + s.Name);
               Console.WriteLine("maarks=" + s.Marks);*/

            /*  rectangle r = new rectangle();
              r.length = 10;
               r.breadth= 10;
               Console.WriteLine("area =" + r.Area);*/

            /* circle c = new circle();
             c.radius = 5;
             Console.WriteLine("area" + c.Area);*/

            /* product p = new product();
             p.price = 100;
             p.quantity = 10;
             p.productname = "test";
             Console.WriteLine("total is =" + p.totalprice);*/

            bankaccount ac = new bankaccount();
            ac.accountnumber = 2;
            ac.accountholder = "xya";
            ac.balance = 1234;
            Console.WriteLine("Account number =" + ac.accountnumber);
            Console.WriteLine("accountholder =" + ac.accountholder);
            Console.WriteLine("balance =" + ac.balance);







    }
}
}
