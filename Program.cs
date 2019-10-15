using System;

namespace Döngüler14_10_19
{
	class Program
	{

		static int topla(int sayi1, params int[] sayilar)
		{
			int toplam = 0;
			for (int i = 0; i < sayilar.Length; i++)
			{
				toplam += sayilar[i];  //toplam=toplam+sayilar[i];
			}
			return toplam;

		}




		static void Main(string[] args)
		{

			int i, sayi, deger;
			double toplam = 0;
			Console.WriteLine("kaç sayi gireceksiniz");
			deger = Convert.ToInt32(Console.ReadLine());
			for (i = 1; i <= deger; i++)
			{
				Console.WriteLine(i + ".sayiyi giriniz...");
				sayi = Convert.ToInt32(Console.ReadLine());
				toplam += sayi;

			}


			Console.WriteLine(toplam);



			Console.ReadLine();








			//Console.WriteLine("bi metin yaziniz:");
			//string bilgi = Console.ReadLine();
			//yazdir(bilgi);
			//Console.Read();



		}

	}
}
