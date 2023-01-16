using Restaurant.Entities;
using Restaurant.Repositories;

namespace Restaurant.Classes.Waitress
{
	public static class ChequeCreate
	{
		public static void CreateChequeForClient(this MainRepository<Item> foodRepository, MainRepository<Item> drinksRepository, MainRepository<Order> orderRepository, int tableNum)
		{
			var foodList = foodRepository.Retreive();
			var drinksList = drinksRepository.Retreive();
			var orderList = orderRepository.Retreive();
			var foodItems = new List<ChequeItem>();
			var drinksItems = new List<ChequeItem>();

			var orderId = Validation.GetOrderId(orderList, tableNum);
			int i = 1;
			double allPrice = 0;

			foreach (var order in orderList)
			{
				if (order.Id == orderId)
				{
					Console.Clear();
					Console.WriteLine("Čekis klientui");
					Console.WriteLine();
					Console.WriteLine($"Užsakymo Numeris: {order.Id}");
					var id = order.Id;
					foreach (var orderfood in order.FoodIdList)
					{
						foreach (var food in foodList)
						{
							if (orderfood.Id == food.Id)
							{
								var foodName = food.Name;
								var price = food.Price * orderfood.Quantity;
								allPrice += price;
								Console.WriteLine($"{i++} {food.Name} {orderfood.Quantity} {food.Price}");
								foodItems.Add(new ChequeItem( foodName, orderfood.Quantity, food.Price));
							}
						}
					}

					foreach (var orderDrink in order.DrinkIdList)
					{
						foreach (var drink in drinksList)
						{
							if (orderDrink.Id == drink.Id)
							{
								var drinkName = drink.Name;
								var price = drink.Price * orderDrink.Quantity;
								allPrice += price;
								Console.WriteLine($"{i++} {drinkName} {orderDrink.Quantity} {drink.Price}");
								drinksItems.Add(new ChequeItem(drinkName, orderDrink.Quantity, drink.Price));
							}
						}
					}

					var priceWithTax = allPrice + (allPrice * 21 / 100);
					Console.WriteLine($"Iš viso mokėti: {priceWithTax} eurų. ");
					Console.WriteLine($"{order.Date}");

					var clientCheque = new ClientCheque(orderId, foodItems, drinksItems, priceWithTax, order.Date);

					Console.WriteLine("Čekis sukurtas. Ar norite išsiųsti klientui? Taip - T, t; Ne - N, n");
					var input = Validation.GetYesOrNoFromConsole();

					if (input == 'T')
					{
						var htmlMessage = HtmlGenerator.GenerateHTMLForClient(clientCheque);
						var emailSender = new EmailSender();
						emailSender.SendEmail("to@example.com", "Apmokėjimo čekis", htmlMessage);
					}
				}
			}
		}

		public static void CreateChequeForRestaurant(this MainRepository<Item> foodRepository, MainRepository<Item> drinksRepository, MainRepository<Order> orderRepository, int tableNum)
		{
			var foodList = foodRepository.Retreive();
			var drinksList = drinksRepository.Retreive();
			var orderList = orderRepository.Retreive();



		}
	}
}
