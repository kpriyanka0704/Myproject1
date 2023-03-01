using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Loops
{
    internal class Whileloop
    {
        static void Main(string[] args)//Count the numbers of digits from the number
        {


            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int Count = 0;
            while (num > 0)
            {
                int digit = num % 10;
                Count++;
                num = num / 10;
            }

            Console.WriteLine(" Digit of num=" + Count);

        }
    }

    class Whileloop1  //Average of digits from the number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num1 = int.Parse("Console.ReadLine()");
            int tot = 0;
            int Count1 = 0;
            while (num1 < 0)
            {
                int digit = num1 % 10;
                tot = tot + digit;
                num1 = num1 / 10;
                Count1++;

            }

            Console.WriteLine("Total=" + tot);
            Console.WriteLine("Average of numbers=" + (tot / Count1));
        }
    }


    class Whileloop2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num1 = int.Parse(Console.ReadLine());
            int original = num1;
            int rev = 0;
            while (num1 != 0)
            {
                int num = num1 % 10;
                rev = rev * 10 + num;
                num1 /= 10;
            }
            Console.WriteLine("rev");
            if (original == rev)
            {
                Console.WriteLine("Pallendrome num");
            }
            else
                Console.WriteLine("Not pallendrome num");
        }
    }


    class Whileloop3
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Enter the number");
            int num1 = int.Parse(Console.ReadLine());
            int num = num1;
            int r = 0;
            int result = 0;
           while (num1 > 0 )
            {    
                r = num1 % 10;
               result = result + (r * r * r);
                num= num1/ 10;
                result++;
            }

            if ( result == num1) 
            {
                Console.WriteLine("num is armstrong num"+ num1);
            }
            else
                Console.WriteLine("num is not armstrong num"+num1);
            

            

        
        
        }
    }

    class Whileloop5
    {
        static void Main(string[] args)
        {

                 Console.WriteLine("odd numbers between 35 to 50");
            int i = 35;
            while (i <= 50)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
                i++;
            }
        }
    }

    class   Whileloop6
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter the character from a to z");
            char ch = 'a';
            while (ch <= 'z')
            {
                Console.WriteLine(ch);
                ch++;
            }
        }
    }

    class Whileloop7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find odd numbers between 521 to 229");
            int i = 521;
            while (i >=229)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
                i--;
            }
        }
    }

    class Whileloop8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int i = 2;
            bool isprime = true;
            while (num < 0)
            { 
                if(num%i==0)
                    isprime = false;
                i++;
                break;

            }
            if (isprime==true)
            {
                Console.WriteLine("num is prime");
            }
            else
            {
                Console.WriteLine("num is not prime");
            }

        }
    }

    class Whileloop9
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("enter the num");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num > 0) 
            {
                int digit = num % 10;
                sum=sum+digit;
                num=num%10;
            }
            Console.WriteLine("sum");

        }
    }

}           
            
            

         
    

