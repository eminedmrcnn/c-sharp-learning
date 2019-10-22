using System;
using System.Collections.Generic;
using System.Text;

namespace Döngüler14_10_19
{
	interface ICustomerDal
	{
		void Add();
		void Update();
		void Delete();
	}

	class SqlServerCustomerDal:ICustomerDal
	{
		public void Add()
		{
			Console.WriteLine("Sql Added");
		}
		public void Update()
		{
			Console.WriteLine("Sql Update");
		}
		public void Delete()
		{
			Console.WriteLine("Sql Delete");
		}
	}

	class OracleCustomerDal : ICustomerDal
	{
		public void Add()
		{
			Console.WriteLine("Oracle Added");
		}

		public void Delete()
		{
			Console.WriteLine("Oracle Delete");
		}

		public void Update()
		{
			Console.WriteLine("Oracle Update");
		}
	}

	class CustomerManager
	{
		public void Add(ICustomerDal customerDal)
		{
			customerDal.Add();
		}

		public void Delete(ICustomerDal customerDal)
		{
			customerDal.Delete();
		}
		
	}
}
