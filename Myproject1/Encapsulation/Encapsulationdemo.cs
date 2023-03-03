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
                accountno = value;
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
                name = value;
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
                balance = value;
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
                age = value;
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
            a.Accountno = 1;
            a.Name = "Priyanka";
            a.Balance = 25000;
            a.Age = 25;

            Console.WriteLine("Accountno= " + a.Accountno);
            Console.WriteLine("Name= " + a.Name);
            Console.WriteLine("Balance= " + a.Balance);
            Console.WriteLine("Age= " + a.Age);


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

            Console.WriteLine("Id= " + s.id);
            Console.WriteLine("Name= " + s.Name);
            Console.WriteLine("Passmarks= " + s.Passmarks);
        }
    }

    class Hotel
    {
        int id;
        string name;
        string location;
        double rating;
        bool isonlineorderavailable;
        string seatingcapacity;
        string paymenttype;

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
        public string Location
        {
            set
            {
                location = value;
            }
            get
            {
                return location;
            }
        }
        public double Rating
        {
            set
            {
                rating = value;
            }
            get
            {
                return rating;
            }
        }
        public bool Isonlineorderavailable
        {
            set
            {
                isonlineorderavailable = value;
            }
            get
            {
                return isonlineorderavailable;
            }
        }
        public string SeatingCapacity
        {
            set
            {
                seatingcapacity = value;
            }
            get
            {
                return seatingcapacity;
            }
        }
        public string Paymenttype
        {
            set
            {
                paymenttype = value;
            }
            get
            {
                return paymenttype;
            }
        }
    }
    internal class Property
    {
        static void Main(string[] args)
        {
            Hotel h = new Hotel();
            h.Id = 101;
            h.Name = "Hotel City Pride";
            h.Location = "Pune";
            h.Rating = 4;
            h.Isonlineorderavailable = true;
            h.SeatingCapacity = "fifty";
            h.Paymenttype = "CreditCard";

            Console.WriteLine("Id= " + h.Id);
            Console.WriteLine("Name= " + h.Name);
            Console.WriteLine("Location= " + h.Location);
            Console.WriteLine("Rating=" + h.Rating);
            Console.WriteLine("IsOnlineOrderAvailable= " + h.Isonlineorderavailable);
            Console.WriteLine("SeatingCapacity= " + h.SeatingCapacity);
            Console.WriteLine("PaymentType= " + h.Paymenttype);

        }
    }
}           
                
        

    
       

    


