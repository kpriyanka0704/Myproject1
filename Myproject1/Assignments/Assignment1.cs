using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Myproject1.Assignments
{
    internal class Assignment1//Area of equilateral triangle
    {
        static void Main(string[] args)
        {
            float a, area;

            Console.WriteLine("Area of equilateral triangle");
            Console.WriteLine("Enter the side");
            int side = int.Parse(Console.ReadLine());
            switch (side)
            {
                case 1:
                    Console.WriteLine("Enter the side");
                    a = float.Parse(Console.ReadLine());
                    Console.WriteLine("Area of equilateral triangle= " + (1.73 * a * a) / 4);
                    break;
            }
        }
    }

    class Assignment2//Calculate percentage
    {
        static void Main(string[] args)
        {

            float percentage;

            Console.WriteLine("Enter the marks of five subjects");
            Console.WriteLine("1.Marks of eng\n2.mrks of phy\n3.marks of chem\n4.marks of math\n5.marks of comp");
            Console.WriteLine("enter the marks of first sub");
            float eng = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the marks of second sub");
            float phy = float.Parse(Console.ReadLine());
            Console.WriteLine("emter the marks of third sub");
            float chem = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the marks of fourth sub");
            float math = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the marks of fifth sub");
            float comp = float.Parse(Console.ReadLine());


            float total = (eng + phy + chem + math + comp);
            Console.WriteLine("total=" + total);

            percentage = ((total / 5) * 100);
            Console.WriteLine("Percentage=" + percentage);
        }



        class Assignment3//Calculate CI
        {
            static void Main(string[] args)
            {

                float principle, rate, time, CI, pow;
                Console.WriteLine("Enter the principle");
                float P = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the time");
                float T = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the rate");
                float R = float.Parse(Console.ReadLine());

                Console.WriteLine("Calculate CI=" + P * (1 + R / 100));
            }
        }
    }


    class Assignment4//Celcius to fahrenheit
    {
        static void Main(string[] args)
        {
            float fahrenheit, celsius;

            Console.WriteLine("Enter the temp in celsius");
            int cel = int.Parse(Console.ReadLine());
            celsius = 13;
            fahrenheit = ((cel * 9) / 5) + 32;
            Console.WriteLine("Temp in fahrenheit=" + fahrenheit);
        }
    }


    class Assignment5//Fahrenheit to celsius
    {
        static void Main(string[] args)
        {
            float celsius, fahrenheit;
            Console.WriteLine("Enter the temp in fahrenheit");
            int f = int.Parse(Console.ReadLine());
            fahrenheit = 205;
            celsius = ((f - 32) * 5 / 9);
            Console.WriteLine("Temp in celsius=" + celsius);
        }
    }

    //CONDITONAL STATEMENT

    class Assignment6// Year is leap or not
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0) && (year % 100 != 0))
            {
                Console.WriteLine("Leap year");
            }

            else
            {
                Console.WriteLine("not leap year");
            }

        }

    }          
                
            
class Assignment7//check the num is divisible by 5 or 11 or not
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num =Convert.ToInt32(Console.ReadLine());
            if(num%5==0)
            {
                Console.WriteLine("Num is divisibla by 5");
            }
            else if(num%11==0)
            {
                Console.WriteLine("Num is divisible by 11");
            }
            else
            { Console.WriteLine("not divisible by 5 and 11"); 
            }
            
           

        }
    }

    class Assignment8//Find the greatest num between 3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first num");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second num");
            int num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third num");
            int num3=Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("num1 is greater=" + num1);
            }
            else if(num2>num3)
            {
                Console.WriteLine("num2 is greater="+num2);

            }
            else
            {
                Console.WriteLine("num3 is greater");
            }
        }
    }

    class Assignment9//check the character is vowel or consonent
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the character");
            int ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("Char is vowel");
            }
            else
            {
                Console.WriteLine("Char is consonent");
            }
        }
    }


    class Assigment10//Simple calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first num");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second num");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("+Addition\n - Substraction\n * Multiplication\n / Division");
            Console.WriteLine("Enter the valid operator from above menu");
            char op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine(" Addition=" + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine(" Substraction=" + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("Multiplication=" + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine("Division=" + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;

            }
        }
    }

  class Assignment11//Check the num is positive or negative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int num= Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("num is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("num is negative");
            }
            else 
            {
                Console.WriteLine("num is zero");
            }
            
           
        }
    }

    class Assignment12//check the character is Consonent,digitorspecial character
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the character");
            int ch = Convert.ToChar(Console.ReadLine());
            if (ch >='A'&& ch<='Z'||(ch>='a'&& ch<='z') )
            {
                Console.WriteLine("Char is consonent");
            }
            else if(ch>='0'&& ch<='9')
            {
                Console.WriteLine("Char is digit");
            }
            else 
            { 
                Console.WriteLine("It is special chaaracter");
            }
            
        }
    }

    class Assignment13//Check the num is odd or even
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the input");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num % 2 == 0)
            {
                case true:
                    Console.WriteLine("The num is even");
                    break;
                case false:
                    Console.WriteLine("The num is odd");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }

    class Assignment14//Number of days in months
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days");
            int N = Convert.ToInt32(Console.ReadLine());
            //checked for 31 days
            if (N == 1 || N == 3 || N == 5 || N == 7 || N == 8 || N == 10 || N == 12)
            {
                Console.WriteLine("31 Days");
            }
            //check for 30 Days
            else if (N == 4 || N == 6 || N == 9 || N == 11)
            {
                Console.WriteLine("30 Days");
            }
            //Check for 28/29Days
            else if (N == 2)
            {
                Console.WriteLine("28/29 Days");
            }
            else
            {
                Console.WriteLine("Invalid Month");
            }

        }

    }

    
}          
            
                
                  
                



                

            

        
       


