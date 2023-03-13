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

    class ArraySortDemo
    {
        public static void SortArray(int[] a)
        {
            Console.WriteLine(string.Join(", ", a));
            for(int i=0;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++) 
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }

        }


        static void Main(string[] args)
        {
            int[] arr = { 'a', 'b', 'Y', 'd', 'u' };
            ArraySortDemo.SortArray(arr);
            Console.WriteLine(string.Join(", ", arr));


        }
    }

    class ArrayDemo10//Frequency of each element of integer type of array
    {

        public static void FindOccurance(int[]a)
        {
            for(int i=0;i<a.Length;i++) 
            {
                int count = 1;
                bool isvisited=false;
                for(int k=i-1;k>=0;k--)
                {
                    if (a[k] == a[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if(isvisited==false)
                {
                    for(int j=i+1;j<a.Length;j++)
                    {
                        if (a[i] ==a[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(a[i]+" "+count);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 10, 4, 10, 5,3 };
            ArrayDemo10.FindOccurance(arr);
        }
    }

    class ArrayDemo11//frequency of each element in character type of array
    {
        public static void FindOccurance(char[] ch)
        {
            for (int i = 0; i < ch.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (ch[k] == ch[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < ch.Length; j++)
                    {
                        if (ch[i] == ch[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(ch[i] + " " + count);
                }
            }
        }
        static void Main(string[] args)
        {
            char[] ch = { 'A', 'T', 'H', 'A', 'U', 'T', 'A' };
            ArrayDemo11.FindOccurance(ch);
        }
    }
    

    class ArrayDemo12//duplicate number from array
    {

        public static void FindOccurance(int[] a) 
        {
            for(int i=0;i<a.Length;i++)
            {
                int count = 1;
                bool isvisited = false;
                for(int k=i-1;k>=0;k--) 
                {
                    if (a[k] == a[i])
                    { 
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false) 
                {
                    for(int j=i+1;j<a.Length; j++)
                    {
                        if (a[i] == a[j]) 
                        { 
                            count++;
                        }
                    }
                    if (count > 1)// duplicate number
                    {
                        Console.WriteLine(a[i] + " " + count);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 6, 4, 6, 8, 9 };
            ArrayDemo12.FindOccurance(arr);
        }
    }

    class ArrayDemo13//Unique element
    {

        public static void FindOccurance(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (a[k] == a[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    if (count == 1)//unique element from array
                    {
                        Console.WriteLine(a[i] + " " + count);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 8, 2, 4, };
            ArrayDemo13.FindOccurance(arr);
        }
    }

    class ArrayDemo14
    {
        static void Main(string[] args)
        {
            int[] a = {1,-4,5,6,-9 };
            Console.WriteLine(string.Join(" ", a));
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] < 0) 
                { 
                    if(i<a.Length-1)
                    {
                        a[i] = a[i + 1] * a[i + 1];
                    }
                    else if (a[i] ==1)
                    {
                        a[i] = a[0] * a[0];
                    }
                }
            }
            Console.WriteLine(string.Join(" ", a));
        }
    }

    class ArrayDemo16//Replace
    {
        static void Main(string[] args)
        {
            char[] c = { 't','E','P','v','a' };
            Console.WriteLine(string.Join(" ", c));
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = (char)(c[i] + 2);
                Console.WriteLine(c[i]);
            }
            
        }


    }

    

    class ArrayDemo15//MergeArray
    {
        static void Main(string[] args)
        {
            int i, x, n1, n2, sum;


            int[] arr1 = new int[4];
            int[] arr2 = new int[4];
            int[] arr3 = new int[8];
            Console.WriteLine("Enter the first array size");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter element ");
            for (i = 0; i < n1; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the second array size");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the element");
            for (i = 0; i < n2; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < n1; i++)
            {
                arr3[i] = arr1[i];
            }
            sum = n1 + n2;
            for (i = 0, x = n1; x < sum && i < n2; i++, x++)
            {
                arr3[x] = arr2[i];
            }
            Console.WriteLine("After merging two arrays");
            for (i = 0; i < sum; i++)
            {
                Console.WriteLine("\t" + arr3[i]);
            }
            Console.ReadLine();
        }
    }


    class ArrayDemo17//MergeArray
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 20, 30, 40 };
            int[] b = { 50, 60, 70, 80 };
            int[] c = new int[10];

            for(int i=0; i<a.Length; i++)
            {
                c[i] = a[i];
                Console.WriteLine(c[i]);
            }
            for(int i=0;i<b.Length;i++)
            {
                c[i] = b[i];
                Console.WriteLine(b[i]);
            }

        }


    }
       
    
        
    

    
}


