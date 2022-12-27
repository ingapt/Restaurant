using Restaurant.Entities;
using Restaurant.Repositories;

namespace Restaurant.Classes
{
	public static class DrinkInter
	{
		public static void Start(MainRepository<Item> drinkRepository)
		{
			bool toDo = true;

			while (toDo)
			{
				Console.Clear();
				Console.WriteLine("[1] Gėrimo įtraukimas į sąrašą. \n[2] Gėrimo atnaujimas. \n[3] Gėrimo pašalinimas \n[4] Grįžti atgal");
				var input = Validation.GetValidNumbersFromConsole(4);
				switch (input)
				{
					case 1:
						ItemInsert.DrinkItemInsert(drinkRepository);
						break;
					case 2:
						ItemUpdate.DrinkItemUpdate(drinkRepository);
						break;
					case 3:
						ItemDelete.DrinkItemDelete(drinkRepository);
						break;
					case 4:
						toDo = false;
						break;
					default:
						break;
				}

			}

		}
	}
}
