using System;

namespace Döngüler14_10_19
{

	class Program
	{
		static void Main(string[] args)
		{
			CustomerManager customerManager = new CustomerManager(20);
			customerManager.List();
		}
	}

	class CustomerManager
	{
		private int _count;
		public CustomerManager(int count)
		{
			_count = count;
		}
		public  void List()
		{
			Console.WriteLine("Listed! {0},items", _count);
		}
		public void Add()
		{
			Console.WriteLine("Added!");
		}
	}

	

	
}
