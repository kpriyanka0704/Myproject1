using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject1.Loops
{
    internal class Switchdemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the num between 1 to 5");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                default:
                    Console.WriteLine("Invalid num");
                    break;


            }
        }
    }

    class Switchdemo1
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter the character");
            char ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("Character is vowel");
                    break;
                case 'e':
                    Console.WriteLine("Character is vowel");
                    break;
                case 'i':
                    Console.WriteLine("Character is vowel");
                    break;
                case 'o':
                    Console.WriteLine("Characte is vowel");
                    break;
                case 'u':
                    Console.WriteLine("Character is vowel");
                    break;
                default:
                    Console.WriteLine("Character is consonent");
                    break;
            }
        }
    }

    class Switchdemo2

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

    class Switchdemo3

    {
        static void Main(string[] args)
        {
            int l, b, a, h, b1;
            float r;
            int choice;
            Console.WriteLine("Area of circle,reactangle,sqare,triangle");

            Console.WriteLine("1.Area of circle \n 2. Area of reactangle \n 3.Area of square \n 4.Area of triangle");
            Console.WriteLine("Enter the choice");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter the radius");
                    r = float.Parse(Console.ReadLine());
                    Console.WriteLine("Area of circle= " + (3.14 * r * r));
                    break;
                 case 2:
                    Console.WriteLine("Enter the value of l and b");
                    l = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of reactangle= " + (l * b));
                    break;
                case 3:
                    Console.WriteLine("Enter the value of side");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of square= " + (a * a));
                    break;
                case 4:
                    Console.WriteLine("Enter the value of h and b");
                    h = int.Parse(Console.ReadLine());
                    b1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of triangle= " + ((h * b1) / 2));
                    break;
                default:
                    Console.WriteLine("Invalid num");
                    break;
            }

        }

        class Switchdemo4
        {
            static void Main(string[] args)
            {
                int a, a1, b;
                float r;
                int num;
                Console.WriteLine("Circumference of circle,Perimeter of square,Area of right angle triangle,");

                Console.WriteLine("1.Circumference circle \n 2.Perimeter of square \n 3.Area of right angle triangle");
                Console.WriteLine("Enter the number");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {

                    case 1:
                        Console.WriteLine("Enter the radius");
                        r = float.Parse(Console.ReadLine());
                        Console.WriteLine("Circumference of circle= " + (2 * 3.14 * r));
                        break;
                    case 2:
                        Console.WriteLine("Enter the value of side");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Perimeter of square= " + (4 * a));
                        break;
                    case 3:
                        Console.WriteLine("Enter the value of a1 and b");
                        a1 = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Area of right angle triangle= " + ((a1 * b) / 2));
                        break;
                    default:
                        Console.WriteLine("Invalid num");
                        break;
                }
            }
        }
    }


    class Switchdemo5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the num between 1 to 7");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednsday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;



            }
        }
    }

    class Switchdemo6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("+ Addition \n - Substraction \n * Multiplication \n / division");
            Console.WriteLine("Enter valid operator from above menu");
            char op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine("Addition=" + (num1 + num2));
                    break;
                case '_':
                    Console.WriteLine("Substraction=" + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("Multiplication =" + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine("Division=" + (num1 / num2));
                    break;
                case '%':
                    Console.WriteLine("Modulus=" + (num1 % num2));
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;



            }
        }
    }
}


        
    

        

