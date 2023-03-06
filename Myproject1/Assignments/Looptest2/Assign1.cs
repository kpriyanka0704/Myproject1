using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Assignments.Looptest2
{
    internal class Assign1//print number which are not divisible by 5 and 10.
    {
        static void Main(string[] args)
        {

            int i;
            for (i = 1; i <= 100; i++)
            {
                if ((i % 5 != 0) && (i % 10 != 0))
                {
                    Console.WriteLine(i);

                }
            }
        }
    }

    class Assign2//print all factors of given number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class Assign3//print num 1 to 50 if num is even print as it is and if odd print its square
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else if (i % 2 != 0)
                {
                    Console.WriteLine(i * i);
                }
            }
        }
    }

    class Assign4//print fibbo series
    {
        static void Main(string[] args)
        {
            int i, n;
            int t1 = 0; int t2 = 1;
            int nextTerm = t1 + t2;
            n = nextTerm + 1;

            for (i = 3; i <= n; i++)
            {
                t1 = t2;
                t2 = nextTerm;
                nextTerm = t1 + t2;
                Console.WriteLine("num of term= " + nextTerm);
            }
        }
    }

    class Assign5//Harshad number or not
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum += digit;
                num = num / 10;
            }
            Console.WriteLine(sum);
            if (num % sum == 0)
            {
                Console.WriteLine("Number is Harshad number");
            }
            else
            {
                Console.WriteLine("Not Harshad number");
            }
        }
    }

    class Assign6
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("RedBlue");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Red");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Blue");
                }
                else
                {
                    Console.WriteLine(i);

                }
            }
        }
    }

    class Assign7
    {
        class Order
        {
            public int id;
            public string city;
            public string custname;
            public bool isdelivered;

            public int Id
            {
                set
                {
                    id = value;
                }
                get
                {
                    return id;
                }
            }
            public string City
            {
                set
                {
                    city = value;
                }
                get
                {
                    return city;
                }
            }
            public string Custname
            {
                set
                {
                    custname = value;
                }
                get
                {
                    return custname;
                }
            }
            public bool Isdelivered
            {
                set
                {
                    isdelivered = value;
                }
                get
                {
                    return isdelivered;
                }
            }
        }
        internal class Property
        {
            static void Main(string[] args)
            {
                Order o = new Order();
                o.id = 101;
                o.city = "Pune";
                o.custname = "Priyanka";
                o.isdelivered = true;

                Console.WriteLine("Id=" + o.Id);
                Console.WriteLine("City= " + o.City);
                Console.WriteLine("Custname=" + o.Custname);
                Console.WriteLine("Isdelivered=" + o.Isdelivered);
            }

        }
    }

    class Assign8//Krishnamurthy or not
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int n = num;
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                int fact = 1;
                for (int i = 1; i <= digit; i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                num = num / 10;
            }
            if (sum == n)
            {
                Console.WriteLine("The number is krishnamurthy");
            }
            else
            {
                Console.WriteLine("The number is not krishnamurthy");

            }
        }
    }

}          
        
    
    


