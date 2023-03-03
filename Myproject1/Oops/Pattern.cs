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
        public double height = (int)6;
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
        public string perimeter;

        public void Show()
        {
            Console.WriteLine(perimeter);
        }
    }




    class Hieraechical
    {
        static void Main(string[] args)
        {

        }
    }
}
