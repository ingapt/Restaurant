using Restaurant.Entities;
using Restaurant.Repositories;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.Classes.Waitress
{
	public static class OrderCreate
	{
		public static void CreateOrder(this MainRepository<Item> foodRepository, MainRepository<Item> drinkRepository, MainRepository<Order> orderRepository, int tableNumber)
		{
			var foodList = foodRepository.Retreive();
			var drinksList = drinkRepository.Retreive();
			var orderList = orderRepository.Retreive();

			if ( orderList.Count == 0)
			{
				
				Console.Clear();
				Console.WriteLine($"Staliuko numeris: {tableNumber}");
				Console.WriteLine();

				var orderId = 1;

				DisplayFoodAndDrinksItems.FoodItemsToDisplay(foodList);
				Console.WriteLine();
				var orderedFood = ChooseFoodAndDrinks.OrderedFood(foodRepository.GetLastId(foodList));


				DisplayFoodAndDrinksItems.DrinkItemsToDisplay(drinksList);
				Console.WriteLine();
				var orderedDrinks = ChooseFoodAndDrinks.OrderedDrinks(drinkRepository.GetLastId(drinksList));


				var dateTime = DateTime.Today;

				orderList.Add(new Order(orderId, tableNumber, orderedFood, orderedDrinks, dateTime));
				Console.WriteLine("Užsakymas sukurtas.");
				Console.ReadKey();
			}
			else
			{
				Console.Clear();
				Console.WriteLine($"Staliuko numeris: {tableNumber}");
				Console.WriteLine();

				var orderLastId = orderRepository.GetLastId(orderList);
				var orderId = orderLastId + 1;

				DisplayFoodAndDrinksItems.FoodItemsToDisplay(foodList);
				Console.WriteLine();
				var orderedFood = ChooseFoodAndDrinks.OrderedFood(foodRepository.GetLastId(foodList));


				DisplayFoodAndDrinksItems.DrinkItemsToDisplay(drinksList);
				Console.WriteLine();
				var orderedDrinks = ChooseFoodAndDrinks.OrderedDrinks(drinkRepository.GetLastId(drinksList));


				var dateTime = DateTime.Today;

				orderList.Add(new Order(orderId, tableNumber, orderedFood, orderedDrinks, dateTime));
				Console.WriteLine("Užsakymas sukurtas.");
				Console.ReadKey();
			}
		}
	}
}

