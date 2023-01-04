using Restaurant.Entities;
using Restaurant.Repositories;

namespace Restaurant.Classes.Waitress
{
	public static class TablesMakeFreeOrFull
	{
		public static void TableisFree(this int tableNumber)
		{
			Console.WriteLine($" Staliukas numeriu {tableNumber} yra laisvas.");
			Console.WriteLine();
			Console.WriteLine("[1] Pažymėti, kad užimtas");
			var input = Validation.GetValidNumbersFromConsole(1);
			switch (input)
			{
				case 1:
					tableNumber.ChangeTableStatus();
					Console.WriteLine($"{tableNumber} staliukas užimtas. ");
					Console.ReadKey();
					break;
				default:
					break;
			}
		}

		public static void TableIsFull(this MainRepository<Item> foodRepository, MainRepository<Item> drinkRepository, MainRepository<Item> orderRepository, int tableNumber)
		{
			bool full = true;

			while (full)
			{

				Console.Clear();
				Console.WriteLine("Pasirinkite: \n[1] Kurti užsakymą \n[2] Atlaisvinti staliuką \n[3] Grįžti atgal");
				var input = Validation.GetValidNumbersFromConsole(3);
				switch (input) 
				{
					case 1:
						OrderCreate.CreateOrder(foodRepository, drinkRepository, orderRepository, tableNumber);
						break;
					case 2:
						tableNumber.ChangeTableStatus();
						Console.WriteLine("Staliukas atlaisvintas. ");
						Console.ReadKey();
						break;
					case 3:
						full = false;
						break;
					default:
						break;
				}
			}
		}
	}
}
