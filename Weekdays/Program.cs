using System;

class MainClass
{
	public static void Main(string[] args)
	{
		DaysOfWeek MyFavoriteDay;

		MyFavoriteDay = DaysOfWeek.Friday;

		Console.WriteLine(MyFavoriteDay);
		Console.ReadKey();
	}
}

enum DaysOfWeek : byte
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}