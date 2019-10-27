using System;
using System.Collections;
using System.Collections.Generic;

namespace Döngüler14_10_19
{

	class Program
	{
		static void Main(string[] args)
		{

			List<string> cities = new List<string>();
			cities.Add("Ankara");
			cities.Add("Adana");

			Console.WriteLine(cities.Contains("Ankara"));  //Aramak istediğimizi contains içine yazarız..


			foreach (var city in cities)
			{
				Console.WriteLine(city);
			}

			List<Customer> customers = new List<Customer>();
			customers.Add(new Customer { Id = 1, FirstName = "emine" });
			customers.Add(new Customer { Id = 2, FirstName = "Demircan" });

			
			var customer1 = new Customer
			{
				Id = 1, FirstName = "mahmut"
			};

			customers.Add(customer1);
			customers.AddRange(new Customer[2]
			{
				new Customer
				{
					Id=4,
					FirstName="Ali"
				},
				new Customer
				{
					Id=5,
					FirstName="Ayşe"
				},
			});


			Console.WriteLine(customers.Contains(customer1));

			var index = customers.IndexOf(customer1);
			Console.WriteLine("index..{0}", index);

			customers.Insert(0, customer1);


			//customers.Clear();

			

			foreach (var customer in customers)
			{
				Console.WriteLine(customer.FirstName);
			}
			var count = customers.Count;
			Console.WriteLine("Count..{0}", count);



			
			Console.ReadLine();

		}
	}

	class Customer
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
	}

	
	
}
