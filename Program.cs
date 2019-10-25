using System;

namespace Döngüler14_10_19
{
	class Program
	{
		static void Main(string[] args)
		{

			Database database = new Oracle();
			database.Delete();
			database.Add();

			Database database1 = new SqlServer();
			database1.Delete();
			database1.Add();


			Console.ReadLine();

			
		}

	}

	abstract class Database
	{
		public void Add()
		{
			Console.WriteLine("Added by default");
		}

		public abstract void Delete();
		

	}

	class SqlServer : Database
	{
		public override void Delete()
		{
			Console.WriteLine("deleted by SqlServer");
		}
	}

	class Oracle:Database
	{
		public override void Delete()
		{
			Console.WriteLine("Deleted by Oracle");
		}
	}























}
