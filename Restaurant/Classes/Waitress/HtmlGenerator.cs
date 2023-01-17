using Restaurant.Entities;
using Restaurant.Repositories;

namespace Restaurant.Classes.Waitress
{
	public static class HtmlGenerator
	{
		public static string GenerateHTMLForClient(this ClientCheque clientCheque)
		{
			string html = "Kliento čekis \n";
			html += $"Užsakymo numeris {clientCheque.OrderId} \n";
			html += "Patiekalų sąrašas: \n";
			foreach (var food in clientCheque.FoodList)
			{
				html += $"Patiekalas: {food.Name} Kiekis: {food.Quantity} Kaina: {food.Price} eur.\n";
			}
			html += "Gėrimų sąrašas \n";
			foreach (var drink in clientCheque.DrinksList)
			{
				html += $"Gėrimas: {drink.Name} Kiekis: {drink.Quantity} Kaina: {drink.Price} eur. \n";
			}
			html += $"Galutinė kaina {clientCheque.AllPrice:0.00} eur.\n";
			html += $"Apsilankymo data {clientCheque.DateTime.ToString("YYYY-MM-DD HH:mm:ss")}\n";
			return html;
		}

		public static string GenerateHTMLForRestaurant(this RestaurantCheque restaurantCheque)
		{
			string html = "Restorano čekis \n";
			html += $"Užsakymo numeris {restaurantCheque.OrderId} \n";
			html += $"Staliuko numeris {restaurantCheque.TableNum} \n";
			var seats = TableRepository.GetTableSeatsNumber(restaurantCheque.TableNum);
			html += $"Vietų skaičius prie staliuko: {seats} \n";
			html += "Patiekalų sąrašas: \n";
			foreach (var food in restaurantCheque.FoodList)
			{
				html += $"Patiekalas: {food.Name} Kiekis: {food.Quantity} Kaina: {food.Price} eur.\n";
			}
			html += "Gėrimų sąrašas: \n";
			foreach (var drink in restaurantCheque.DrinksList)
			{
				html += $"Gėrimas: {drink.Name} Kiekis: {drink.Quantity} Kaina: {drink.Price} eur.\n";
			}
			html += $"Galutinė kaina {restaurantCheque.AllPrice:0.00} eur. \n";
			html += $"Apsilankymo data {restaurantCheque.DateTime.ToString("YYYY-MM-dd HH:mm:ss")} \n";
			return html;

		}
	}
}
