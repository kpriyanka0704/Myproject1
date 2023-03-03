using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Assignments.Assignment_Inheritance
{

    class Nib
    {
        public string pmaterialType;
        public int pwidth;
        public Nib(string pmaterialType, int pwidth)
        {
            this.pmaterialType = pmaterialType;
            this.pwidth = pwidth;
        }
        public void DisplayDetailsOfNib()
        {
            Console.WriteLine(pmaterialType + " " + pwidth);
        }
    }


    class Refill
    {
        public string rinkcolour;
        public int rlength;
        public float rnib;
        public Refill r;

        public Refill(string rinkcolour, int rlength, float rnib)
        {
            this.rinkcolour = rinkcolour;
            this.rlength = rlength;
            this.rnib = rnib;
        }
        public void DisplayDetailsOfRefill()
        {
            Console.WriteLine(rinkcolour + " " + rlength + " " + rnib);
        }
    }
    internal class Inheritance2
    {
        class Pen
        {

            int capLength;
            string brand;
            public Pen(int capLength, string brand)
            {

                this.capLength = capLength;
                this.brand = brand;
            }
            public void ShowPen()
            {
                Console.WriteLine(capLength + " " + brand);
            }


            static void Main(string[] args)
            {
                Nib n = new Nib("Steel", 1);
                Refill r = new Refill("Blue", 12, 0.6f);
                Pen p = new Pen(4, "Reynolds");

                n.DisplayDetailsOfNib();
                r.DisplayDetailsOfRefill();
                p.ShowPen();
            }
        }
    }

    class Inheritance3
    {
        class Vehicle
        {
            int vid;
            string vname;


            public Vehicle(int vid, string vname)
            {
                this.vid = vid;
                this.vname = vname;

            }
            public void DisplayVehile()
            {
                Console.WriteLine(vid + " " + vname);
            }
        }
        class Person
        {
            int id;
            string name;
            Vehicle vvehile;


            public Person(int id, string name, Vehicle vvehile)
            {
                this.id = id;
                this.name = name;
                this.vvehile = vvehile;
            }
            public void ShowPerson()
            {
                Console.WriteLine(id + " " + name);
            }
        }
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle(1010, "Car");
            Person p = new Person(1, "Priya", v);

            v.DisplayVehile();
            p.ShowPerson();
        }
    }


    class Inheritance7
    {
        class Item
        {
            public int itemid;
            public string itemname;
            public int price;

            public Item(int itemid, string itemname, int price)
            {
                this.itemid = itemid;
                this.itemname = itemname;
                this.price = price;
            }
            public void DisplayItem() 
            {
                Console.WriteLine(itemid + " " + itemname);
            }
        }
        class Address
        {
            public string addr1;
            public string city;
            public int pincode;

            public Address(string addr1, string city, int pincode)
            {
                this.addr1 = addr1;
                this.city = city;
                this.pincode = pincode;
            }
            public void DisplayAddress()
            {
                Console.WriteLine(addr1 + " " + city+" "+pincode);
            }
        }
        class Customer
        {
            public int ccustid;
            public string ccustname;
            Address Address;


            public Customer(int ccustid, string ccustname)
            {
                this.ccustid = ccustid;
                this.ccustname = ccustname;
            }
            public void ShowCustomer()
            {
                Console.WriteLine(ccustid+" "+ccustname);
            }

            
            class Order
            {
                string ordered;
                int orderdate;
                Customer custcustomer;
                Item item;

                public Order(string ordered, int orderdate)
                {
                    this.ordered = ordered;
                    this.orderdate = orderdate;
                    
                }

                public  void ShowOrder()
                {
                    Console.WriteLine(ordered+" "+orderdate);
                }
            }
            static void Main(string[] args)
            {
                Item i = new Item(1,"Pizza",150);
                Address a = new Address("Rahatani road","Pune",411017);
                Customer cust= new Customer(11,"Priyanka");
                Order o= new Order("Pizza",03/03/2023);

                i.DisplayItem();
                a.DisplayAddress();
                cust.ShowCustomer();
                o.ShowOrder();
            }
        }
    }
}
