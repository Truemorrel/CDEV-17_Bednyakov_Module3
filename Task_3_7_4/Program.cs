using System;

namespace Task_3_7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            var age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine($"Yuor name is {name} and age is {age}");
            Console.Write("What is your favorite day of week? ");
            var day = (Weekdays) int.Parse(Console.ReadLine());
            Console.WriteLine($"Your favorite day is {day}");
        }
        enum Weekdays : byte
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
