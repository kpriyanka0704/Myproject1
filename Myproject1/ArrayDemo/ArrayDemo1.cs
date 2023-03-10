using Myproject1.basic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.ArrayDemo
{
    internal class ArrayDemo1//Character array
    {
        static void Main(string[] args)
        {
            char[] array = new char[] { 'a', 'b', 'c', 'd', 'e' };
            char[] ch = new char[5];
            Console.WriteLine("Enter the array element");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("............");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("......");


            foreach (int x in array)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("........");

            Console.WriteLine(string.Join(' ', array));
        }

    }

    class ArrayDemo2//Display element
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int[] ch = new int[5];
            Console.WriteLine("Enter the array element");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(".......");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            foreach (int x in array)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(".....");
            Console.WriteLine(string.Join(' ', array));
        }
    }

    class ArrayDemo3//Even sum
    {
        static void EvenSum(int[] a)
        {
            Console.WriteLine("even element");
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    sum = sum + a[i];
                }
                Console.WriteLine(sum);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the array elememnt");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            ArrayDemo3.EvenSum(a);
        }
    }

    class ArrayDemo4//Odd sum
    {
        static void OddSum(int[] a)
        {
            Console.WriteLine("odd element");
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]% 2 == 1)
                {
                    sum = sum + a[i];
                }
                Console.WriteLine(sum);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the array elememnt");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            ArrayDemo4.OddSum(a);
        }
    }

    class ArrayDemo5//Element sum
    {

        static void ElementSum(int[] a)
        {
            Console.WriteLine("element");
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size");
            int size = int.Parse(Console.ReadLine());

            int[] a = new int[size];
            Console.WriteLine("Enter the array elememnt");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            ArrayDemo5.ElementSum(a);
        }
    }

    class ArrayDemo6//max and min element
    {

        static void Maxint(int[] a) 
        {
            int max = 0;
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]+" " + ((int)a[i]));
                if (a[i] > max)
                {
                    max = a[i];
                }
                Console.WriteLine(max);
            }
            
        }
        static void Minint(int[] a)
        {
            int min = 0;
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + " " + ((int)a[i]));
                if (a[i] > min)
                {
                    min = a[i];
                }
                Console.WriteLine(min);
            }
        }
        static void Main(string[] args)
        {
            int[] array = {10,20,50,44,66};
            ArrayDemo6.Maxint(array);
           ArrayDemo6.Minint(array);
        }
    }

    class ArrayDemo7//reverse element
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 20, 50, 40 };
            Console.WriteLine(string.Join(" ",a));
            int j= a.Length - 1;
            for(int i=0;i<a.Length/2;i++)
            {
                int temp= a[i];
                a[i]= a[j];
                a[j]= temp;
                j--;
            }
            Console.WriteLine(string.Join(" ", a));
        }
    }

    class ArrayDemo8//Reverse character
    {
        static void Main(string[] args) 
        {
            char[] ch = {'A','B','C','D'};
            Console.WriteLine(string.Join(" ",ch ));
            int j = ch.Length - 1;
            for (int i = 0; i < ch.Length / 2; i++)
            {
                int temp = ch[i];
                ch[i] = ch[j];
                ch[j] = (char)temp;
                j--;
            }
            Console.WriteLine(string.Join(" ", ch));
        }
    }

    class ArrayDemo9//incomplete code
    {

        static void ShowPrime(int[] a, int n)
        {
            bool isprime = false;
            for (int i = 0; i < 20; i++)
            {
                n = a[i];
                for (int j = 2; j <= n; j++)
                {
                    if (i % j == 0)
                    {
                        isprime = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("prime element= " + i);
                    }
                }

            }

        }         
                
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter the size");
            int size = int.Parse(Console.ReadLine());
             int[] a = new int[size];
           
            Console.WriteLine("Enter the array elememnt");
            
            for (int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine()) ;
            }
            ArrayDemo9.ShowPrime(a,size);
            
            

            
        }
    }

    class ArrayDemo10
    {
        static void Main(string[] args)
        {
           


        }
    }
    
}


