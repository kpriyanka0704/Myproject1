using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Loops
{
    internal class Dowhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the row");
            int row = int.Parse(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    class Dowhile1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the row");
            int row = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i == 1 || j == 1 || i == row || j == row)
                    {
                        Console.Write("i");
                    }


                    else
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }

    class Dowhile2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the row");
            int row = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);


                }
                Console.WriteLine();
            }
        }
    }

    class Dowhile3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }

    class Dowhile4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows");
            int row = int.Parse(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)


                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }

    class Dowhile5//Star pattern
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of rows");
            int row = int.Parse(Console.ReadLine());
            for (int x = 1; x <= 5; x++)

                for (int y = 1; y <= x; y++)
                {
                    Console.Write("*");

                }
            Console.WriteLine();

        }

    }
    class Dowhile6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows");
            int row = int.Parse(Console.ReadLine());
            for (int x = 5; x >= 1; x--)
            {
                for (int y = 1; y <= x; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    class Dowhile7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows");
            int row = int.Parse(Console.ReadLine());
            for (int x = 1; x <= 5; x++)
            {
                for (int y = x; y < 5; y++)
                {
                    Console.Write(" ");
                }
                for (int Z = 1; Z < (x * 2); Z++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }


     class Dowhile8
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enterthe number of rows");
            int row= int.Parse(Console.ReadLine());
            for(int x=5;x>=1;x--)
            {
                for(int y=5;y>x;y--)
                { Console.Write(" ");
                }
                for(int z= 1;z<(x*2);z++)
                { Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }



    class Dowhile9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of rows");
            int row = int.Parse(Console.ReadLine());
            for (int x = 1; x <= 5; x++)
            {
                for (int y = 4; y >= x; y--)
                {
                    Console.Write(y);

                }
                Console.WriteLine();
            }
        }

        class Dowhile10//Character pattern
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the number of rows");
                int row = int.Parse(Console.ReadLine());
                int z = 5;
                for (int x = 1; x <= z; x++)
                {
                    for (int y = x; y <= z; y++)
                    {
                        Console.Write((char)(x + 64));
                    }
                    Console.WriteLine("");
                }
            }
        }
    }


    class Dowhile11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of rows");
            int row = int.Parse(Console.ReadLine());
            for (int i = 1; i <= row * 2 - 1; i++)
            {
                if (i != row)
                    for (int j = 1; j <= row; j++)
                        if (j == row)
                        {
                            Console.Write(" *");


                            Console.WriteLine();
                        }

                        else

                            for (int j1 = 1; j <= row * 2 - 1; j++)
                            {
                                Console.WriteLine("*");
                            }
            }
        }
    }

    class Dowhile12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows");
            int row= int.Parse(Console.ReadLine());
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

  class Dowhile13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of rows");
            int row=int.Parse(Console.ReadLine());  
            for(int i= row;i>=1;i--)
            {
                for(int j=1;j<=i;j++)
                { Console.Write(j); 
                }
                Console.WriteLine( );

            }
        }
    }

    class loop9
    {
        static void Main(string[] args)
        {
            for(int i=5;i>0;i--)
            {
                int mysteryInt = 100;
                mysteryInt -= i;
                Console.WriteLine(mysteryInt);
            }
        }
    }


    class Loop10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = int.Parse(Console.ReadLine());

            int i = 2;
            bool istwinprime = true;
            while (num1 < 0 && num2<0)
            {
                if (num1 % i == 0 && num2%i==0)
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

    class Loop13
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

        
    class Loop15
    {
        static void Main(string[] args)
        {
            int i,  fact = 1;
            float sum = 0;
            Console.WriteLine("Enter the value of n");
            int n=int.Parse(Console.ReadLine());
            for(i=1; i<=n; i++)
            {
                fact=fact*i;    
                sum=sum+(fact/i);

            }
            Console.WriteLine("the value of series=" + sum);
        }
    }


    class Loop11
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter the num from 1 to 50");
            int num=int.Parse(Console.ReadLine());
            
            for(i=1;i<=50;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine("num is even="+num);
                }
                else
                 
                    Console.WriteLine("num is negative="+(num*num));
                
            }
        }
    }

    class loop2
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
}







                 
        


             
    

