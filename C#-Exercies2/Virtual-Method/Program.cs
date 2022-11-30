using System;

namespace Virtual_Method
{
	class Program
	{
		static void Main(string[] args)
		{
			Sqlserver sqlserver = new Sqlserver();
			sqlserver.Add();
			

			Console.ReadLine();
		}

		class Database
		{
			public virtual void Add()
			{
				Console.WriteLine("Added");
			}

			public virtual void Delete()
			{
				Console.WriteLine("Deleted");
			}
		}

		class Sqlserver : Database          // SQL SERVER İÇİN ADD VE DELETE YAPABİLİRSİN
		{
			public override void Add()
			{
				Console.WriteLine("Virtual ile Babayı ezdim ekrana çıktı");
				//base.Add();
			}
		}
		class MySqlserver : Database          // Mysql SERVER İÇİN ADD VE DELETE YAPABİLİRSİN
		{

		}
	}
}
