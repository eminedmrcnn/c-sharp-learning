using System;

namespace Döngüler14_10_19
{
	class Program
	{
		static void Main(string[] args)
		{

			CustomerManager customerManager = new CustomerManager();
			customerManager.Logger = new SmsLogger();
			customerManager.Add();


			


			Console.ReadLine();

			
		}

	}

	class CustomerManager
	{
		public ILogger Logger { get; set; }
		public void Add()
		{
			Logger.Log();
			Console.WriteLine("Added!");
			
		}


	}
	class DatabaseLogger:ILogger
	{
		public void Log()
		{
			Console.WriteLine("Logger to database!");
		}
	
	}

	interface ILogger
	{
		void Log();
	}

	class FileLogger:ILogger
	{
		public void Log()
		{
			Console.WriteLine("Logger to File!");
		}
	}

	class SmsLogger : ILogger
	{
		public void Log()
		{
			Console.WriteLine("Logger to Sms!");
		}
	}






















}
