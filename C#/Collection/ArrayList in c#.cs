using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace ArrayList_in_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Accept 5 numbers and display all numbers.*/

/* ArrayList numbers = new ArrayList();
 Console.WriteLine("enter 5 numbers");

 for (int i=0; i<5; i++)
 {
     int num = Convert.ToInt32(Console.ReadLine());
     numbers.Add(num);

 }
 Console.WriteLine("All numbers are");
 foreach (object i in numbers)
 {
     Console.WriteLine(i);    
 }*/
/* Accept 5 numbers and calculate their sum and average.*/

/*  ArrayList number = new ArrayList();
  int sum = 0;
  Console.WriteLine("enter 5 number");
  for (int i = 0; i < 5; i++)
  {
      int num = Convert.ToInt32(Console.ReadLine());
      number.Add(num);
       sum = sum + num;
  }

  int avg = sum / 5;
  Console.WriteLine("sum =" + sum);
  Console.WriteLine("average=" + avg);*/

/* Accept 5 numbers and display them in ascending order.*/

/*   ArrayList num = new ArrayList();
   Console.WriteLine("enter 5 number");
   for (int i = 0; i < 5; i++)
   {
       int nums = Convert.ToInt32(Console.ReadLine());
       num.Add(nums);


   }
   num.Sort();

   Console.WriteLine("ascending order");

   foreach(object no in num)
   {
       Console.WriteLine(no);
   }*/

/*Search for a number in an ArrayList.*/

/*   ArrayList number = new ArrayList();
   Console.WriteLine("enter 5 number");
   for (int i = 0; i < 5; i++)
   {
       int num = Convert.ToInt32(Console.ReadLine());
       number.Add(num);
   }
   Console.WriteLine("enter number to search");
   int search = Convert.ToInt32(Console.ReadLine());

   if (number.Contains(search))
   {
       Console.WriteLine("number found");
   }
   else
   {
       Console.WriteLine("number not found");
   }*/

/*Count how many times a number appears.*/
/*ArrayList number = new ArrayList();
            Console.WriteLine("enter 5 number");
            for (int i = 0; i < 5; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                number.Add(num);
            }
            Console.WriteLine("enter number to count");
            int search = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            foreach (object num in number) {
                if ((int)(num) == search)
                {
                    count++;
                }
                
               }
            Console.WriteLine(search + "appears" + count + "times");*/

/* Remove a specific number from an ArrayList.*/

/*   ArrayList number = new ArrayList();
   Console.WriteLine("enter 5 number");
   for (int i = 0; i < 5; i++)
   {
       int num = Convert.ToInt32(Console.ReadLine());
       number.Add(num);
   }
   Console.WriteLine("enter number to remove");
   int remove = Convert.ToInt32(Console.ReadLine());

   if (number.Contains(remove))
   {
       number.Remove(remove);
       Console.WriteLine("number remove successfully");
   }
   else
   {
       Console.WriteLine("number not found");
   }
   Console.WriteLine("updated Arraylist");
   foreach (object num in number)
   {
       Console.WriteLine(num);
   }*/
/* Store student names and display them.*/
/*ArrayList name = new ArrayList();
            Console.WriteLine("enter 5 names");
            for (int i = 0; i < 5; i++)
            {
                string n = Console.ReadLine();
                name.Add(n);
            }
            Console.WriteLine("student name");
            foreach(object names in name)
            {
                Console.WriteLine(names);
            }*/

/* Insert a number at a specified index.*/
/*ArrayList number = new ArrayList();
            Console.WriteLine("enter 5 number");
            for(int i = 0; i < 5; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                number.Add(num);
            }
            Console.WriteLine("Enter number to insert");
            int numbers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter index");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index >= 0 && index <= number.Count)
            {
                number.Insert(index, numbers);

                Console.WriteLine("updated arraylist");
                foreach (object n in number)
                {
                    Console.WriteLine(n);
                }
            }
            else
            {
                Console.WriteLine("invalid index");
            }*/

/* Find the largest and smallest numbers.*/
/*ArrayList number = new ArrayList();
            Console.WriteLine("enter 5 number");
            for (int i = 0; i < 5; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                number.Add(num);
            }
           
            int largest = number.Cast<int>().Max();
            int smallest = number.Cast<int>().Min();
            Console.WriteLine("largest number =" + largest);
            Console.WriteLine("smallest number=" +smallest);*/

/*Remove duplicate numbers from an ArrayList.*/

            ArrayList number = new ArrayList();
            Console.WriteLine("enter 5 number");
            int num = Convert.ToInt32(Console.ReadLine());
            number.Add(num);

            ArrayList unique = new ArrayList();
            foreach (object n in number)
            {
                if (!unique.Contains(n))
                {
                    unique.Add(n);
                }

            }
            Console.WriteLine("Numbers after removing duplicates");

            foreach (object n in unique)
            {
                Console.WriteLine(n);
            }



}
}
}
