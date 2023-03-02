using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Encapsulation
{

    class Account
    {
        int accountno;
        int age;
        string name;
        double balance;

        public int Accountno
        {
            set 
            { 
               accountno= value;
            }
            get
            { 
               return accountno;
            }
        }
        public string Name
        { 
            set 
            { 
               name=value; 
            } 
            get 
            {
              return name;
            } 
        }

        public double Balance
        {
            set 
            {
                balance= value;
            }
            get 
            {
                return balance;
            }
        }

        public int Age
        {
            set
            { 
                age= value; 
            }
            get
            {
                return age;
            }
        }


    }
    internal class Encapsulationdemo
    {
        static void Main(string[] args)
        {
            Account a = new Account();
            a.Accountno= 1;
            a.Name = "Priyanka";
            a.Balance= 25000;
            a.Age = 25;

            Console.WriteLine("Accountno= "+a.Accountno); 
            Console.WriteLine("Name= "+a.Name);
            Console.WriteLine("Balance= "+a.Balance);
            Console.WriteLine("Age= "+a.Age);


        }
    }

    class Student
    {
        int id;
        string name;
        int passmarks;

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
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public int Passmarks
        {
            set
            {
                passmarks = value;
            }
            get
            {
                return passmarks;
            }
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s.id = 1;
            s.name = "priya";
            s.passmarks = 80;

            Console.WriteLine("Id= "+s.id);
            Console.WriteLine("Name= "+s.Name);
            Console.WriteLine("Passmarks= " + s.Passmarks);
        }
    }
}
