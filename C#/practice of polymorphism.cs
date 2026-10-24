using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        /*Method Overloading – Add Two Numbers*/
        /* class calculator
         {
             public int add(int a,int b)
             {
                 return a + b;
             }

             public int add(int a,int b,int c)
             {
                 return a + b + c;
             }
         }*/

        /* class animal
         {
             public virtual void sound()
             {
                 Console.WriteLine("animal makes a sound");
             }

         }
         class dog : animal
         {
             public override void sound()
             {
                 Console.WriteLine("dog barks");
             }
         }*/
        /*  Method Overloading – Different Data Types*/

        /*  class calc
          {
              public void Add(int a, int b)
                  {
                  Console.WriteLine(a + b);
                  }
          public void Add(float x, float y)
              {
              Console.WriteLine(x + y);
              }

               }*/
        /*Create an Area() method that calculates: Area of a square,Area of a rectangle,Area of a circle */
        /*  class formula
          {
              public void Area(int s)
              {
                Console.WriteLine("area of square=" + s * s);
              }

              public void Area(int l, int b)
              {
                  Console.WriteLine("area of rectangle=" +l * b);
              }

              public void Area (float r)
              {
                  Console.WriteLine ("area of circle=" +3.14f * r * r);
              }
          }*/
        /*Create a Display() method that accepts: int, string, float Display each value.*/
        /*  class displays
          {
              public void display(int a)
              {
                  Console.WriteLine("integer" + a);
              }
              public void display(float a)
              {
                  Console.WriteLine("float" + a);

              }
              public void display(string a)
              {
                  Console.WriteLine("string" + a);
              }
          }*/

        /* Create a Multiply() method that accepts: 2 integers ,3 integers ,2 double values*/

        /*  class multiply
          {
              public void Multiply(int a, int b)
              {
                  Console.WriteLine("two integers =" + a* b);
              }
              public void Multiply(int a, int b, int c)
              {
                  Console.WriteLine("3 integers =" + a* b*c);
              }
              public void Multiply(double a, double b)
              {
                  Console.WriteLine("2 double =" + a* b);
              }
          }*/

        /* Create a Calculate() method to calculate: Simple interest using int,Simple interest using float,Simple interest using double*/
        /*class calculate
                {
                    public void Calculate( int p ,int r,int t)
                    {
                        int si = p * r * t / 100;
                        Console.WriteLine("simple interest =" + si);

                    }

                    public void Calculate(float p,float r,float t)
                    {
                        float si = p * r * t / 100;
                        Console.WriteLine("simple interest=" + si);

                    }
                    public void Calculate(double p,double r,double t)
                    {
                        double si = p * r * t / 100;
                        Console.WriteLine("simple interest=" + si);
                    }
                }*/

        /*  Create a Print() method that accepts:Student name,Student name and age.Student name, age, and marks*/

        /* class print
         {
             public void Print(string name)
             {
                 Console.WriteLine("student name =" + name);
             }
             public void Print(string name , int age)
             {
                 Console.WriteLine("student name =" + name);
                 Console.WriteLine("age=" + age);
             }

             public void Print (string name , int age , int marks)
             {
                 Console.WriteLine("student name =" + name);
                 Console.WriteLine("age=" + age);
                 Console.WriteLine("marks" + marks);

             }
         }*/

        /*  Create a Volume() method to calculate: Volume of a cube,Volume of a cuboid,Volume of a cylinder*/

        /*  class volume
          {
              public void Volume (int s)
              {
                  int cube = s * s * s;
                  Console.WriteLine("volume of a cube =" + cube);
              }
              public void Volume(int l,int b,int h)
              {
                  int cuboid = l * b * h;
                  Console.WriteLine("volume of a cuboid=" + cuboid);
              }
              public void Volume(int r , int h)
              {
                  float cylinder = 3.14f * r * r * h;
                  Console.WriteLine("volume of a cylinder = " + cylinder);
              }
          }*/

        /* Create a CalculateSalary() method that accepts: Basic salary ,Basic salary and bonus,Basic salary, bonus, and allowance*/
        /*  class salary
           {
               public void CalculateSalary(int s)

               {
                   Console.WriteLine("basic salary" + s);
               }
               public void CalculateSalary(int s, int b)
               {
                   Console.WriteLine("basic salary" + s);
                   Console.WriteLine("bonus" + b);
               }
               public void CalculateSalary(int s, int b ,int a)
               {
                   Console.WriteLine("basic salary" + s);
                   Console.WriteLine("bonus" + b);
                   Console.WriteLine("allowance" + a);
               }
           }*/

