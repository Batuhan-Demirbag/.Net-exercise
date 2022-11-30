using System;
using System.Collections.Generic;

namespace List_collection
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Customer> customers = new List<Customer>();
			customers.Add(new Customer{Id = 1, Firstname = "Batu"});
			customers.Add(new Customer { Id = 2, Firstname = "Selma" });

		//	List<Customer> customers = new List<Customer>
		//	{
		//		new Customer { Id = 1, Firstname = "batu" },
		//		new Customer { Id = 2, Firstname = "selma" },
		//	};

			foreach (var customer in customers)
			{
				Console.WriteLine(customer.Firstname);
			}
		}
	}

	class Customer
	{
		public int Id { get; set; }
		public string Firstname { get; set; }
	}
}
