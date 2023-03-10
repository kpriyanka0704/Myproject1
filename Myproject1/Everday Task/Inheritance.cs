using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Everday_Task
{
    internal class Inheritance
    {
        class Vehicle
        {

            public string wheel = "6";
        }
        class Bike : Vehicle
        {
            public string name = "Unicorn";
            public string colour = "Red";
            public int price = 50000;
            public void Show()
            {
                Console.WriteLine("name=" + name);
                Console.WriteLine("colour=" + colour);
                Console.WriteLine("price=" + price);
            }
        }



        internal class Inheritancce
        {
            static void Main(string[] args)
            {
                Bike b = new Bike();
                b.Show();
            }
        }



        class Organization//multilevel inheritance
        {
            public int rankno = 01;

        }
        class Manager : Organization
        {
            public string name = "Amit";
            public int age = 35;
        }
        class Employee : Manager
        {
            protected int id = 101;
            public float salary = 40000;

            public void Show()
            {
                Console.WriteLine(rankno + " " + name + " " + age + " " + id + " " + salary);
            }
        }

        class Multilevel
        {
            static void Main(string[] args)
            {
                Employee emp = new Employee();
                emp.Show();
            }
        }

    }

    class Reactangle//Hieraechical inheritance
    {
        public int length = 4;
        public double width = 5;
        public double height = 6;
    }
    class Area : Reactangle
    {
        public int area = (4 * 5);

        public void Show()
        {
            Console.WriteLine("Area= " + area);
        }
    }
    class Perimeter : Reactangle
    {
        public int perimeter = 2 * 4 + 2 * 6;

        public void Show()
        {
            Console.WriteLine("Perimeter= " + perimeter);
        }

        class Hieraechical1
        {
            static void Main(string[] args)
            {
                Perimeter p = new Perimeter();
                p.Show();
                Area a = new Area();
                a.Show();
            }
        }
    }

    //Tuesday(07/03/2023)
    internal class Pattern //
    {
        int rows;
        char ch = 'A';

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                char ch = 'A';
                if (i % 2 != 0)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                }
                else
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(ch);
                        ch++;
                    }
                }
                Console.WriteLine();
            }


        }

    }

    class Pttern3//Pyramid pattern
    {
        static void Main(string[] args)
        {
            int num, space;
            Console.WriteLine("Enter the number of rows");
            num = Convert.ToInt32(Console.ReadLine());
            space = num - 1;
            for (int i = 1; i <= num; i++)
            {
                for (space = 1; space <= (num - i); space++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for (int k = (i - 1); k >= 1; k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
        }
    }

    class Forloop//sum of firt 5 natural numbers
    {
        static void Main(string[] args)
        {
            int n = 5, sum = 0;
            for(int i=1;i<=n;i++)
            {
                sum=sum+i;
            }
            Console.WriteLine(sum);
        }
    }

    class Forloop2 
    {
        static void Main(string[] args)
        {
            for(int i=0;i<=10;i=i+2)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Nestedloop
    {
        static void Main(string[] args) 
        {
            for(int i=1;i<=2;i++)
            {
                Console.WriteLine(i);
            }
            for(int j=1;j<=3;j++)
            {
                Console.WriteLine(j);
            }
        }
    }

    class Continuestatement
    {
        static void Main(string[] args) 
        {
            
            for(int i=0;i<=10;i++)
            {
                if (i==5)
                {
                    break;
                }
                Console.WriteLine(i+"\n");
                
            }
            for(int i= 0;i<=10;i++)
            { if (i==5)
                { 
                    continue;
                }
                Console.WriteLine(i+"\n");
            }
           
        }
    }
}
