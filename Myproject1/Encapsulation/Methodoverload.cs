using Myproject1.Oops;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Encapsulation
{
    internal class Methodoverload
    {
        public void CalculateArea()
        {
            Console.WriteLine("CalculateArea");
        }
        public void Area(int side)
        {
            Console.WriteLine("Square=" + side * side);
        }
        public void Area(float r)
        {
            Console.WriteLine("Circle="+3.14*r*r);
        }
        public void Area(int l,int b) 
        { 
            Console.WriteLine("Reactangle="+l*b);
        }
        public void Area(int b,float h)
        { 
            Console.WriteLine("Triangle="+b*h);
        }

        static void Main(string[] args)
        {
            Methodoverload m= new Methodoverload();
            m.Area(5);
            m.Area(5f);
            m.Area(2,6);
            m.Area(3,7f);
        }
    }


    class StaticOverload
    {
        static void Calculate()
        {
            Console.WriteLine("Calculate");
        }
        static void Calculate(int a,int b) 
        {
            Console.WriteLine("Addition="+(a+b));
        }
        static void Calculate(int b,float c)
        {
            Console.WriteLine("Substraction=" + (b - c));
        }
        static void Calculate(float a,int b)
        {
            Console.WriteLine("Multiplication=" + (a * b));
        }

        static void DisplayCalculation()
        {
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            StaticOverload StaticOverload= new StaticOverload();
            StaticOverload.Calculate(5,6);
            StaticOverload.Calculate(7,8f);
            StaticOverload.Calculate(4f,6);
            StaticOverload.DisplayCalculation();
            
        }
        

        



    }
}
