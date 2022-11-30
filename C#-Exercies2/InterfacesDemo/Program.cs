using System;

namespace InterfacesDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Person[] persons = new Person[3]
			{
				new Customer{FirstName = "Batuhan"},
				new Student{FirstName = "Burak"},
				new Person{FirstName = "Ergün"},  // BABA ANLAM İFADE EDER KALITIMDA (Inheritance)
			};

			foreach (var person in persons)
			{
				Console.WriteLine(person.FirstName);
			}
		}

		class Person
		{
			public int Id { get; set; }
			public string FirstName { get; set; }
		}

		class Customer:Person
		{
			public string City { get; set; }
		}

		class Student:Person
		{
			public string Depertmant { get; set; }
		}
	}
}
