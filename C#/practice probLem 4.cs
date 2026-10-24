using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;

namespace practice_problem_4
{
    internal class Program
    {

        /* Create an interface IPayment with a method named Pay(). Implement it in CreditCardPayment, UPIPayment, and CashPayment classes. Accept a payment amount and display the payment details for the selected payment method. */

        /*    interface Ipayment
            {
                void pay();

            }
            class creditcard : Ipayment
            {
                public void pay()
                {
                    Console.WriteLine("credit card payment");
                }
            }
            class Upi: Ipayment
            {
                public void pay()
                {
                    Console.WriteLine("UPI payment");
                }
            }
            class cashpayment: Ipayment
            {
                public void pay()
                {
                    Console.WriteLine("cashpayment");
                }
            }*/

        /* Create an interface INotification with a method named SendNotification(). Implement it in EmailNotification, SMSNotification, and PushNotification classes. Accept a message from the user and demonstrate each notification type.*/

        /*   interface Inotification
           {
               void sendnotification();
           }
           class email : Inotification
           {
               public void sendnotification() {
                   Console.WriteLine(" email notification sent");
               }

           }
           class sms : Inotification
           {
               public void sendnotification()
               {
                   Console.WriteLine(" sms notificaiton sent");
               }
           }
           class push : Inotification
           {
               public void sendnotification()
               {
                   Console.WriteLine("  push notification sent ");
               }
           }*/

        /*Create an interface IRentable with methods to calculate rental cost and display rental details. Implement it in CarRental and BikeRental classes. Accept rental duration and calculate the total cost for each vehicle type. */

        /*   interface Irentable
           {
               void calculaterentalcost();
               void displayrentaldetails();
           }
           class carrental : Irentable

           {
               public int days;
               public double cost;
               public void calculaterentalcost()
               {
                   cost = days * 2000;
               }
               public void displayrentaldetails()
               {
                   Console.WriteLine("car rental cost=" + cost);
               }
           }
           class bikerental : Irentable
           { 
               public int days;
               public double cost;
               public void calculaterentalcost() {
                   cost = days * 500;

               }
               public void displayrentaldetails()
               {
                   Console.WriteLine("bike rental cost=" + cost);
               }
           }*/

       


