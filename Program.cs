using System;

namespace Döngüler14_10_19
{
	class Program
	{

		




		static void Main(string[] args)
		{
			int sayi;

			Console.WriteLine("bi sayi giriniz:");
			sayi = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("..........");

			for(int i=2;i<=sayi;i++)
			{
				int kalan;
				kalan = sayi % i;
				if (kalan == 0)
				{
					Console.WriteLine("bu sayi asal deildir.");
					break;
				}

				else if (i == sayi - 1)
				{
					Console.WriteLine("sayi asaldir.");
					break;
				}


			}
			
			Console.ReadLine();
















		}

		



	}
}
