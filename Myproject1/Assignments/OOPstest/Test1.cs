using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Myproject1.Assignments.OOPstest
{
    internal class User//Constructor chaining
    {
        public User() 
        {
            Console.WriteLine("Welcome");
        }
        public User(string qualification)
        {
            Console.WriteLine(qualification);
        }
        public User(string qualification,string name):this("Welcome") 
        { 
            Console.WriteLine(qualification +" "+name);
        }
    }
     class Test1
     {
        static void Main(string[] args)
        {
            User u= new User("BE","Amit");
            Console.WriteLine();
        }
     }

    public class Animal//Use of base keyword
    {
        public string colour = "White";
    }
    public class Dog : Animal
    {
        string colour = "Black";

        public void Show()
        {
            Console.WriteLine(base.colour);
            Console.WriteLine(colour);
        }
    }
    class Base
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.Show();
        }
    }

    class Vehicle
    {
        public int wheels = 4;
    }
    class FourWheel : Vehicle
    {
        public int price = 500000;
    }
    class Car : FourWheel
    {
        public string name = "Ford";
        public string colour = "Black";

        public void Show()
        {
            Console.WriteLine(wheels+" "+price+" "+name+" " +colour);
        }
    }
    class MultilevelInheritance
    {
        static void Main(string[] args)
        {
            Car c= new Car();
            c.Show();
        }
    }

    class Pattern//
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the num of rows");
            int rows=int.Parse(Console.ReadLine());
            for(int i=1; i<=rows; i++) 
            {
                for(int j=rows;j>=i;j--) 
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=i;k++)
                {
                    if(i%2==1)
                    {
                        Console.Write(k+" ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(" ");
            }
        }
    }

    
    class Switch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the country name");
            string country = (Console.ReadLine());
            switch(country) 
            {
                case "India": Console.WriteLine("Hockey");
                    break;
                case "China": Console.WriteLine("Table Tennis");
                    break;
                case "Bangladesh": Console.WriteLine("Kabaddi");
                    break;
                case "Italy": Console.WriteLine("Football");
                    break;
                case "United State": Console.WriteLine("Baseball"); 
                    break;
                default: Console.WriteLine("invalid");
                    break;
            }
        }
    }


    class Dotransaction
    {
        public void CreditCard()
        {
            Console.WriteLine("You got 15% discount on bill on creditcard transaction");
        }
        public void DebitCard()
        {
            Console.WriteLine("No discount on bill on debitcard transaction");
        }
    }
    class Shopping
    {
        static void Main(string[] args)
        {
            Dotransaction d= new Dotransaction();
            d.CreditCard();
            d.DebitCard();
        }
    }
    
}
