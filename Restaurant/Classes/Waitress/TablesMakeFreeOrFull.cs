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

		public static void TableIsFull(this MainRepository<Item> foodRepository, MainRepository<Item> drinkRepository, MainRepository<Order> orderRepository, int tableNumber)
		{
			bool full = true;

			while (full)
			{
				Console.Clear();
				Console.WriteLine("Pasirinkite: \n[1] Kurti užsakymą \n[2] Papildyti užsakymą \n[3] Kurti čekius \n[4] Atlaisvinti staliuką \n[5] Grįžti atgal");
				var input = Validation.GetValidNumbersFromConsole(5);
				switch (input)
				{
					case 1:
						OrderCreate.CreateOrder(foodRepository, drinkRepository, orderRepository, tableNumber);
						break;
					case 2:
						bool insert = true;

						if (orderRepository.Retreive().Count != 0)
						{
							while (insert)
							{
								Console.Clear();
								Console.WriteLine("Pasirinkite");
								Console.WriteLine("[1] Papildyti patiekalus. \n[2] Papildyti gėrimus \n[3] Grįžti atgal");
								input = Validation.GetValidNumbersFromConsole(3);
								switch (input)
								{
									case 1:
										InsertNewItemsInTheOrder.InsertFoodItemsInTheOrder(foodRepository, orderRepository, tableNumber);
										break;
									case 2:
										InsertNewItemsInTheOrder.InsertDrinksItemsInTheOrder(drinkRepository, orderRepository, tableNumber);
										break;
									case 3:
										insert = false;
										break;
									default:
										break;
								}
							}
						}
						else
						{
							Console.WriteLine("Užsakymų sąrašas tuščias. Pirmiausia reikia sukurti užsakymą. ");
							Console.ReadKey();
						}
						break;
					case 3:
						Console.Clear();
						if (orderRepository.Retreive().Count != 0)
						{
							bool cheque = true;
							while (cheque)
							{
								Console.WriteLine("Pasirinkite: ");
								Console.WriteLine("[1] Čekis klientui. \n[2] Čekis restoranui. \n[3] Grįžti Atgal.");
								input = Validation.GetValidNumbersFromConsole(3);
								switch (input)
								{
									case 1:
										ChequeCreate.CreateChequeForClient(foodRepository, drinkRepository, orderRepository, tableNumber);
										break;
									case 2:
										ChequeCreate.CreateChequeForRestaurant(foodRepository, drinkRepository, orderRepository, tableNumber);
										break;
									case 3:
										cheque = false;
										break;
									default:
										break;
								}
							}
						}
						else
						{
							Console.WriteLine("Čekio kurti negalime. Nėra užsakymų. ");
							Console.ReadKey();
						}
						break;
					case 4:
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
