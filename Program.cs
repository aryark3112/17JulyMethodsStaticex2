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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            OurClass obj = new OurClass();
            obj.Display();
            OurClass.Welcome();
            Console.ReadKey();
        }
    }
}
