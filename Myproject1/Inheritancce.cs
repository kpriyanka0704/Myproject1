using Myproject1.Assignments.Assignment_Inheritance;
using Myproject1.Oops;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Myproject1
{
    class Vehicle
    {

        public string wheel = "6";
    }
     class Bike:Vehicle
     {
        public string name = "Unicorn";
        public string colour = "Red";
            public int price= 50000;
         public void Show()
         {
            Console.WriteLine("name=" + name);
            Console.WriteLine("colour="+ colour);
            Console.WriteLine("price="+ price);
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
    


    class Organization
    {
        public int rankno = 01;

    }
    class Manager:Organization
    {
        public string name = "Amit";
        public int age = 35;
    }
    class Employee:Manager
    {
        protected int id = 101;
        public float salary = 40000;

        public void Show()
        {
            Console.WriteLine(rankno+" "+name+" "+age+" "+id+" "+salary);
        }
    }
    
    class Multilevel
    {
        static void Main(string[] args)
        {
            Employee emp= new Employee();
            emp.Show();
        }
    }

  
    

    class Sports
    {
        public string name = "Cricket";

    }
    class Cricket:Sports
    {
        public string CaptainName = "Virat kohli";
        public int NoofPlayers = 11;

        public void ShowCricket() 
        {
            Console.WriteLine("Name= "+ name+ "NoOfPlayers= "+NoofPlayers);
        }
    }
    class Football:Sports
    {
        protected string BallWeight ="410g" ;
        public string BallColour ="White";
        public string BallMaterial = "Leather";

        public void ShowFootBall()
        {
            Console.WriteLine("BallWeight= "+BallWeight+ "BallColour= "+BallColour+ "BallMatrial= "+BallMaterial);
        }
    }
    

    
    
    class Hieraechical
    {
        static void Main(string[] args)
        {
           Football f= new Football();
            f.ShowFootBall();
            Cricket c= new Cricket();
            c.ShowCricket();
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

   class Nib
    {
        string materialtype;
        int price;

        public Nib(string materialtype,int price)
        {
            this.materialtype = materialtype;
            this.price = price;
        }
        public void Show()
        {
            Console.WriteLine(materialtype + " " + price);
        }
    }
    
    class Pen
    {
        string colour;
        string name;
        string  nibtype;
        Nib nnib;

        public Pen(string colour, string name, string nibtype)
        {
            this.colour = colour;
            this.name = name;
            this.nibtype = nibtype;
        }
        public void Show() 
        {
            Console.WriteLine(colour+ " " + name+" "+nibtype);
        }
    }
   
    
    
    class Bag
    {
         string brand;
         string colour;
         int price;
         Pen ppen;

        public  Bag(string brand, string colour, int price)
        {
            this.brand = brand;
            this.colour = colour;
            this.price = price;
            
        }
        public void Show()
        {
            Console.WriteLine(brand+" "+colour+" "+price);
        }

        static void Main(string[] args) 
        {

            Nib n = new Nib("Gold",10);
            Pen p = new Pen("Blue","Trimax","Gel");
            Bag b = new Bag("American Tourister","Red",500);
            b.Show();

            n.Show();
            p.Show();
            b.Show();
        }
    }

     class Vehicle1
     {
        public int wheels;
     }

    class Fourwheeler:Vehicle1
    {
        int wheels = 4;
        public void ShowFourwheeler()
        {
            Console.WriteLine(wheels+" "+base.wheels);
        }
    }
    class Car: Vehicle1
    {
       string colour = "Black";

        public void  ShowCar() 
        {
            Console.WriteLine(colour + " " + base.colour);
        }
    }
        
    
    
    
    class Basekeywords
    {
        static void Main(string[] args)
        {
            Fourwheeler f= new Fourwheeler();
            f.ShowFourwheeler();
            Car c= new Car();
            c.ShowCar();
        }
    }
}
