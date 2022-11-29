using System;
using System.ComponentModel;
using System.Reflection.Metadata;

namespace İnterfaces
{
	class Program
	{
		static void Main(string[] args)
		{

			ICustomerDal[] customerDals = new ICustomerDal[2]
			{
				new SqlServerCustomerDal(),
				new OracleServerCustomerDal(),
			};

			foreach (var customerDal in customerDals)
			{
				customerDal.Add();
			}




			Console.ReadLine();
		}



		private static void InterfaceIntro()
		{
			PersonManager personmanager = new PersonManager(); // PersonManager CLASS İmplementation

			Customer customer = new Customer
			{
				FirstName = "Batu",
				LastName = "Demirbağ",
				Id = 2,
			};
			Student student = new Student
			{
				FirstName = "Selma",
				LastName = "Demirbağ",
				Id = 2,
				Depertmant = "Computer Science",
			};
			personmanager.add(customer);
			personmanager.add(student);
		}

		interface IPerson
		{
			int Id { get; set; }
			string FirstName { get; set; }
			string LastName { get; set; }
		}

		class Customer:IPerson
		{
			public int Id { get; set; }
			public string FirstName { get; set; }
			public string LastName { get; set; }

			public string Adress { get; set; } //*********
		}
		class Student:IPerson
		{
			public int Id { get; set; }
			public string FirstName { get; set; }
			public string LastName { get; set; }

			public string Depertmant { get; set; } //*********
		}

		class PersonManager                 // PersonManager CLASS
		{
			public void add(IPerson person) // METHOD (Kişiyi veritabanına ekleyecek)
			{
				Console.WriteLine(person.FirstName);
				Console.WriteLine(person.LastName);
				Console.WriteLine(person.Id);
			}
		}
	}
}
