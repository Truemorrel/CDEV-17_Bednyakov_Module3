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
		}
	}
}