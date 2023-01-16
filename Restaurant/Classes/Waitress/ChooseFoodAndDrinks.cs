using Restaurant.Entities;

namespace Restaurant.Classes.Waitress
{
	public static class ChooseFoodAndDrinks
	{
		public static List<OrderItem> OrderedFood(this int foodLastId)
		{
			var foodList = new List<OrderItem>();
			bool order = true;
			while (order)
			{
				Console.WriteLine("Pasirinkite patiekalo id ");
				var foodId = Validation.GetValidNumbersFromConsole(foodLastId);
				Console.WriteLine("Įveskite kiekį: ");
				var quantity = Validation.GetValidIntergerNumber();
				foodList.Add(new OrderItem(foodId, quantity));
				Console.WriteLine("Ar įtraukti dar vieną patiekalą? Taip - T/t, Ne - N/n");
				var input = Validation.GetYesOrNoFromConsole();
				if (input == 'N')
				{ 
					order= false;
				}
			}

			return foodList;
		}

		public static List<OrderItem> OrderedDrinks(this int drinksLastId)
		{
			var drinksList = new List<OrderItem>();
			bool order = true;
			while (order)
			{
				Console.WriteLine("Pasirinkite gėrimo id ");
				var drinkId = Validation.GetValidNumbersFromConsole(drinksLastId);
				Console.WriteLine("Įveskite kiekį: ");
				var quantity = Validation.GetValidIntergerNumber();
				drinksList.Add(new OrderItem(drinkId, quantity));
				Console.WriteLine("Ar įtraukti dar vieną gėrimą? Taip - T/t, Ne - N/n");
				var input = Validation.GetYesOrNoFromConsole();
				if (input == 'N')
				{
					order = false;
				}
			}

			return drinksList;
		}
	}
}
