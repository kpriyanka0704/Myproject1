using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Keywords
{
    class Use1
    {
        int a;
        int b;
        public void Input(int ea, int eb)
        {
            this.a = ea;
            this.b = eb;
        }
        public void Display()
        {
            Console.WriteLine("a=" + a + "b=" + b);
        }

    }   


    class Use2
    {
        public void Read()
        {
            Console.WriteLine("I am priyanka");
        }
        public void Write() 
        {
            Console.WriteLine("Plz read book");
        }
    }

    class Use
    {
        public Use()
        {
            Console.WriteLine("Hello");
        }
        public Use(string name):this()
        {
            Console.WriteLine("Name="+name);
        }
    }
    internal class Keywords//use
    {
        static void Main(string[] args)
        {
            Use1 u1= new Use1();
            u1.Input(1, 2);
            u1.Display( );
            Use2 u2= new Use2();
            u2.Read();
            u2.Write( );
            Use u= new Use("priyanka");
            

        }
    }


    class keywords2//this
    {

        public class Car
        {
            int x;
            int y;

            public void Input(int x, int y ) 
            {
                this.x= x;
                this.y= y;
            }
            public void Output()
            {
                Console.WriteLine(x);
                Console.WriteLine(y);
            }
        }

        static void Main(string[] args) 
        {
            Car c = new Car();
            c.Input(5,20);
            c.Output();
        }
    }
    class keywords3//const and readonly
    {
        const int x = 50;//initialization at the time of diclarationand in constructor
        readonly int y;//set in constructor and once value initialize it cant change 

        keywords3(int y)
        {
            this.y =30;
        }

        static void Main(string[] args)
        {

        }
    }

    class keywords4//ref
    {
        static public void swap(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
        }

        static void Main(string[] args) 
        {
           
            int x = 50;
            int y = 40;
     
            Console.WriteLine($"Befor swap x={x} y={y}");
            keywords4.swap(ref x, ref y);
            Console.WriteLine($"After swap x={x} y={y}");

        }
    }

    abstract class Teacher//override keyword
    {
        string name;
        string qualification;
        int experience;

        public string Name { get => name; set => name = value; }
        public string Qualification { get => qualification; set => qualification = value; }
        public int Experience { get => experience; set => experience = value; }

        public abstract void CalculateSalary();

        public override string ToString()
        {
            return $"name={name} qualification={qualification} experience{experience}"; 
        }
    }
    class visitingTeacher : Teacher
    {
        int hrs,rate;

        public visitingTeacher(string name, string qualification,int experience,int hrs, int rate)
        {
            this.hrs = hrs;
            this.rate = rate;
        }

        public override void CalculateSalary()
        {
            Console.WriteLine("salary="+hrs*rate);
        }

    }
    class Test
    {
        static void Main(string[] args)
        {
            Teacher t=new visitingTeacher("priya","BE",2,25,2000);
            t.CalculateSalary();
        }
    }

    class Animal
    {
        public string name;
        public int legs;
    }
    class Dog : Animal
    {
        new string name = "Tommy";

        public void ShowName()
        {
            Console.WriteLine(name + " " + base.name);
        }
    }
    class BabyDog : Animal
    {
        int legs = 4;
        public void ShowLegs()
        {
            Console.WriteLine(legs + " " + base.legs);
        }
    }


    class Basekeywords//base keyword
    {
        static void Main(string[] args)
        {
            BabyDog b = new BabyDog();
            b.ShowLegs();
            Dog d = new Dog();
            d.ShowName();

        }
    }
}
