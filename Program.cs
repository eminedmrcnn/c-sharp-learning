using System;

namespace Döngüler14_10_19
{
	class Program
	{static void Main(string[] args)
		{
			MüsteriMüdürü müsteriMüdürü = new MüsteriMüdürü();
			müsteriMüdürü.Ekle();
			müsteriMüdürü.Güncelleme();

			Müsteri müsteri = new Müsteri();
			müsteri.Adi = "Emine";
			müsteri.Id = 1;
			müsteri.Soyadi = "Demircan";
			müsteri.Sehri = "İstanbul";
			

			Console.WriteLine(müsteri.Adi);
			Console.WriteLine(müsteri.Soyadi);
			Console.WriteLine(müsteri.Sehri);
				




			Console.ReadLine();
		}

		
			




			







		

























	}
}
