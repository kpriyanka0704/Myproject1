using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.AbstactDemo
{
    abstract class Vehicle
    {
        public abstract void WheelType();

        public Vehicle (string colour)
        {
            Console.WriteLine("vehicle"+colour);
        }
        public void Show()
        {
            Console.WriteLine("Vehicle");

        }
    }
    class Car : Vehicle
    {
        public Car():base("Black")
        {

        }
        public override void WheelType()
        {
            Console.WriteLine("Four wheels");
        }
    }
    class Truck:Vehicle
    {
        public Truck():base("Red")
        {

        }
        
            public override void WheelType()
        {
            Console.WriteLine("Six wheels");
        }
    }
    internal class AbstractDemo
    {
        static void Main(string[] args)
        {
            Vehicle v = new Car();
            v.WheelType();
            Vehicle v1= new Truck();
            v1.WheelType();
        }
    }
}
