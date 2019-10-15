using System;

namespace Döngüler14_10_19
{
	class Program
	{
		static void Main(string[] args)
		{
			//int i;
			//for (i=0;i<100;i+=2)
			//{
			//	Console.WriteLine(i);
			//}
			//Console.WriteLine("bitis");
			//Console.ReadLine();



			//int sayi=100;
			//while (sayi >= 0)
			//{
			//	Console.WriteLine(sayi);
			//	sayi--;

			//}
			//Console.WriteLine("bitis {0}",sayi);
			//Console.ReadLine();



			//int sayi = 10;
			//do 
			//{
			//	Console.WriteLine(sayi);
			//	sayi--;
			//} while (sayi>=0);


			string[] ögrenciler = new string[3] { "ahmet", "mehmet", "emine" };
			foreach(var ögrenci in ögrenciler)
			{
				Console.WriteLine(ögrenci);
			}
			Console.ReadLine();

		}
	}
}
