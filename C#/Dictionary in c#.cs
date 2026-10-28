using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dictionary_in_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Dictionary<int, string> students = new Dictionary<int, string>();
             students.Add(1, "rahul");
             students.Add(2, "priya");
             Console.WriteLine(students[1]);*/

            /* Add and display student details*/

            /* Dictionary<int,string> stud = new Dictionary<int,string>();
             stud.Add(1, "raj");
             stud.Add(2, "fancy");
             stud.Add(3, "asvc");

             foreach (var student in stud)
             {
                 Console.WriteLine(student.Key +":"+student.Value);
             }*/

            /* 2. Accept a student ID from the user and display the student's name if found. */

            /* Dictionary <int,string> st = new Dictionary<int,string>();
             st.Add(1, "asd");
             st.Add(2, "poi");
             st.Add(3, "sneha");
             st.Add(4, "rti");
             st.Add(5, "qwe");

             Console.WriteLine("enter student id");
             int id = Convert.ToInt32(Console.ReadLine());

             if (st.ContainsKey(id))
             {
                 Console.WriteLine("student name :" + st[id]);
             }
             else
             {
                 Console.WriteLine("student not found");
             }*/

            /*Store employee IDs and names. Check whether an entered employee ID exists using ContainsKey().*/

            /*  Dictionary<int,string> employee = new Dictionary<int,string>();
              employee.Add(1, "rahul");
              employee.Add(2, "priya");
              employee.Add(3, "tina");
              Console.WriteLine("enter emplyoee id");
              int id = Convert.ToInt32(Console.ReadLine());

              if (employee.ContainsKey(id))
              {
                  Console.WriteLine(" employee id exists");
                  Console.WriteLine("employee name " : +employee[id]);
              }
              else
              {
                  Console.WriteLine("employee dosen't exists");
              }*/

            /* Store product IDs and names.Accept a product ID and update its name.*/
            /*  Dictionary<int,string> dic = new Dictionary<int,string>();
               dic.Add(1, "bmw");
               dic.Add(2, "honda");
               dic.Add(3, "swift");

               Console.WriteLine("enter product id");
               int id = Convert.ToInt32(Console.ReadLine());

               if (dic.ContainsKey(id)) {
                   Console.WriteLine("enter new product name");
                   string name = Console.ReadLine();

                   dic[id] = name;
                   Console.WriteLine("product name updated");
                   Console.WriteLine("updated product:" +dic[id]);
               }
               else
               {
                   Console.WriteLine("product not found");
               }*/

            /*Store 5 country codes and country names. Accept a code and remove that item*/
            /*   Dictionary<int, string> country = new Dictionary<int, string>();
               country.Add(1, "india");
               country.Add(2, "usa");
               country.Add(3, "new zealand");
               country.Add(4, "london");
               country.Add(5, "africa");

               Console.WriteLine("enter code");
               int code = Convert.ToInt32(Console.ReadLine());

               if (country.ContainsKey(code))
               {
                   country.Remove(code);
                   Console.WriteLine("code remove successfully");
               }
               else
               {
                   Console.WriteLine("country not found");
               }
               foreach (var count in country)
               {
                  Console.WriteLine(count.Key + ": " + count.Value);
               }*/

            /*Dictionary<int,string> codes = new Dictionary<int,string>();
                codes.Add(1, "mumbai");
                codes.Add(2, "chennai");
                codes.Add(3, "hydrabad");

                Console.WriteLine("city name and pincodes");
                foreach (var code in codes)
                {
                    Console.WriteLine(code.Key  + ": " + code.Value);
                }
                Console.WriteLine("total number of cities:=" + codes.Count);*/

            /*Store employee IDs and names. Display only the employee IDs using Keys.*/
            /*    Dictionary<int, string> id = new Dictionary<int, string>();
                id.Add(1, "arjun");
                id.Add(2, "ram");
                id.Add(3, "fatima");

                foreach(var item in id)

                {
                    Console.WriteLine("employee id are:");
                    Console.WriteLine(item.Key);
                }*/

            /*Store student IDs and names. Display only the student names using Values.*/
            /*  Dictionary<int, string> names = new Dictionary<int, string>();
              names.Add(1, "arjun");
              names.Add(2, "ram");
              names.Add(3, "fatima");

              foreach (var name in names) {
                  Console.WriteLine("student names is");
                  Console.WriteLine(name.Value);
              }*/

            /*Accept a sentence and count how many times each word occurs using a Dictionary*/

            /*   Dictionary<string, int> words = new Dictionary<string, int>();
               Console.WriteLine("enter a sentence");
               string sentence = Console.ReadLine();

               string[] arr = sentence.Split(' ');
               foreach(string word in arr)
               {
                   if (words.ContainsKey(word))
                   {
                       words[word]++;

                   }
                   else
                   {
                       words.Add(word, 1);
                   }
               }
               foreach (var item in words)
               {
                   Console.WriteLine(item.Key + " " + item.Value);
               }*/

            /*Store product names and prices. Display each product and calculate the total price.*/


            Dictionary<int, string> product = new Dictionary<int, string>();
            product.Add(12, "lashes");
            product.Add(14, "lipstick");
            product.Add(17, "eyelinear");
            int total = 0;
            foreach (var item in product) {
                Console.WriteLine(item.Key + "" + item.Value);
                total = total + item.Key;
            }
            Console.WriteLine("total price=" + total);
           

}
}
}
