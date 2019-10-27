using System;
using System.Collections;
using System.Collections.Generic;

namespace Döngüler14_10_19
{

	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("book", "kitap");
			dictionary.Add("table", "tablo");
			dictionary.Add("computer", "bilgisayar");
			dictionary.Add("door", "kapı");

			//Console.WriteLine(dictionary["door"]);

			foreach (var item in dictionary)
			{
				Console.WriteLine(item.Value);
			}

			Console.WriteLine(dictionary.ContainsKey("glass"));
			Console.WriteLine(dictionary.ContainsKey("book"));


			Console.ReadLine();
		}
	}
}
	
	

