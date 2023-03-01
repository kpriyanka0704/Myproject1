using System;
using System.Collections.Generic;
using System.Linq;
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
    internal class Keywords
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


    class keywords2
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


}
