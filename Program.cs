using System;
using System.Collections;

namespace Döngüler14_10_19
{

	class Program
	{
		static void Main(string[] args)
		{
			ArrayList cities = new ArrayList();
			cities.Add("Ankara");
			cities.Add("Adana");

			foreach (var city in cities)
			{
				Console.WriteLine(city);
			}

			Console.WriteLine("İstanbul");

			Console.WriteLine(cities[2]);


			
			Console.ReadLine();

		}
	}

	
	
}
