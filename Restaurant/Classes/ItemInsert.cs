using Restaurant.Entities;
using Restaurant.Repositories;


namespace Restaurant.Classes
{
	public static class ItemInsert
	{
		public static void FoodItemInsert(this MainRepository<Item> foodRepository)
		{
			var food = foodRepository.Retreive();
			Console.WriteLine("Patiekalo įterpimas į Meniu. ");
			Console.WriteLine();
			var lastId = foodRepository.GetLastId(food);
			var id = lastId + 1;
			Console.WriteLine("Įveskite naujo patiekalo pavadinimą.");
			string name = Console.ReadLine();
			Console.WriteLine("Įveskite naujo patiekalo kainą. ");
			var price = Validation.GetValidDoubleNumber();

			food.Add(new Item(id, name, price));
			foodRepository.WriteItemsToJsonFile(food, "food.json");
		}

		public static void DrinkItemInsert(this MainRepository<Item> drinkRepository) 
		{
			var drinks = drinkRepository.Retreive();
			Console.WriteLine("Patiekalo įterpimas į Meniu. ");
			Console.WriteLine();
			var lastId = drinkRepository.GetLastId(drinks);
			var id = lastId + 1;
			Console.WriteLine("Įveskite naujo gėrimo pavadinimą.");
			string name = Console.ReadLine();
			Console.WriteLine("Įveskite naujo gėrimo kainą. ");
			var price = Validation.GetValidDoubleNumber();

			drinks.Add(new Item(id, name, price));
			drinkRepository.WriteItemsToJsonFile(drinks, "drinks.json");

		}
	}
}
