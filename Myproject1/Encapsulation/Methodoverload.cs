using Myproject1.Oops;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Quic;
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
        static void Calculate(int a, int b)
        {
            Console.WriteLine("Addition=" + (a + b));
        }
        static void Calculate(int b, float c)
        {
            Console.WriteLine("Substraction=" + (b - c));
        }
        static void Calculate(float a, int b)
        {
            Console.WriteLine("Multiplication=" + (a * b));
        }

        static void DisplayCalculation()
        {
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            StaticOverload StaticOverload = new StaticOverload();
            StaticOverload.Calculate(5, 6);
            StaticOverload.Calculate(7, 8f);
            StaticOverload.Calculate(4f, 6);
            StaticOverload.DisplayCalculation();

        }
    }   

        
    class ConstructorOverload

    {
        string name;
        int qty;
        int price;
        public  ConstructorOverload (string name, int qty, int price)
        {
            this.name = name;
            this.qty = qty;
            this.price = price;
        }
        
        public string Name
        {
            set
            { 
                this.name = value;
            }
            get 
            { 
                return this.name;
            }
        }
        public int Qty
        {
            set 
            {
                this.qty = value;
            }
            get
            {
                return this.qty;
            }
        }
        public int Price
        {
            set
            { 
                this.price = value; 
            }
            get
            {
                return this.price;
            }
        }
        static void Main(string[] args)
        {
            ConstructorOverload c = new ConstructorOverload("apple", 10,100);
            c.name= "Orange";
            c.qty = 15;
            c.price = 150;

            Console.WriteLine("Name= "+c.name);
            Console.WriteLine("Qty= "+c.qty);
            Console.WriteLine("Price= " + c.price);

        }
    }
 
    


    
}
