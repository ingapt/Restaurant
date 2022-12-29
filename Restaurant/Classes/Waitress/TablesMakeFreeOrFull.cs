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
			var input = 1.GetValidNumbersFromConsole();
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
				Console.WriteLine("Pasirinkite: ");
				Console.WriteLine($"[1] Kurti naują užsakymą \n[2] Papildyti užsakymą \n[3] Suformuoti Čekius \n[4] Atlaisvinti {tableNumber} staliuką \n[5] Grįžti atgal");
				var input = 5.GetValidNumbersFromConsole();
				switch (input)
				{
					case 1:
						OrderCreate.CreateOrder(foodRepository, drinkRepository, orderRepository, tableNumber);
						break;
					case 2:

						break;
					case 3:
						break;
					case 4:
						// Pabandyti padaryti, kad patikrintų, ar užsakymas įvykdytas :) 
						// Pagal užsakymo numerį, turi būti sukurtas čekis restoranui. Jei čekis sukurtas, galima atlaisvinti staliuką.
						// Arba, jei nepradėtas kurti užsakymas. 
						tableNumber.ChangeTableStatus();
						Console.WriteLine("Staliukas atlaisvintas. ");
						Console.ReadKey();
						break;
					case 5:
						full = false;
						break;
					default:
						break;
				}
			}
		}
	}
}
