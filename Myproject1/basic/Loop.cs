using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.basic
{
    internal class Loop
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 4)
            {
                Console.WriteLine("Hello world");
                i++;
            }
            Console.WriteLine(i);
            for (int j = 1; j <= 4; j++)
            {
                Console.WriteLine("Welcome");
            }

            int k = 1;
            do
            {
                Console.WriteLine("Happy morning");
                k++;
            }while(k <= 4);

         }
    }

}


        
    

