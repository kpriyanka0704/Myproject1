using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.basic
{
    internal class Class6
    {

        static void Main(string[] args)
        {
            int sub1 = 70;
            int sub2 = 80;
            int sub3 = 60;
            int sub4 = 50;
            int sub5 = 50;
            int total = sub1+ sub2 + sub3 + sub4+sub5;
            int avg = total/5;
            int percentage = total / 500 * 100;
            Console.WriteLine("Percentage = " + percentage);
        }
    }
}
