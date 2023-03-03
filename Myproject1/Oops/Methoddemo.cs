using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Oops
{


    internal class Methoddemo
    {
        int num;
        public void GetDigit(int digit)
        {

            num = digit;
        }

        public void PutDigit()
        {
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine( );
                }
            }
        }

        static void Main(string[] args)
        {
            Methoddemo m = new Methoddemo();
            m.GetDigit(116);
            m.PutDigit();


        }
    }

    class Prime
    {
        int num;
        int i ;
        public void GetDigit(int pnum ,int pi)
        {
            num = pnum;
            i = pi;
        }

        public void CheckDigit()
        {
            while (num < 0)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("num is prime");
                }

                else
                {
                    Console.WriteLine("num is not prime");
                }
            }
        }
        public void DisplayDigit()
        {
            Console.WriteLine(num+" "+i);
        }

        static void Main(string[] args)
        {
          Prime p = new Prime();
            p.GetDigit(4,2);
            p.CheckDigit();
            p.DisplayDigit();
        }

    }

    
}
