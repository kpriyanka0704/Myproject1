using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.InterfaceDemo
{
    internal abstract class Absparent//Task 2
    {
        public int x;
       

    }
    internal interface IAbsparentable
    {
        static int y;
        
    }
    internal class Abschild:Absparent,IAbsparentable
    {
        
       
        public void ShowAddition(int res)
        {
            Console.WriteLine("addition=" + res);
        }
    }
       
        
    internal class InterfaceDemo
    {
          static void Main(string[] args)
          {
              Abschild abs = new Abschild();
            Console.WriteLine("Enter the value of x");
            abs.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of y");
            IAbsparentable.y=int.Parse(Console.ReadLine());
            int a = abs.x + IAbsparentable.y;
                abs.ShowAddition(a);
                
          }
    }



    interface IMovement//interface3
    {
        void Move();
    }
    interface IMakeSound
    {
        void MakeSound();
    }
    class Cat:IMovement,IMakeSound
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow");
        }
        public void Move() 
        {
            Console.WriteLine("Walking gracefully");
        }
    }
    class InterfaceDemo3
    {
        static void Main(string[] args)
        {
            IMovement i= new Cat();
            i.Move();
            IMakeSound i1= new Cat();
            i1.MakeSound();
        }
    }


    
}
