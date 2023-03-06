using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Oops
{
    internal class Pattern
    {
        int rows;
        char ch = 'A';
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows");
            int rows = int.Parse(Console.ReadLine());
            for(int i=1; i<=rows; i++) 
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
    class Reactangle
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
            Console.WriteLine("Perimeter= "+perimeter);
        }
    }




    class Hieraechical1
    {
        static void Main(string[] args)
        {
            Perimeter p=new Perimeter();
            p.Show();
            Area a= new Area();
            a.Show();
        }
    }



    class Pattern1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {

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
                        Console.Write("*");

                    }
                }
                Console.WriteLine();
            }
        }

    }

    class Pttern3
    {
        static void Main(string[] args)
        {
            int num, space;
            Console.WriteLine("Enter the number of rows");
            num = Convert.ToInt32(Console.ReadLine());
            space = num - 1;
            for(int i=1;i<=num;i++)
            {
                for(space=1;space<=(num-i);space++)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                for(int k=(i-1);k>=1;k--)
                {
                     Console.Write(k);
                }
                Console.WriteLine();
            }
        }
    }
    
}
