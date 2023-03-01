using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Assignments
{
    internal class Looptest7
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enterthe number of rows");
            int row = int.Parse(Console.ReadLine());
            for (int x = 5; x >= 1; x--)
            {
                for (int y = 5; y > x; y--)
                {
                    Console.Write(" ");
                }
                for (int z = 1; z < (x * 2); z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    class Looptest8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows");
            int row= int.Parse(Console.ReadLine());
            for(int i=row;i>=1;--i)
            {
                for(int j=1;j<=i;++j) 
                {
                    Console.Write(j);
                }
                Console.WriteLine( );
            }
        }
    }

    class Looptest6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the num of rows");
            int rows= int.Parse(Console.ReadLine());
            for(int i=1;i<=4;i++)
            {
                for(int j=4-i;j>=1;j--)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=2*i-1;j++)
                { 
                    Console.Write(i); 
                }
                Console.WriteLine( );   
            }
        }
    }

    class Looptest5//Trimorphic number
    {
        static void Main(string[] args)
        {
            int n = 4;
            int cube = n * n * n;
            while (n != 0)
            {
                if (n % 10 != cube % 10)
                {
                    Console.WriteLine("Not a trimorphic number");
                    break;
                }
                n = n / 10;
                cube = cube / 10;
            }

            if (n == 0)
            {
                Console.WriteLine("Trimorphic number");
            }
        }
    }



   
    

    class Looptest3
    {
        static void Main(string[] args)
        {
            int i = 1, k = 1;
            while(i++<5)
            {
               k*=i;
            }
            Console.WriteLine("k=" + k + "i=" + i);
        }
    }

    class Looptest2
    {
        static void Main(string[] args)
        {
            int b = 0;
            do
            {

                int a = 2;
                b++;


                Console.WriteLine(a++);
            }
            while (b != 3);
        }
    }

    class Looptestt
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 5;
            int c = 10;
            for(a=1;a<+100;a++)
            {
                Console.WriteLine(a);
            }
            if((a%5)==0) 
            {
                Console.WriteLine(a / b);
            }
            else if((a%10)==0) 
            {
                Console.WriteLine(a / c);
            }

        }
    }

    class Looptest9
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                int mysteryInt = 100;
                mysteryInt -= i;
                Console.WriteLine(mysteryInt);
            }
        }
    }

    class Looptest10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = int.Parse(Console.ReadLine());

            int i = 2;
            bool istwinprime = true;
            while (num1 < 0 && num2 < 0)
            {
                if (num1 % i == 0 && num2 % i == 0)
                    istwinprime = false;
                i++;
                break;

            }
            if (istwinprime == true)
            {
                Console.WriteLine("num is twinprime");
            }
            else
            {
                Console.WriteLine("num is not twinprime");
            }
        }
    }

    class Looptest12
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                int j = 1;
                while (j <= 5)
                {
                    if (j == 2)
                    {
                        break;
                        Console.WriteLine(j);
                    }
                    j++;
                }
                Console.WriteLine(i);
            }
        }

    }

    class Looptest13
    {
        static void Main(string[] args)
        {
            int i, fact = 1;
            float sum = 0;
            Console.WriteLine("Enter the value of n");
            int n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
                sum = sum + (fact / i);

            }
            Console.WriteLine("the value of series=" + sum);
        }
    }

    class Looptest14
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter the num from 1 to 50");
            int num = int.Parse(Console.ReadLine());

            for (i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("num is even=" + num);
                }
                else

                    Console.WriteLine("num is negative=" + (num * num));

            }
        }
    }
}
