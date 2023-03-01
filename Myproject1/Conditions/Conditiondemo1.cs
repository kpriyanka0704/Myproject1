using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Conditions
{
    internal class Conditiondemo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int num1 = int.Parse(Console.ReadLine());
           

            if (num1 % 2 == 0)
            {
                Console.WriteLine("number is even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }
        }
    }


    class Conditionaldemo2
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = int.Parse((string)Console.ReadLine());

            if (num1 > 0)
            {
                Console.WriteLine("the num is positive");
            }
            else
            {
                Console.WriteLine("the num is negative");
            }
        }

    }


    class Conditionaldemo3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 3 == 0)
            {
                Console.WriteLine("The num is multiple of 3");
            }
            else
            {
                Console.WriteLine("The number is not multiple of 3");
            }


        }

    }



    class Conditionaldemo4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("The num is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("The num is negative");
            }
            else
            { Console.WriteLine("The num is zero");
            }


        }
    }


    class Conditionaldemo5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 3 == 0)
            {
                Console.WriteLine("The num is divisible by 3");
            }
            else if (num % 9 == 0)
            {
                Console.WriteLine("The num is divisible by 9");
            }
            else
            {
                Console.WriteLine("The num is not divisible by 3 and 9");
            }
        }
    }

    class Conditionaldemo6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to chek");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 50 && num < 100)
            {
                Console.WriteLine("The num is greater than 50");
            }
            else if (num < 100)
            {
                Console.WriteLine("The num is less than 100");
            }
            else
            {
                Console.WriteLine("The num is not greater than 50 or less than 100");
            }
        }
    }


    class Conditionaldemo7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the char");
            char ch = Convert.ToChar(Console.ReadLine());
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine("The char is alphabet");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("The char is digit");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }

    class Conditionaldemo8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the char");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("The char is vowels");
            }
            else
            {
                Console.WriteLine("The char is consonent");
            }
        }

    }

    class Conditionaldemo10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the weight");
            int wt = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                if (wt >= 50)
                    Console.WriteLine("Eligible for blood donation");

                else
                {
                    Console.WriteLine("wt is less try next time");
                }
            }
            else
            {
                Console.WriteLine("not eligible");
            }
        }
    }



    class Conditionaldemo11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("The first number is gr");
            }
            else if (num2 > num3)
            {
                Console.WriteLine("The second num is gr");
            }
            else
            {
                Console.WriteLine("The third num is gr");
            }
        }
    }


    class Conditionaldemo12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the char");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("The char is vowels");
            }
            else
            {
                Console.WriteLine("The char is consonent");

            }

        }
    }


    class Conditionaldemo13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num > 99 && num < 1000)
            {
                Console.WriteLine("the num is 3 digit");
            }
            else
            {
                Console.WriteLine("the num is not 3 digit");
            }
        }
           
        
    }



    class Conditionaldemo14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the char");
            char ch = Convert.ToChar(Console.ReadLine());
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine("The char is alphabet");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("The char is digit");
            }
            else
            {
                Console.WriteLine("Special character");
            }
        }
    }
}

               


              
                

                
              
        
     




