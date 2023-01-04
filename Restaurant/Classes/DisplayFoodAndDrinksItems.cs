using Restaurant.Entities;
using Restaurant.Repositories;

namespace Restaurant.Classes
{
	public static class DisplayFoodAndDrinksItems
	{
		public static void FoodItemsToDisplay(this List<Item> foodList)
		{
			Console.WriteLine("Patiekalų Meniu: ");
			Console.WriteLine();
			foreach (var item in foodList)
			{ 
				Console.WriteLine($"{item.Id} {item.Name} {item.Price}eur.");
			}
		}

		public static void DrinkItemsToDisplay(this List<Item> drinksList)
		{ 
			Console.WriteLine("Gėrimų Meniu: ");
			Console.WriteLine();
			foreach (var item in drinksList)
			{
				Console.WriteLine($"{item.Id} {item.Name} {item.Price}eur.");
			}
		}
	}
}
