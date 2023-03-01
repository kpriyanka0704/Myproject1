using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.basic
{
    internal class Class3
    {

        static void Main(string[] args)
        {
            int l1 = 10;
            int l2 = 20;
            int result = l1 * l2;
            Console.WriteLine("Multiplication =" + result);

        }
    }

    class A
    {

        static void Main(string[] args)
        {
            int sub1 = 10;
            int sub2 = 20;
            int sub3 = 30;
            int result = sub1 + sub2 + sub3 / 3;
            Console.WriteLine("Average of 3 subject marks =" + result);
        }

    }
        
}
