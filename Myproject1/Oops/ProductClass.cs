using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Myproject1.Oops
{
    internal class ProductClass
    {

        string name;
        double price;
        int quantity;
       


        public void AcceptDetails(string ename, double eprice, int equantity)
        {
            name = ename;
            price = eprice;
            quantity = equantity;
           
        }
       

        public void CalculateBill() 
        {
            int Totalbill = 0;
           
            if (quantity > 0) 
            {
              
                Console.WriteLine("Calculate total bill");
            }
            else 
            {
                Console.WriteLine("error");
            }
        }
        public void DisplayDitails()
        {
            Console.WriteLine(name+" "+price+" "+quantity);
        }

        static void Main(string[] args)
        {
            ProductClass p = new ProductClass();
           p.AcceptDetails("pen",45,0);
            p.CalculateBill();
            p.DisplayDitails();
          

        }
    }

    class Factor
    {
        int num;
            public void GetDigit(int digit)
        {
            num=digit;
        }
        public void PutDigit()
        {
            for(int i=1;i<=num;i++)
            {
                if(num%i==0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine( );
        }
        static void Main(string[] args)
        {
            Factor f= new Factor();
            f.GetDigit(4);
            f.PutDigit();

        }
    }

    class Student
    {
        int id;
        string name;
        int marks;
        int m1, m2, m3;
        public void AcceptDetails(int eid, string ename, int emk1,int emk2,int emk3)
        {
            id = eid;
            name = ename;
            
           
            int m1, m2, m3;
            int total;
            

        }
        public void DisplayDetails()
        {
            Console.WriteLine(id + " " + name + " " + m1+" "+m2+" "+m3);

        }

        public void calculatePercentage()
        {
            double avg;
            int total;int per;


            total = m1 + m2 + m3;
            avg = total / 3;
           per= (total * 100)/300;
            
        }
        public void Display()
        {
            Console.WriteLine("id\t name\t m1\t m2\t m3\t percentage\t");
            Console.WriteLine(id+" "+name+" "+m1+" "+m2+" "+m3);
        }
            
          static void Main(string[] args)
        {
            Student s = new Student();
            s.AcceptDetails(1,"Riya",60,40,50);
            s.calculatePercentage();
            s.DisplayDetails();

           
        }

    }

    class student1
    {
         int id;
         string name;
        int m1,m2,m3;
        int percentage;

        public void Accept(int sid, string sname, int mk1, int mk2, int mk3)
        {   id = sid; 
            name = sname;
           m1=mk1; 
           m2=mk2;
           m3=mk3;
        }
        public void calculatePercentage() 
        {
           percentage= ((m1 + m2 + m3) * 100) / 300;
        }
        public void Display()
        {
            Console.WriteLine(id+" "+name+" "+m1+" "+m2+" "+m3+" "+percentage);
        }

        static void Main(string[] args)
        {
            Student s=new Student();
            s.AcceptDetails(1, " priya", 56, 78, 89);
            s.calculatePercentage();
            s.DisplayDetails();
        }

    }   
    
}

