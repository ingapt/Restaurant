using Restaurant.Classes.Admin;
using Restaurant.Classes.Waitress;
using Restaurant.Entities;
using Restaurant.Repositories;

namespace Restaurant.Classes
{
    public class Unit
	{
		public static void Start()
		{
			MainRepository<Item> foodRepository = new MainRepository<Item>();
			foodRepository.ReadDataFromFile(@"C:\Users\Ingiux\source\repos\Restaurant\Restaurant\Files\food.json");
			MainRepository<Item> drinkRepository = new MainRepository<Item>();
			drinkRepository.ReadDataFromFile(@"C:\Users\Ingiux\source\repos\Restaurant\Restaurant\Files\drinks.json");
			TableRepository.ReadTablesFromFile(@"C:\Users\Ingiux\source\repos\Restaurant\Restaurant\Files\tables.json");
			MainRepository<Item> orderRepository = new MainRepository<Item>();
			bool toDo = true;

			while (toDo)
			{
				Console.Clear();
				Console.WriteLine("Pasirinkite: \n[1] Padavėja(-as) \n[2] Admin \n[3] Baigti darbą");
				var input = Validation.GetValidNumbersFromConsole(3);
				switch (input)
				{
					case 1:
						WaitressInter.Start(foodRepository, drinkRepository, orderRepository);
						break;
					case 2:
						AdminInter.Start(foodRepository, drinkRepository, orderRepository);
						break;
					case 3:
						toDo= false;
						break;
					default:
						break;
				}
			}

		}
	}
}
