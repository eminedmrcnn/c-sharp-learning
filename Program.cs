using System;

namespace Döngüler14_10_19
{
	class Program
	{
		static void Main(string[] args)
		{
			

			IWorker[] workers = new IWorker[3]
			{
				new Manager(),
				new Worker(),
				new Robot()
			};

			foreach (var worker in workers)
			{
				worker.Work();
			}

			IEat[] eats = new IEat[]
			{
				new Manager(),
				new  Worker()

			};

			foreach (var eat in eats)
			{
				eat.Eat();  
			}

			Console.ReadLine();
		}


		interface IWorker
		{
			void Work();
		}

		//SOLID, INTERFACE SEGREGATION....
		interface IEat
		{
			void Eat();
		}
		interface ISallary
		{
			void GetSallary();
		}

		class Manager : IWorker, IEat, ISallary
		{
			public void Eat()
			{
				Console.WriteLine("Manager Eat");
			}

			public void GetSallary()
			{
				Console.WriteLine("Manager Salalry");
			}

			public void Work()
			{
				Console.WriteLine("manager Work");
			}
		}

		class Worker : IWorker, IEat, ISallary
		{
			public void Eat()
			{
				Console.WriteLine("worker Eat");
			}

			public void GetSallary()
			{
				Console.WriteLine("worker Sallary");
			}

			void IWorker.Work()
			{
				Console.WriteLine("worker work");
			}
		}

		class Robot : IWorker
		{
			public void Work()
			{
				Console.WriteLine("Robot Work");
			}
		}
	}
		
			




			







		

























	
}
