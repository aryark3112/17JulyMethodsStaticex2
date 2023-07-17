using System;


namespace _17JulyMethods
{
    public class OurClass
    {
        //instance Mrthod return type void and no parameters
        public void Display()
        {
            Console.WriteLine("Welcome to Methods !!!");
        }
        //static method
        public static void Welcome()
        {
            Console.WriteLine("Static Method Welcome you!!!");
        }
        //Methods return void & take two parameters
        public void FullName(string fname, string lname)
        {
            Console.WriteLine("Full Name is: " + fname + " " + lname);
        }
        //Methods return double & take two parameters
        public double Add(double n1, double n2)
        { 
        double result;
        result =n1+n2;
            return result;
}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //OurClass obj = new OurClass();
            //obj.Display();

            //OurClass.Welcome();
            OurClass ourClass = new OurClass();
            double num1, num2;
            Console.WriteLine("Enter first Number");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Result after Addition is: \t"+ourClass.Add(num1,num2));
            Console.ReadKey();
        }
    }
}
