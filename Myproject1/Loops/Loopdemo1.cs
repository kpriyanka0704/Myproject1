using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Loops
{
    internal class Loopdemo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("odd numbers between 35 to 50");
            for (int i =35;i<=50;i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);

            }
        }
    }

    class Loopdemo2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of 1 to10 numbers");
            int sum = 0;
            for (int i = 1; i <= 10; i++)
                sum += 1;
            Console.WriteLine("Sum of 1 to 10= "+sum);
        }
    }

    class Loopdemo3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd numbers between 20 to 50");
            int num1 = 0;
            for (int i = 20; i <= 50; i++)
                if (i % 2 != 0)
                    Console.WriteLine(i);
        }
    }


    class Loopdemo4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find numbers between 320 to 225");
            int num1 = 0;
            for(int i = 320; i>=225; i--)
                
                    Console.WriteLine(i);
            
        }
    }
    class Loopdemo5
    {
        static void Main(string[] args)
        {
           

            int i, n;
            Console.WriteLine("Enter the input number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for(i = 1; i<=10; i++)
            {
                Console.WriteLine("{0} X {1} = {2} \n",n,i,(n*i));

            }
        }
    }
    class Loopdemo6
    {
        static void Main(string[] args)
        {
                 Console.WriteLine("Find odd numbers between 521 to 229");
                int num1 = 0;
                for (int i = 521; i >= 229; i--)
                if (i % 2 != 0)
                    Console.WriteLine(i);
        }
    }

    class Loopdemo7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find even numbers between 121 to 229");
            int num1 = 0;
            for (int i = 121; i <= 229; i++)
                if (i % 2 == 0)
                    Console.WriteLine(i);

        }
    }

    class Loopdemo8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the character from a to z");
            char ch = '0';
            for(ch ='a'; ch<='z'; ch++)
                Console.WriteLine(ch);

        }
    }
    
}
