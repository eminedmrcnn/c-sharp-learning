using System;

namespace Döngüler14_10_19
{

	class Program
	{
		static void Main(string[] args)
		{
			CustomerManager customerManager = new CustomerManager(20);
			customerManager.List();
			Product product = new Product()
			{
				Id = 1,
				Name = "Laptop"
			};
			Product product2 = new Product(2, "Computer");
			


			Console.ReadLine();
			
		}
	}

	class CustomerManager
	{
		private int _count = 15;
		public CustomerManager(int count)
		{
			_count = count;
		}

		public CustomerManager()
		{

		}
		
		public  void List()
		{
			Console.WriteLine("Listed! {0} items", _count);
		}
		public void Add()
		{
			Console.WriteLine("Added!");
		}
	}

	class Product
	{

		public Product()
		{

		}
		int _id;
		string _name;
		public Product(int id,string name)
		
		{
			_id = id;
			_name = name;
		}
		public int Id { get; set; }
		public string Name { get; set; }

		

		
	}

	

	
}
