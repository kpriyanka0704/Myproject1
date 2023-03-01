namespace Myproject1.basic
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome "+name);
            Console.WriteLine("Enter 3 numbers");

            String n = "12";
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Addition " + (a+b+c));
            Console.WriteLine("Substraction " + (a-b-c));
            Console.WriteLine("Multiplication = " + (a * b * c));
            Console.WriteLine("Division = "+ (a / c));
            Console.WriteLine("Modulus= " + (b % c));


        }
    }
}
