using System;

namespace Döngüler14_10_19
{

	class Program
	{
		static void Main(string[] args)
		{
			int number1 = 10;
			int number2 = 20;

			number2 = number1;
			number1 = 30;

			Console.WriteLine(number2);

			string[] cities1 = new string[] { "Ankara", "Adana", "Istanbul" };
			string[] cities2 = new string[] { "Bolu", "Bursa", "İzmit" };

			cities2 = cities1;
			cities1[0] = "maras";

			Console.WriteLine(cities2[0]);
			
			Console.ReadLine();

		}
	}

	
	
}
