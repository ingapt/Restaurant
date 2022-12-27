using Restaurant.Entities;
using Restaurant.Repositories;

namespace Restaurant.Classes
{
	public static class ItemDelete
	{
		public static void FoodItemDelete(this MainRepository<Item> foodRepository)
		{
			List<Item> foodList = foodRepository.Retreive();

			Console.Clear();
			Console.WriteLine("Patiekalo ištrinimas iš Meniu. Įveskite patiekalo ID");
			var input = Validation.GetValidIntergerNumber();
			if (foodRepository.IsItemIdInItemsList(input))
			{
				/*if (Aktyvus užsakymas)
				{*/
				foodRepository.DeleteItemFromList(input);
				Console.WriteLine("Patiekalas ištrintas. ");
				Console.ReadKey();

				
				foodRepository.WriteItemsToJsonFile(foodList, "food.json");
				/*}
				else
				{ 
					Console.WriteLine("Ištrinti patiekalo negalima. Vykdomas užsakymas");
				}*/
			}
			else
			{
				Console.WriteLine("Su tokiu ID patiekalo Meniu nėra. ");
			}
		}

		public static void DrinkItemDelete(this MainRepository<Item> drinkRepository)
		{
			List<Item> drinksList = drinkRepository.Retreive();

			Console.Clear();
			Console.WriteLine("Gėrimo ištrinimas iš Meniu. Įveskite Gėrimo ID");
			var input = Validation.GetValidIntergerNumber();
			if (drinkRepository.IsItemIdInItemsList(input))
			{
				/*if (Aktyvus užsakymas)
				{*/
				drinkRepository.DeleteItemFromList(input);
				Console.WriteLine("Gėrimas ištrintas. ");
				Console.ReadKey();


				drinkRepository.WriteItemsToJsonFile(drinksList, "food.json");
				/*}
				else
				{ 
					Console.WriteLine("Ištrinti gėrimo negalima. Vykdomas užsakymas");
				}*/
			}
			else
			{
				Console.WriteLine("Su tokiu ID gėrimo Meniu nėra. ");
			}
		}
	}
}
