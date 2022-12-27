using Restaurant.Entities;
using Restaurant.Repositories;

namespace Restaurant.Classes
{
	public static class ItemsInter
	{
		public static void Start(this MainRepository<Item> foodRepository, MainRepository<Item> drinkRepository)
		{
			bool toDo = true;

			while (toDo)
			{
				Console.Clear();
				Console.WriteLine("Pasirinkite: ");
				Console.WriteLine("[1] Patiekalai \n[2] Gėrimai \n[3] Grįžti atgal");
				var input = Validation.GetValidNumbersFromConsole(3);
				switch (input)
				{
					case 1:
						FoodInter.Start(foodRepository);
						break;
					case 2:
						DrinkInter.Start(drinkRepository);
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
