using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.basic
{
    internal class Swapping
    {

        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int temp;
            Console.WriteLine("Before swapping");

            temp= a;
               a= b;
              b= temp;
            Console.WriteLine("after swapping");
            Console.WriteLine("a= "+a);
            Console.WriteLine("b= " + b);
         }
    }
}
