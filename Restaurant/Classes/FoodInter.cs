using Restaurant.Entities;
using Restaurant.Repositories;
using System.Runtime;

namespace Restaurant.Classes
{
	public static class FoodInter
	{
		public static void Start(this MainRepository<Item> foodRepository)
		{
			bool toDo = true;

			while (toDo)
			{
				Console.Clear();
				Console.WriteLine("[1] Patiekalo įtraukimas į sąrašą. \n[2] Patiekalo atnaujimas. \n[3] Patiekalo pašalinimas \n[4] Grįžti atgal");
				var input = Validation.GetValidNumbersFromConsole(4);
				switch (input)
				{
					case 1:
						ItemInsert.FoodItemInsert(foodRepository);
						break;
					case 2:
						ItemUpdate.FoodItemUpdate(foodRepository);
						break;
					case 3:
						ItemDelete.FoodItemDelete(foodRepository);
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
