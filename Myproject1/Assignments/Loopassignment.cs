using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Assignments
{
    internal class Loopassignment//even numbers between 121 to 229
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even numbers between 121 to 229");
            int i = 121;
            while(i<=229)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
                i++;
            }
        }
    }

    class Loopassignment1
    {
        static void Main(string[] args)
        {
            // for(initilization,condiyion,increment/decrement)
            //{
            // Logical statement
            //}

            // for example
            // int i;
            // for(i=1,i<=5,i++)
            //{
            // console.WriteLine("hello")
            //}
        }

    }

    class Loopassignment2//print alphabet from a to z
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Alphabets from a to z");
            char ch=Convert.ToChar(Console.ReadLine());
            for ( ch='a'; ch<='z';++ch) 
            { 
                Console.WriteLine(ch+" ");
            }
        }
    }

    class Loopassignment3//even num between 1 to n
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Sum of all even numbers between 1 to n");
            Console.WriteLine("Enter the upper limit:");
            int num =Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int n = 0;
            for( i=2;i<=n;i+=2)
            {
              if(i%2==0)
                {
                    sum+=i;
                }
                Console.WriteLine("Sum of all  even numbers between 1 to n= %d",n,sum);
            }
        }
    }

    class Loopassignment4//odd num between 1 to n
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of all odd numbers between 1 to n");
            Console.WriteLine("Enter the upper limit");
            int sum = 0;
            int n = 0;
            int i;
            for (i = 1; i <= n; i += 2)
            {
                sum += i;
            }
            Console.WriteLine("sum of all odd num between 1 to n=%d", n, sum);

        }
    }
    


      class Loopassignment5//sum of digits
    {
        static void Main(string[] args)
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

 class Loopassigment6//product of digits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int product=1;
            int n = 4531;
            while(n!=0)
            {
                product=product*(n%10);
                n = n / 10;
            }
            Console.WriteLine(product);
        }
    }

    class Loopassignment7//num is prime or not
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the num");
            int num=int.Parse(Console.ReadLine());
            int i = 2;
            bool isprime = true;
            while (i<num) 
            {
                if (num % i == 0) 
                    isprime = false;
                break;
            }
            if(isprime=true)
            { 
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
             }
        }
    }

    class Loopasignment8//prime num between 400 to 300
    {
        static void Main(string[] args)
        {
            Console.WriteLine("find prime num between 400 to 300");
            int num = int.Parse(Console.ReadLine());
            for (int i = 400; i >= 300;i--) 
            {
                if(i%2!=0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class Loopassignment9//table of given input
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("Enter the input number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2} \n", n, i, (n * i));

            }
        }
    }

    class Loopassignment10//frequency of given integer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nfind frequency of given integer=\n");
            Console.WriteLine("Enter the input");
            int num=int.Parse(Console.ReadLine());
            int i, n=0,j,r,ctr;
            
            for(i=0;i<10;i++)
            {
                ctr = 0;
                for(j=n;j>0;j=j/10)
                { 
                    r=j%10;
                    if(r==i)
                        ctr++;
                }
                Console.WriteLine("the frequency of =",ctr);
            }
        }
    }

    class Loopassignment11//to find exp from base num
    {
        static void Main(string[] args)
        {

            double result = 1.0;
            Console.WriteLine("Enter the base num");
            int basenum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the exp");
            int exp = int.Parse(Console.ReadLine());
            while(exp!=0)
            {
                result *= basenum;
                --exp;
            }
            Console.WriteLine("Answer= "+result);
        }
    }
    
    
class Loop12//loop test
    {
        static void Main(string[] args)
        {
            int i = 1, k = 1;
            while(i++<=5)
            {
                k*=i;
            }
            Console.WriteLine("k=" + k + "i=" + i);
        }
    }
        
    
