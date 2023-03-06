using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Oops
{
    internal class Basekeyword
    {
        class Vehicle
        {
            public int wheels;
        }

        class Fourwheeler : Vehicle
        {
            internal int wheels = 4;
            public void ShowFourwheeler()
            {
                Console.WriteLine(wheels + " " + base.wheels);
            }
        }
        class Car : Vehicle
        {
            string name="ford";

            public void ShowCar()
            {
                Console.WriteLine(name+ " " +base.name);
            }
        }




        class Basekeywords
        {
            static void Main(string[] args)
            {
                Fourwheeler f = new Fourwheeler();
                f.ShowFourwheeler();
                Car c = new Car();
                c.ShowCar();
            }
        }
    }
}
