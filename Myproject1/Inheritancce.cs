using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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
}
