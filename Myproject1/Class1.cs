using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1
{
    internal class Class1//Average of odd digits from numbers
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;
            while (num > 0)
            {

                int digit = num % 10;
                if (digit % 2 == 1)
                {
                    sum = sum + digit;
                    count++;
                }
                num = num / 10;
            }
            double avg = sum / count;
            Console.WriteLine("Avg is= " + avg);
        }
    }
}

        

       
            
            

            
            
            
            
                
        
    

