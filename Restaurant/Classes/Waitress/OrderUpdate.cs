using Restaurant.Entities;

namespace Restaurant.Classes.Waitress
{
	public static class OrderUpdate
	{
		public static void InsertFoodInToTheFoodListOdOrder(this List<Order> orderList, int foodId, int quantity, int orderId)
		{
			foreach (var order in orderList)
			{
				if (order.Id == orderId)
				{
					order.FoodIdList.Add(new OrderItem(foodId, quantity));
				}
			}

		}

		public static void InsertDrinkInToTheDrinksListOdOrder(this List<Order> orderList, int drinkId, int quantity, int orderId)
		{
			foreach (var order in orderList)
			{
				if (order.Id == orderId)
				{
					order.DrinkIdList.Add(new OrderItem(drinkId, quantity));
				}
			}

		}
	}
}
