using System;

namespace Constructor_Injection
{
	class Program
	{
		static void Main(string[] args)
		{
			EmployeManager employeManager = new EmployeManager( new DatabaseLogger() );
		
			employeManager.Add();
			Console.ReadLine();
		}
	}

	interface ILogger
	{
		void Log();
	}

	class DatabaseLogger:ILogger
	{
		public void Log()
		{
			Console.WriteLine("Logged to DATABASE");
		}
	}


	class EmployeManager                        //EmployeManager Classı içinde Loglama işlemini yapmak için
	{
		private ILogger _logger;			
		public EmployeManager(ILogger logger)		// Construtor Enjection
		{
			_logger = logger;
		}
		public void Add()
		{
			_logger.Log();                        //ILogger çağır
			Console.WriteLine("Added");
		}
	}
}
