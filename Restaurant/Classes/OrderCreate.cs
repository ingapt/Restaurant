using Restaurant.Entities;
using Restaurant.Repositories;

namespace Restaurant.Classes
{
	public static class OrderCreate
	{
		public static void CreateOrder(MainRepository<Item> foodRepository, MainRepository<Item> drinkRepository, MainRepository<Item> orderRepository)
		{
			var foodList = foodRepository.Retreive();
			var drinkList = drinkRepository.Retreive();
			var orderList = orderRepository.Retreive();
			var tablesList = TableRepository.Retreive();

			var id = 0;
			Console.Clear();
			Console.WriteLine("Įveskite staliuko numerį: ");
			var tableLastNum = TableRepository.GetLastTableNum();
			var input = Validation.GetValidNumbersFromConsole(tableLastNum);
			if (TableRepository.TableStatusIsFree(input))
			{
				Console.WriteLine("Staliukas laisvas. Ar norite pažymėti, kad užimtas? T, t - taip; N, n - ne.");
				var input1 = Validation.GetYesOrNoFromConsole();
				if (input1.Equals('T'))
				{
					TableRepository.ChangeTableStatus(input);
					Console.WriteLine("Staliukas užimtas.");
					Console.ReadKey();	
				}
				else if(input1.Equals('N'))
				{
					Console.WriteLine("Staliukas liko laisvas. Grįžkite atgal.");
					Console.ReadKey();
				}

				TableRepository.DisplayTables();
				/*	var orderLastId = orderRepository.GetLastId(orderList);
					id = id + orderLastId;
					DisplayFoodAndDrinksItems.FoodItemsToDisplay(foodRepository);
					var lastItemId = foodRepository.GetLastId(foodList);
					Console.WriteLine("Įveskite patieko ID: ");
					var input1 = Validation.GetValidNumbersFromConsole(lastItemId);
					*/
			}
			else
			{
				Console.WriteLine("Staliukas yra užimtas. Pasirinkite: \n[1] Vykdyti užsakymą. \n[2]Atlaisvinti staliuką. ");
				var input2 = Validation.GetValidNumbersFromConsole(2);
				switch (input2)
				{
					case 1:
						// Fromuojamas užsakymas.
						break;
					case 2:
						TableRepository.ChangeTableStatus(input);
						Console.WriteLine("Staliukas atlaisvintas");
						Console.ReadKey();
						break;
					default:
						break;
				}
			}

			TableRepository.DisplayTables();
		}
	}
}
