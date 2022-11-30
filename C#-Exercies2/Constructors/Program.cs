using System;

namespace Constructors
{
	class Program
	{
		static void Main(string[] args)

		{   //1 yöntem
			Product product = new Product { Id = 5,Name = "Batu"}; 
			//2 yöntem
			Product product2 = new Product(10, "Selma");
			Console.ReadLine();
		}

		class CustomerManager
		{
			private int _count = 15;                    //Hiçbir şey verilmezse 15
			public CustomerManager(int count)
			{
				_count = count;
			}
			public CustomerManager()            //Hiçbir şey verilmezse 15 buraya girer
			{
			}
			public void List()
			{
				Console.WriteLine("Listed {0} items", _count);
			}
		}
	}

	class Product
	{  

		public Product()
		{
			
		}

		//2 yöntem
		private int _id;
		private string _name;
		public Product(int id, string name)
		{
			_id = id;
			_name = name;
		}
		//1 yöntem
		public int Id { get; set; }
		public string Name { get; set; }
	}
}
