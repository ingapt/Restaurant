using Restaurant.Entities;
using Restaurant.Repositories;

namespace Restaurant.Classes.Waitress
{
	public static class InsertNewItemsInTheOrder
	{
		public static void InsertFoodItemsInTheOrder(this MainRepository<Item> foodRepository, MainRepository<Order>orderRepository, int tableNum)
		{
			var foodList = foodRepository.Retreive();
			var orderList = orderRepository.Retreive();
			
			Console.Clear();
			DisplayFoodAndDrinksItems.FoodItemsToDisplay(foodList);
			var lastfoodListItem = foodRepository.GetLastId(foodList);
			var orderId = Validation.GetOrderId(orderList, tableNum);
			Console.WriteLine("Pasirinkite id iš patiekalų meniu: ");
			var foodId = Validation.GetValidNumbersFromConsole(lastfoodListItem);
			Console.WriteLine("Įveskite kiekį: ");
			var quantity = Validation.GetValidIntergerNumber();
			OrderUpdate.InsertFoodInToTheFoodListOdOrder(orderList, foodId, quantity, orderId);
			Console.WriteLine("Patiekalas įtrauktas į sąrašą. ");
			Console.ReadKey();
		}

		public static void InsertDrinksItemsInTheOrder(this MainRepository<Item> drinkRepository, MainRepository<Order> orderRepository, int tableNum)
		{
			var drinksList = drinkRepository.Retreive();
			var orderList = orderRepository.Retreive();

			Console.Clear();
			DisplayFoodAndDrinksItems.DrinkItemsToDisplay(drinksList);
			var lastDrinksListItem = drinkRepository.GetLastId(drinksList);
			var orderId = Validation.GetOrderId(orderList, tableNum);
			Console.WriteLine("Pasirinkite id iš gėrimų meniu: ");
			var drinkId = Validation.GetValidNumbersFromConsole(lastDrinksListItem);
			Console.WriteLine("Įveskite kiekį: ");
			var quantity = Validation.GetValidIntergerNumber();
			OrderUpdate.InsertDrinkInToTheDrinksListOdOrder(orderList, drinkId, quantity, orderId);
			Console.WriteLine("Gėrimas įtrauktas į sąrašą. ");
			Console.ReadKey();
		}
	}
}
