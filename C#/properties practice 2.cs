using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Properties_practice_2
{
    internal class Program
    {
        /* Create a BankAccount class with AccountNumber, AccountHolder, and Balance properties.Display the account details.*/
        /*  class bankaccount
           {
               public int accountnumber {  get; set; }
               public string accountholder { get; set; }
               public int balance { get; set; }
           }*/

        /*Create a Person class with FirstName and LastName properties. Create a read-only FullName property that returns the complete name.*/
        /*  class person
          {
              public string firstname {  get; set; }
              public string lastname { get; set; }

              public string fullname
              {
                  get
                  {
                      return firstname + lastname;
                  }
              }
          }*/

        /*Create a Rectangle class with Length and Breadth properties and a read-only Area property.*/
        /* class rectangle
         {
             public int length {  get; set; }
             public int breadth { get; set; }

             public int area
             {
                 get
                 {
                     return length * breadth;
                 }
             }
         }*/
        /* Create an Employee class with BasicSalary and Bonus properties. Create a read-only TotalSalary property.*/
        /*  class employee
          {
              public int basicsalary { get; set; }
              public int bonus { get; set; }

              public int totalsalary
              {
                  get
                  {
                      return basicsalary + bonus;
                  }
              }
          }*/

        /*Create a Student class with an Age property. Allow the age to be set only if it is between 5 and 100.*/

        /* class student
         {
             private int age;

                 public int Age
             {
                 get
                 {
                     return age;
                 }
                 set
                 {
                     if (value >=5 && value <= 100)
                     {
                         age = value;
                     }
                     else
                     {
                         Console.WriteLine("age between 5 and 100");
                     }
                 }
             }
             }*/

        /*Create an Employee class with a Salary property. Allow the salary to be set only if it is greater than 0.*/
        /*    class employee
            {
                private int salary;

                public int Salary
                {
                    get
                    {
                        return salary;
                    }
                    set
                    {
                        if (value > 0)
                        {
                            salary = value;
                        }
                        else
                        {
                            Console.WriteLine("salary must be greater than 0");
                        }

                    }

                }
            } */

        /*Create a Product class with a Price property. If the price is negative, display "Invalid Price".*/

        /*  class product
          {
              private int price;
              public int Price
              {
                  get
                  {
                      return price;
                  }
                  set
                  {
                      if (value < 0)
                      {
                          Console.Write("invalid price");
                      }

                      else
                      {
                          price = value;
                      }
                  }
              }

          }*/

        /*Create a Student class with a Marks property. Allow marks only between 0 and 100.*/

        /*  class student
          {
              private int marks;
              public int Marks
              {
                  get
                  {
                      return marks;
                  }
                  set
                  {
                      if (value >= 0 && value <= 100)
                      {
                          marks = value;
                      }



                      else
                      {
                          Console.WriteLine("not allowed");
                      }
                  }
              }
          }*/

        /* Create a BankAccount class with a Balance property. Create Deposit() and Withdraw() methods and prevent withdrawal if the amount is greater than the balance.*/

        /*   class bankaccount
           {
               public double balance {  get; set; }


               public void deposit( double amount)
               {
                  balance = balance + amount;
                   Console.WriteLine("balance =" + balance);
                   Console.WriteLine("deposit=" +  amount);
               }
               public void withdraw( double amount)
               {
                   if (amount > balance)
                   {
                       Console.WriteLine("insufficient balance");
                   }
                   else
                   {
                       balance = balance - amount;
                       Console.WriteLine("balance=" + balance);
                       Console.WriteLine("withdraw=" + amount);
                   }
                   }

           }*/

        /*Create a Mobile class with properties:Brand,Model,Price,Storage. Display all mobile details using properties.*/
        /*  class Mobile
          {
              public string Brand {  get; set; }
              public string Model { get; set; }
              public double Price { get; set; }
              public int Storage {  get; set; }
          }*/

     /*   Create an Employee class with : Name,BasicSalary, HRA, DA, Read-only GrossSalary. Calculate GrossSalary = BasicSalary + HRA + DA*/

        class employee
        {
            public string name {  get; set; }
            public double basicsalary { get; set; }
            public double hra {  get; set; }
            public double da {  get; set; }

            public double grosssalary
            {
                get
                {
                    return basicsalary + hra+ da;

                }
            }
        }


                 static void Main(string[] args)
                 {
                    /* bankaccount b1 = new bankaccount();
                     b1.accountnumber = 145;
                     b1.balance = 100;
                     b1.accountholder = "rtg";
                     Console.WriteLine("account number=" + b1.accountnumber);
                     Console.WriteLine("account holder=" + b1.accountholder);
                     Console.WriteLine("balance = " + b1.balance);*/

        /*  person p = new person();
          p.firstname = "software";
          p.lastname = "developer";
          Console.WriteLine(p.fullname);*/

        /*  rectangle r = new rectangle();
          r.breadth = 23;
          r.length = 23;
           Console.WriteLine( "area =" +r.area);*/

        /*  employee e = new employee();
          e.basicsalary = 2000;
          e.bonus = 3000;
          Console.WriteLine("total salary=" + e.totalsalary);*/

        /*  student s =new student();
              s.Age = 10;
              Console.WriteLine( "student age = " +s.Age);*/

        /*  employee e = new employee();
              e.Salary = 10000;
              Console.WriteLine("salary = " + e.Salary);*/

        /*  product p = new product();
          p.Price = 3000;
          Console.WriteLine("price =" +  p.Price);*/

        /*  student s = new student();
          s.Marks = 34;
          Console.WriteLine("marks= " +  s.Marks);*/



        /*bankaccount ba = new bankaccount();
        ba.deposit(1000);
        ba.withdraw(930);
        ba.balance = 500;*/

           /* Mobile  M = new Mobile();
            M.Brand = "BMW";
            M.Model = "XXY";
            M.Price = 100000;
            M.Storage = 12;
            Console.WriteLine("brand = " +  M.Brand);
            Console.WriteLine( "model = " + M.Model);
            Console.WriteLine("price =" + M.Price);
            Console.WriteLine("storage =" + M.Storage);*/

            employee e = new employee();

            e.hra = 39800;
            e.name = "test";
            e.basicsalary = 3000;
            e.da = 4000;
            Console.WriteLine("hra =" + e.hra);
            Console.WriteLine("name =" + e.name);
            Console.WriteLine("basic salary=" + e.basicsalary);
            Console.WriteLine("da=" + e.da);
    }
}
}
