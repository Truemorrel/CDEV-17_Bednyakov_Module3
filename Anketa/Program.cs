using System;

namespace Anketa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Jane";
            int age = 27;
            bool petsowner = true;
            string shoesize = "37,5";
            Console.WriteLine("My name is {0}", name);
            Console.WriteLine("My age is {0}", age);
            Console.WriteLine("Do I have a pet? {0}", petsowner);
            Console.WriteLine("My shoe size is {0}", shoesize);
        }
    }
}