/* Create a Calculate() method to calculate: Perimeter of a square,Perimeter of a rectangle,Circumference of a circle*/

      /*  class calculate
        {
            public void Calculate(int a)
            {
                int cal = 4 * a;
                Console.WriteLine("perimater of a square =" + cal);
            }
            public void Calculate(int l , int w)
            {
                int cal = 2*(l + w);
                Console.WriteLine("perimeter of rectangle=" + cal);
            }
            public void Calculate(float r)
            {
                float cal = 2 * 3.14f * r;
                Console.WriteLine("Circumference of a circle =" + cal);

            }
        }*/

          static void Main(string[] args)
          {
            /*Method Overloading – Add Two Numbers*/
            /* calculator c = new calculator();
            Console.WriteLine("add of two =" + c.add(46, 76));
           Console.WriteLine("add of three =" + c.add(23, 76, 98));
             Console.ReadLine();*/

            /* animal d = new dog();
             d.sound();
             Console.ReadLine();*/

            /*  calc c = new calc();
              c.Add(46, 76);
              c.Add(23.6f, 76.8f);
              Console.ReadLine();*/

            /* Create an Area() method that calculates: Area of a square, Area of a rectangle, Area of a circle */
            /* formula obj = new formula();
                 obj.Area(10);
                 obj.Area(20, 40);
                 obj.Area(25.0f);
                 Console.ReadLine(); */

            /* Create a Display() method that accepts:int,string.float.Display each value.*/
            /*displays d = new displays();
            d.display(10);
            d.display(11.2f);
            d.display("hello");
            Console.ReadLine();*/


            /* Create a Multiply() method that accepts: 2 integers ,3 integers ,2 double values*/
            /*  multiply m = new multiply();
              m.Multiply(10, 20);
              m.Multiply(10, 20, 90);
              m.Multiply(6.7, 9.0);
              Console.ReadLine();*/

            /* Create a Calculate() method to calculate:Simple interest using int, Simple interest using float, Simple interest using double*/

            /* calculate c = new calculate();
             c.Calculate(100, 20, 3);
             c.Calculate(20.1f, 70f, 2f);
             c.Calculate(23.4, 13.5, 6.7);
             Console.ReadLine();*/


            /*  Create a Print() method that accepts:Student name,Student name and age.Student name, age, and marks*/
            /*  print p = new print();
              p.Print("developer");
              p.Print("developer", 34);
              p.Print("developer", 34, 89);
              Console.ReadLine(); */

            /*  Create a Volume() method to calculate: Volume of a cube,Volume of a cuboid,Volume of a cylinder*/
            /*  volume v = new volume();
              v.Volume(3);
              v.Volume(23, 67, 11);
              v.Volume(32, 11);
              Console.ReadLine();*/

            /* Create a CalculateSalary() method that accepts:Basic salary,Basic salary and bonus,Basic salary, bonus, and allowance*/

            /* salary s = new salary();
             s.CalculateSalary(10000);
             s.CalculateSalary(10000, 5000);
             s.CalculateSalary(10000, 5000, 800);
             Console.ReadLine();*/


            /* Create a Calculate() method to calculate: Perimeter of a square, Perimeter of a rectangle,Circumference of a circle*/
           /* calculate  c = new calculate();
            c.Calculate(4);
            c.Calculate(6, 2);
            c.Calculate(10);
            Console.ReadLine();*/


        }
    }
}
