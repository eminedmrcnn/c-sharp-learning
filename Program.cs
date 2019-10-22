using System;

namespace Döngüler14_10_19
{
	class Program
	{ static void Main(string[] args)
		{
			ICustomerDal[] customerDals = new ICustomerDal[2]
			{
				new SqlServerCustomerDal(),
				new OracleCustomerDal()

		    };
			foreach(var customerDal in customerDals)
			{
				customerDal.Add();
			}


			Console.ReadLine();
		}

		interface IPerson       //interface hiçbir zaman new lenemez.
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
