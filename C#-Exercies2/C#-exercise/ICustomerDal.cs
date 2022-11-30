using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaces
{
	interface ICustomerDal							//İnterface Kullanarak farklı iki veritabanında ORACLE VE SQLSERVERDA İŞLEMLER YAPARIM
	{
		void Add();
		void Delete();
	}

	class SqlServerCustomerDal:ICustomerDal
	{
		public void Add()
		{
			Console.WriteLine("Sql Added");
		}
		public void Delete()
		{
			Console.WriteLine("Sql Deleted");
		}
	}
	class OracleServerCustomerDal : ICustomerDal
	{
		public void Add()
		{
			Console.WriteLine("Oracle Added");
		}

		public void Delete()
		{
			Console.WriteLine("Oracle Deleted");
		}
	}

	class CutomerManager		
	{
		public void Add(ICustomerDal customerDal)
		{
			customerDal.Add();
			customerDal.Delete();
		}
	}
}
