using System;

namespace Döngüler14_10_19
{
	class Program
	{
		
			//static void yazdir(string bilgi)
			//{
			//	for (int i = 0; i < 10; i++)
			//		Console.WriteLine(bilgi);
			//}
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
				int sayi;
				Console.WriteLine("kaç sayi:");
				sayi = Convert.ToInt32(Console.ReadLine());

				int[] sayilar1 = new int[sayi - 1];


				for (int i = 0; i < sayi;)
				{
					Console.WriteLine("sayiları giriniz:");

					sayilar1[i] = Convert.ToInt32(Console.ReadLine());
					i++;

				}
				topla(sayi, sayilar1);



				Console.ReadLine();








				//Console.WriteLine("bi metin yaziniz:");
				//string bilgi = Console.ReadLine();
				//yazdir(bilgi);
				//Console.Read();



			}

		
	}
}
