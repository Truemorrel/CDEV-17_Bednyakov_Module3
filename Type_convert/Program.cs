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
			
			bool iscorrect = int.TryParse(Console.ReadLine(), out age);
			Console.WriteLine("Your age is {0} ", age);
			Console.ReadKey();
		}
	}
}