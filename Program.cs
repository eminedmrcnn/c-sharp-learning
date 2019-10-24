using System;

namespace Döngüler14_10_19
{
	class Program
	{
		static void Main(string[] args)
		{
			Person[] persons = new Person[3]
			{
				new Person{LastName="emine" },
				new Customer{FirstName="sanane" },
				new Student{Departman="okul"},

			
			};

			foreach (var person in persons)
			{
				Console.WriteLine(person.FirstName);
				Console.WriteLine(person.LastName);

			}

			Console.ReadLine();

			
		}
	}

	class Person
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

	}

	class Customer:Person
	{
		public string City { get; set; }
	}

	class Student : Person
	{
		public string Departman { get; set; }
	}
		
			




			







		

























	
}
