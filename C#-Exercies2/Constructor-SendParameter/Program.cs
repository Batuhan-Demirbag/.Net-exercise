using System;

namespace Constructor_SendParameter
{
	class Program
	{
		static void Main(string[] args)
		{
			PersonManager personManager = new PersonManager("gönderilen");
			personManager.Add();

			Console.ReadLine();
		}

		class BaseClass
		{
			private string _entity;
			private string entity;

			public BaseClass(string entity)
			{
				this.entity = entity;
			}

			public void BaseClass(string entity)
			{
				_entity = entity;
			}
			public void Message()
			{
				Console.WriteLine("{0} message",_entity);
			}
		}
			class PersonManager:BaseClass          //message() erişir
				{
					public PersonManager(string entity):base(entity)
					{
						
					}

					public void Add()
					{
						Console.WriteLine("Added!");
						Message();
					}
				}
	}
}
