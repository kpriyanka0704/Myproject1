using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.basic
{
    internal class Operators
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 2;
            int x = a++ - ++b;
            Console.WriteLine(x + " " + a + " " + b);//(-1 3 3)

            int c = 3;
            int d = 3;
            int x1 = --a - --b - a;
            Console.WriteLine(x + " " + a + " " + b);//(-2 2 2)

            int e = 2;
            int f = 2;
            int x2 = a++ - --b + --a;
            Console.WriteLine(x + " " + a + " " + b);//(-1 2 2)

            int g = 2;
            int h = 1;
            int x3 = ++b - ++a + a;
            Console.WriteLine(x + " " + a + " " + b);//(-1 3 2)

            int num1 = 10;
            int num2 = 30;
            Console.WriteLine(num1 > num2 && num2 < num1);//F
            Console.WriteLine(num1 > num2 || num2 < num1);//F
            Console.WriteLine(num1 < num2);//T

            int X = 10;
            Console.WriteLine(X += 2);//12
            Console.WriteLine(X -= 3);//9
            Console.WriteLine(X *= 2);//18
            Console.WriteLine(X /= 4);//4
            Console.WriteLine(X %= 5);//4

        }
    }
}
