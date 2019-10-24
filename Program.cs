using System;

namespace Döngüler14_10_19
{
	class Program
	{
		static void Main(string[] args)
		{
			SqlServer sqlServer = new SqlServer();
			sqlServer.Add();
			MySqlServer mySqlServer = new MySqlServer();
			mySqlServer.Add();




			Console.ReadLine();

			
		}

	}

	class Database
	{
		public virtual void Add()
		{
			Console.WriteLine("Added by default");
		}
		public virtual void Delete()
		{
			Console.WriteLine("Delete by default.");

		}

	}

	class SqlServer:Database
	{
		public override void Add()
		{
			Console.WriteLine("Added by Sql code..");
			base.Add();  //böyle yazarsak database inde kodunu çalıştırır.
		}
	}

	class MySqlServer:Database
	{

	}


	



















	
}
