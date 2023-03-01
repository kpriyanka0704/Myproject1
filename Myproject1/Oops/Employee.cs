using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Oops
{
    internal class Employee
    {
        static void Main(string[] args)
        {
            int id;
            float salary;
            String Name;

            Console.WriteLine("Enter the employee id");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the employee name");
            string name = (Console.ReadLine());
            Console.WriteLine("Enter the employee salary");
            float sal = 1; 

            Console.WriteLine("ID="+i);
            Console.WriteLine("Name=" + name);
            Console.WriteLine("Salary="+sal);

        }

    }


    class car 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name ");
            int name=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the colour");
            int color=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price");
            int price=int.Parse(Console.ReadLine());
        }
              
    }

}             
            
               
                
                 
            
            
        
    

