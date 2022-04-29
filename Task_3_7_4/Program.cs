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
            byte age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine($"Yuor name is {name} and age is {age}");
            Console.Write("What is your favorite day of week? ");
            Weekdays day;
            bool isCorrect = Weekdays.TryParse(Console.ReadLine(), out day);
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
