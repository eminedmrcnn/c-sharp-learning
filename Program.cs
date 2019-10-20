using System;

namespace Döngüler14_10_19
{
	class Program
	{static void Main(string[] args)
		{
			PersonManager manager = new PersonManager();
			Customer customer = new Customer
			{
				Id = 1,
				FirstName = "Emine",
				LastName = "Demircan",
				Adress = "İstanbul"
			};

			Student student = new Student
			{
				Id = 1,
				FirstName = "Mehmet",
				LastName="Yeşilmen",
				Departman="Computer Sciences"



			};
			manager.Add(customer);
			manager.Add(student);
			Console.ReadLine();
		}

		interface IPerson
		{
			int Id { get; set; }
			string FirstName { get;  set; }
			string LastName { get; set; }
			 
			
		}

		class Customer : IPerson
		{
			public int Id { get; set; }
			public string FirstName { get; set; }
			public string LastName { get; set; }

			public string Adress { get; set; }
		}

		class Student : IPerson
		{
			public int Id { get; set; }
			public string FirstName { get; set; }
			public string LastName { get; set; }
			public string Departman { get; set; }
		}

		class PersonManager
		{
			public void Add(IPerson persom)
			{
				Console.WriteLine(persom.FirstName);
			}
		}
		
			




			







		

























	}
}
