using System;

namespace Type_convert
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int olddata = 6;
			string data = olddata.ToString();

			Console.WriteLine(data);

			Console.WriteLine(olddata);

			Console.ReadKey();

			Console.Write("Enter your age: ");
			int age = int.Parse(Console.ReadLine());
			Console.WriteLine("Your age is {0} ", age);
			Console.ReadKey();
			Console.Write("Enter your age again: ");
			age = 0;
			bool iscorrect = int.TryParse(Console.ReadLine(), out age);
			Console.WriteLine("Your age is {0} ", age);
			Console.ReadKey();
			age = 0;
			Console.Write("Enter your name: ");
			string name = Console.ReadLine();
			Console.Write("Enter your age second time more again: ");
			byte b_age = (byte)int.Parse(Console.ReadLine());
			Console.WriteLine("Your name is {0} and age is {1} ", name, b_age);
			Console.ReadKey();

			Console.Write("Once again enter your name: ");
			string name = Console.ReadLine();
			Console.Write("Enter your age under check overflow control: ");
			byte age = checked((byte)int.Parse(Console.ReadLine()));
			Console.WriteLine("Your name is {0} and age is {1} ", name, age);
			Console.ReadKey();
		}
	}
}