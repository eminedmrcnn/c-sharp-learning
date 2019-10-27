using System;
using System.Collections;
using System.Collections.Generic;

namespace Döngüler14_10_19
{

	class Program
	{
		static void Main(string[] args)
		{


			try
			{
				string[] students = new string[3]
				{
					"emine",
					"onur",
					"öznur"
				};

				students[3] = "ahmet";


			}
			catch (IndexOutOfRangeException exception)
			{
				Console.WriteLine(exception.Message);
			}

			catch (Exception exception)
			{
				Console.WriteLine(exception.Message);

			}

			Console.ReadLine();
		}
	}
}
	
	

