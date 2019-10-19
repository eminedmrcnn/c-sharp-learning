using System;

namespace Döngüler14_10_19
{
	class Program
	{static void Main(string[] args)
		{




			string cümle = "benim adım emine";
			var result = cümle.Length;  //kaç karakter girdiğimizi belirtir.
			var result2 = cümle.Clone(); //klonluyo..
			cümle = "benim adım emine";
			Console.WriteLine(result);
			bool result3 = cümle.EndsWith("e"); //cümle e ile bitiyor mu..
			bool result4 = cümle.StartsWith("b"); //cümle b ile başlıyor mu..
			var result5 = cümle.IndexOf("adım");   //adım keilmesinin kaçıncı karakterde yazıldığını söyler..

			Console.WriteLine(result2);
			Console.WriteLine(result3);
			Console.WriteLine(result4);
			Console.WriteLine(result5);

			Console.ReadLine();







		}

























	}
}