class Looptest1//Trimorphic number or not
    {
        static void Main(string[] args)
        {
            int n = 4;
            int cube = n * n * n;
            while(n!=0)
            {
                if(n%10!=cube%10)
                {
                    Console.WriteLine("Not a trimorphic number");
                }
                n=n/10;
                cube=cube/10;
            }
            if (n == 0)
            {
                Console.WriteLine("Trimorphic number");
            }
        }
    }

  class Loopassigment12
    {
        static void Main(string[] args)
        {
            int fact = 1;
            float sum = 0;
           
            Console.WriteLine("Enter the value of n");
            int n=int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                 fact=fact* i;
                sum = sum + (fact / i);

            }
            Console.WriteLine("The value of series="+sum);
        }
  }


     class Loopassignment13//Pallindrome number or not
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

    class Loopassignment14
    {

    }
       
        

            
            
            

    
    


   class Loopassignment15//Automorphic or not
    {
        static void Main(string[] args)
        {
            int n = 25;
            int temp, square, count = 1, number;
            Console.WriteLine("Enter the num to check");
            int num=int.Parse(Console.ReadLine());
            temp =num;
            square = num * num;
            Console.WriteLine("square of num="+square);
            while(num!=0)
            {
                count = count * 10;
                num=num/10;
            }
            if(square%count==temp)
            {
                Console.WriteLine("It is automorphic num");
            }
            else 
            {
                Console.WriteLine("Not automorphic num");

            }
        }
   }

  class Additonal//print the series
    {
        static void Main(string[] args)
        {
            for(int i=10;i<=100;i+=10)
            {
                Console.WriteLine(i + " ");
            }

        }
  }

    class Additional2
    {
        static void Main(string[] args)
        {
            int n = 10;
            int term = 1;
            for (int i = 1; i <= n; i++)
            {
                term = term * 10 + 1;

                Console.WriteLine(term + " ");
            }
        }
    }


    class Additinal3
    {
        static void Main(string[] args)
        {
            for(int i=0;i<=10;i++)
            {
                int term=1+((i*(i+1))/2);
                Console.WriteLine(term +" ");
            }
        }
    }

    class Additional4
    {
        static void Main(string[] args)
        {
            for(int i=0;i<=10;i++)
            {
                int term = 1 + (i * (i + 2));
                Console.WriteLine(term + " ");
            }
        }
    }

    class Additional5
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 10; i++)
            {
                int term = 2 * i;
                Console.WriteLine(term + " ");
            }
        }
    }
        

    class Additional6
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter the num of rows");
            int rows=int.Parse(Console.ReadLine());
            for(int i=1;i<=rows;++i)
            {
                for(int j=1;j<=i;++j)
                    Console.Write(" *");
            }
            Console.WriteLine(" \n");
        }
    }
    class Additional7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the num of rows");
            int rows = int.Parse(Console.ReadLine());
            for(int i=1;i<=5;++i)
            {
                for(int j=5;j<=i;++j)
                {
                    Console.WriteLine("rows",j);
                }
                Console.WriteLine();
            }
        }
    }


    class Additional8//
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

    class Additional9//A BB CCC
    {
        static void Main(string[] args)
        {
            char alphabet = 'A';
            Console.WriteLine("Enter an uppercase char you want to print in the last row");
            char input =Convert.ToChar(Console.ReadLine());
            for(int i=1;i<=(input-'A'+1);++i)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(alphabet);
                }++alphabet;
                Console.WriteLine();
            }
        }
    }

    class Additional10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows");
            int rows=int.Parse(Console.ReadLine());
            for(int i=rows;i>=1;i--)
            {
                for(int j=1;j<=rows;j++)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=i;k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine( );
            }
        }
    }

    class Additional11
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows");
            int rows = int.Parse(Console.ReadLine());
            for (int i = rows; i >= 1; i--)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    class Additinal12
    {
        static void Main(string[] args)
        {
            int count = 1;
            Console.WriteLine("enter the num of rows");
            int rows =int.Parse(Console.ReadLine());
            for(int i=1;i<=8;i++)
            {
                Console.WriteLine(" ");

                for(int j=1;j<=i;j++)
                {
                    Console.Write(count%2);
                }count++;
                if (i % 2! == 0)
                {
                    Console.WriteLine("1");
                }
                else
                    Console.WriteLine("0");
            }
        }
    }
}
