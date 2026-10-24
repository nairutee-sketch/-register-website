using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace practice_problems_2
{
    internal class Program
    {
        /*  Create a Student class with properties for student ID, name, and marks. Add methods to accept student details, calculate the grade, and display the complete student information. */
        /*  class student
          {
              public int studentid { get; set; }
              public string name { get; set; }
              public double marks { get; set; }
    public void display()
              {
                  Console.WriteLine("enter student id ");
                  studentid = Convert.ToInt32(Console.ReadLine());

                  Console.WriteLine("enter student name");
                  name = Console.ReadLine();

                  Console.WriteLine("enter student marks");
                  marks = Convert.ToDouble (Console.ReadLine());

              }
              public string calculategrade()
              {
                  if (marks >= 90)
                  {
                      return "A";
                  }
                  else if (marks >=75 )
                      {
                      return "B";
                  }
                  else if (marks >= 60)
                  {
                      return "c";
                  }
                  else if (marks >= 35)
                  {
                      return "D";
                  }
                  else
                  {
                      return "fail";
                  }

              }
   public void displaydetails()
              {
                  Console.WriteLine("student id " +  studentid);
                  Console.WriteLine("student name" +  name);
                  Console.WriteLine("marks" +  marks);
                  Console.WriteLine("grade" +  calculategrade());
              }
          }*/

        /* Create a BankAccount class with account number, account holder name, and balance. Implement methods for depositing money, withdrawing money, and displaying the current balance. Prevent withdrawals that exceed the available balance.*/


        /*   class bankaccount
           {
               public int Accountnumber { get; set; }
               public string Name { get; set; }
               public double Balance { get; set; }

               public bankaccount(int accountnumber, string name, double balance)
               {
                   Accountnumber = accountnumber;
                   Name = name;
                   Balance = balance;


               }
               public void deposit(double amount)
               {
                   if (amount > 0)
                   {
                       Balance = Balance + amount;
                       Console.WriteLine("amount deposit successfull");
                   }
                   else
                   {
                       Console.WriteLine("Invalid deposit amount");
                   }
               }
               public void withdraw(double amount)
               {
                   if (amount <= 0)
                   {
                       Console.WriteLine("invalid withdrawal amount");
                   }
                   else if (amount > Balance)
                   {
                       Console.WriteLine("Insufficient balance");
                   }
                   else
                   {
                       Balance = Balance - amount;
                       Console.WriteLine("Amount withdrawn successfully");
                   }
               }
               public void Dispalybalance()
               {
                   Console.WriteLine("Account number=" + Accountnumber);
                   Console.WriteLine("Account holder=" + Name);
                   Console.WriteLine("current balance=" + Balance);
               }
           }*/
        /* Create a Rectangle class with length and width as properties. Implement separate methods to calculate area, perimeter, and diagonal length. Accept the dimensions from the user. */
        /*   class rectangle
           {
               public double length { get; set; }
               public double width { get; set; }

               public double area()
               {
                   return length * width;
               }
               public double perimeter () 
                   {
                   return  2* ( length + width);
                   }
               public double diagonallength()
               {
                   return Math.Sqrt((length * length) + (width * width));
               }
           }*/

        /*   Create an Employee class containing employee ID, name, basic salary, and bonus.Implement methods to calculate the total salary and display the employee's payroll details.*/
        /*  class employee
             {
                 public double id {  get; set; }
                 public string name { get; set; }
                 public double salary { get; set; }
                 public double bonus { get; set; }

                 public double totalsalary()
                 {
                     return  salary + bonus;
                 }

                 public void display()
                 {
                     Console.WriteLine("id =" + id);
                     Console.WriteLine("name =" +  name);
                     Console.WriteLine("basic salary=" + salary);
                     Console.WriteLine("bonus=" + bonus);
                     Console.WriteLine("total salary=" +totalsalary());
                 }

             }*/

        /*  Create a Product class with product ID, product name, price, and quantity. Implement methods to calculate the total inventory value, update stock quantity, and display product details. */
        class product
        {
            public int id {  get; set; }
            public string name { get; set; }
            public double price { get; set; }
            public int quantity { get; set; }

            public double calculate()
            {
                return price * quantity;
            }
            public void updatestock(int newquantity)
            {
                quantity = newquantity;
                Console.WriteLine("stock quantity updated successfully");
            }
            public void DisplayDetails()
            {
                Console.WriteLine("\n--- Product Details ---");
                Console.WriteLine("Product ID: " + id);
                Console.WriteLine("Product Name: " + name);
                Console.WriteLine("Price: " + price);
                Console.WriteLine("Quantity: " + quantity);
                Console.WriteLine("Total Inventory Value: " + calculate());
            }
        }


               static void Main(string[] args)
                                {
            /* student s = new student();
             s.display();
             s.displaydetails();*/

            /*  bankaccount ac = new bankaccount(101, "developer", 5000);
              ac.Dispalybalance();
              ac.withdraw(1100);
              ac.deposit (2100);
              ac.Dispalybalance();*/


            /*  rectangle r = new rectangle();
              Console.WriteLine("enter length");
              r.length = Convert .ToDouble (Console.ReadLine());
              Console.WriteLine("enter width");
              r.width = Convert .ToDouble (Console.ReadLine());
              Console.WriteLine("area =" + r.area());
              Console.WriteLine("perimeter = " + r.perimeter());
              Console.WriteLine("diagonal=" + r.diagonallength()); */

            /*   employee e = new employee();

               Console.Write("Enter Employee ID: ");
               e.id = Convert.ToDouble(Console.ReadLine());
               Console.Write("Enter Employee Name: ");
               e.name = Console.ReadLine();
               Console.Write("Enter Basic Salary: ");
               e.salary = Convert.ToDouble(Console.ReadLine());
               Console.Write("Enter Bonus: ");
               e.bonus = Convert.ToDouble(Console.ReadLine());
               e.display();*/

            product p = new product();

            Console.Write("Enter Product ID: ");
            p.id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Product Name: ");
            p.name = Console.ReadLine();

            Console.Write("Enter Price: ");
            p.price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Quantity: ");
            p.quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter new stock quantity: ");
            int newQuantity = Convert.ToInt32(Console.ReadLine());

            p.updatestock(newQuantity);
            p.DisplayDetails();





        }
}
}
