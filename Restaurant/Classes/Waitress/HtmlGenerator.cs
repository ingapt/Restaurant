using Restaurant.Entities;

namespace Restaurant.Classes.Waitress
{
	public static class HtmlGenerator
	{
		public static string GenerateHTMLForClient(this ClientCheque clientCheque)
		{
			Console.Clear();

			string html = "<!doctype html>\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\" xmlns:v=\"urn:schemas-microsoft-com:vml\" xmlns:o=\"urn:schemas-microsoft-com:office:office\">";
			html += "<head><title>Learning how to code an HTML email</title>\r\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\" />\r\n<meta name=\"viewport\" content=\"width=device-width\" />";
			html += "</head>";
			html += "<body>";
			html += "<h3>Kliento čekis</h3>";
			html += "<table cellpadding = '5' cellspacing = '0' style='border: 1px solid #ccc; font-size: 9px; font-family'>";
			html += "<tr>";
			html += "<th style = 'background-color: #eee; border: 1px solid #000'> Užsakymo numeris</th>";
			html += "<th style = 'background-color: #eee; border: 1px solid #000'> Patiekalų sąrašas</th>";
			html += "<th style = 'background-color: #eee; border: 1px solid #000'> Gėrimų sąrašas</th>";
			html += "<th style = 'background-color: #eee; border: 1px solid #000'> Galutinė kaina</th>";
			html += "<th style = 'background-color: #eee; border: 1px solid #000'> Apsilankymo data</th>";
			html += "</tr>";
			html += "<tr style='backgound-color: #fff'>";
			html += "<td style='width: 150px; border = 1px solid #000;'>" + clientCheque.OrderId + "</td>";
			foreach (var food in clientCheque.FoodList)
			{
				html += "<td style='width: 150px; border = 1px solid #000;'>" +$"Patiekalas: {food.Name} Kiekis: {food.Quantity} Kaina: {food.Price} " + "</td>";
			}
			foreach (var drink in clientCheque.DrinksList)
			{
				html += "<td style='width: 150px; border = 1px solid #000;'>" + $"Patiekalas: {drink.Name} Kiekis: {drink.Quantity} Kaina: {drink.Price} " + "</td>";
			}
			html += "<td style='width: 150px; border = 1px solid #000;'>" + clientCheque.AllPrice + "eurų. </td>";
			html += "<td style='width: 150px; border = 1px solid #000;'>" + clientCheque.DateTime + "</td>";

			html += "</tr>";
			html += "</table>";

			html += "<body>";
			html += "</html>";
			return html;
		}
	}
}