           static void Main(string[] args)
                                {
            /* Console.WriteLine("enter payment amount");
             double amount = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("1. credit card");
             Console.WriteLine("2.upi payment");
             Console.WriteLine("3. cashpayment");

             Console.WriteLine("enter choice");
             int choice = Convert.ToInt32(Console.ReadLine());



             if (choice == 1)
             {
                 creditcard c = new creditcard();
                 c.pay();
                 Console.WriteLine("amount =" + amount);
             }
             else if (choice == 2)
             {
                 Upi u = new Upi();
                 u.pay();
                 Console.WriteLine("amount =" + amount);
             }
             else if (choice == 3) 
             {
                 cashpayment cp = new cashpayment();
                 cp.pay();
                 Console.WriteLine("amount =" + amount);
             }
            else {
                 Console.WriteLine("invalid choice");

                 }*/

            /*   Console.WriteLine("write message");
               string message = Console.ReadLine();

               Console.WriteLine("message =" + message);

               email e = new email();
               e.sendnotification();

               sms s = new sms();
               s.sendnotification();

               push p = new push();
               p.sendnotification(); */

            /*  Console.WriteLine("enter rental days");
              int days = Convert.ToInt32(Console.ReadLine());

              carrental c = new carrental();
              c.days = days;
              c.calculaterentalcost();
              c.displayrentaldetails();

              bikerental b = new bikerental();
              b.days = days;
              b.calculaterentalcost();
              b.displayrentaldetails(); */

            /*  Accept a sentence from the user. Count the number of vowels, consonants, digits, spaces, and special characters. Display each count separately. */

            /*  Console.WriteLine("enter a sentence");
              string str = Console.ReadLine();

              int vowel = 0, consonants = 0, digit = 0;
              int space = 0, special = 0;

              foreach (char c in str)
              {
                  if (char.IsLetter(c))
                  {
                      if ("aeiouAEIOU".Contains(c))
                      {
                          vowel++;

                      }
                      else
                      {
                          consonants++;
                      }
                  }
                  else if (char.IsDigit(c))
                  {
                      digit++;
                  }
                  else if (c == ' ')
                  {
                      space++;

                  }
                  else
                  {
                      special++;
                  }
              }

              Console.WriteLine("vowels:" + vowel);
              Console.WriteLine("consonants:" +  consonants);
              Console.WriteLine("digits:" + digit);
              Console.WriteLine("spaces:" + space);
              Console.WriteLine("special character:" +  special);*/

            /* Accept a string from the user and check whether it is a palindrome. Ignore spaces, punctuation, and differences between uppercase and lowercase letters.*/

            /*   Console.WriteLine("enter a sentence");
               string str = Console.ReadLine();

               str = str.ToLower();
               string reverse = "";

               foreach (char ch in str)
               {
                   if (char.IsLetterOrDigit(ch))
                   {
                       reverse = ch + reverse;
                   }
               }

               string original = "";
               foreach (char ch in str)
               {
                   if (char.IsLetterOrDigit(ch))
                   {
                       original += ch; 
                   }
               }
               if (original == reverse)
               {
                   Console.WriteLine("palindrome");
               }
               else
               {
                   Console.WriteLine("not a palindrome");
               }*/

            /*  Accept n integer values into an array. Find and display the largest number, smallest number, sum, average, and the second-largest distinct number.*/
            /* Console.WriteLine("enter array size");

               int n = Convert.ToInt32(Console.ReadLine());
               int[] number = new int[n];
               int sum = 0;
               Console.WriteLine("enter number");
               for (int i = 0; i < n; i++) 
                   {
                       number[i] = Convert.ToInt32(Console.ReadLine());
                       sum += number[i];

                   }
                   Array.Sort (number);

                   int smallest = number[0];
                   int largest = number[n - 1];
                   int secondlargest = 0;
                   bool found = false;

               for (int i =n-2; i >= 0; i--)
                   {
                       if (number[i] < largest)
                       {
                           secondlargest = number[i];
                           found = true;
                           break;
                       }
                   }
               double average = (double) sum / n;
                   Console.WriteLine("largest:" + largest);
                   Console.WriteLine("smallest" + smallest);
                   Console.WriteLine("sum:" + sum);
                   Console.WriteLine("average:" + average);


                   if (found)
                   {
                       Console.WriteLine("second largest:" + secondlargest);
                   }
                   else
                   {
                       Console.WriteLine("no second largest distinct number");
                   }*/

            /* Accept the names and marks of 10 students and store them in suitable arrays. Display all students who scored above the class average and identify the student with the highest marks. */

            /* string[] name = new string[10];
             int[] marks = new int[10];
             int sum = 0;

             for (int i = 0; i < 10;i++)
             {
                 Console.WriteLine("enter student name");
                 name[i] = Console.ReadLine();

                 Console.WriteLine("enter student marks");
                 marks[i] = Convert.ToInt32(Console.ReadLine());
                 sum += marks[i];


             }
             double average = (double)sum / 10;
             int highest = marks[0];
             int index = 0;

             for (int i =0; i < 10; i++)
             {
                 if (marks[i] > highest)
                 {
                     highest = marks[i];
                     index = i;
                 }
             }
             Console.WriteLine("class average =" + average);
             Console.WriteLine("student scoring above average");
             for (int i = 0; i < 10; i++)
             {
                 if (marks[i] > average)
                 {
                     Console.WriteLine(name[i] + "-" + marks[i]);
                 }
             }
             Console.WriteLine("highest marks" + highest);
             Console.WriteLine("top student:" + name[index]);*/

            /* Store the IDs, names, and salaries of multiple employees using arrays. Accept an employee ID from the user, search for the employee, and display their details if found. Also display the average salary of all employees. */
            Console.Write("Enter number of employees: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] id = new int[n];
            string[] name = new string[n];
            double[] salary = new double[n];

            double sum = 0;

            // Accept employee details
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nEnter details of employee " + (i + 1));

                Console.Write("Enter ID: ");
                id[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Name: ");
                name[i] = Console.ReadLine();

                Console.Write("Enter Salary: ");
                salary[i] = Convert.ToDouble(Console.ReadLine());

                sum = sum + salary[i];
            }

            // Calculate average salary
            double average = sum / n;

            Console.WriteLine("\nAverage Salary = " + average);

            // Search employee by ID
            Console.Write("\nEnter employee ID to search: ");
            int searchId = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            for (int i = 0; i < n; i++)
            {
                if (id[i] == searchId)
                {
                    Console.WriteLine("\nEmployee Found!");
                    Console.WriteLine("ID: " + id[i]);
                    Console.WriteLine("Name: " + name[i]);
                    Console.WriteLine("Salary: " + salary[i]);

                    found = true;
                    break;
                }
            }

            if (found == false)
            {
                Console.WriteLine("Employee not found.");
            }
        
    }
}
}
