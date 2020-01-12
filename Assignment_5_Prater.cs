// Brie Prater
// CIS 243
// Assignment 5.1
// Create a console app that displays a pattern of stars and numbers

using System;

public class Program
{
	const string star = "*";
	const int val = 10;

	public static void Main(string[] args)
	{
		increase();
		decrease();
		Console.ReadLine();
	}

	static public void increase()
	{
		for (int num = 0; num < val; num++)
		{
			for (int pat = 0; pat <= num; pat++)
				Console.Write(star);
			Console.WriteLine("{0}", (num + 1) * 2);
		}

		Console.Write("\n");
	}
	static public void decrease()
	{
		for (int num = val; num > 0; num--)
		{
			for (int pat = 0; pat < num; pat++)
				Console.Write(star);
			Console.WriteLine("{0}", (num + 0) * 2);
		}
		Console.Write("\n");
	}

}
