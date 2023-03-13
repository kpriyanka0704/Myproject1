using Myproject1.Encapsulation;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.ArrayDemo
{

    class Employee
    {
        internal int id;
        internal string name;
        internal int salary;

        public Employee(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public override string ToString()
        {
            return id + " " + name + " " + salary;
        }

    }
    internal class ArrayObject
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[5];
            emp[0] = new Employee(1, "Amit", 25000);
            emp[1] = new Employee(2, "Sumit", 30000);
           emp[2] = new Employee(3, "Priya", 350000);
            emp[3] = new Employee(4, "Riya", 20000);
            emp[4] = new Employee(5, "Siya", 40000);
            

            for(int i=0; i<emp.Length; i++) 
            {
                Console.WriteLine(emp[i]);
            }

            Console.WriteLine("......................");
            foreach(Employee e in emp) 
            {
                if(e.salary > 25000)
                {
                    Console.WriteLine(e);
                }
                
            }

        }
    }

    class Student
    {
        int id;
        string name;
        int[] marks;

        public Student(int id, string name, int[] marks)
        {
            this.id = id;
            this.name = name;
           this.marks = marks;
        }
        public override string ToString()
        {
            return this.id+" "+this.name+" "+string.Join(" ",marks);
        }
    }
    class ObjectArray
    {
        static void Main(string[] args)
        {
            Student[] st = new Student[3];

            for(int i=0;i<st.Length;i++) 
            {
                Console.WriteLine("Enter the id");
                int id=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the marks");
                int[] marks = new int[3];

                float sum = 0;
                for (int j = 0; j < st.Length; j++)
                {
                    sum = sum + marks[j];
                    marks[j]=int.Parse(Console.ReadLine());
                }
                float avg = sum / 3;
                float per = (sum / 300) * 100;
                Console.WriteLine("Average="+avg);
                Console.WriteLine("Percentage="+per);

                st[i]=new Student(id, name, marks);
                
            }
            Console.WriteLine(".......................");
            foreach(Student s in st)
            {
                int per = 0;
                if (per>60)
                Console.WriteLine(s);
            }
        }
    }

}
