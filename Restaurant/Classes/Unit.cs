using Restaurant.Entities;
using Restaurant.Repositories;

namespace Restaurant.Classes
{
	public class Unit
	{
		public static void Start()
		{
			MainRepository<Item> foodRepository = new MainRepository<Item>();
			foodRepository.ReadDataFromFile(@"C:\Users\Ingiux\source\repos\Restaurant\Restaurant\Files\food.json");
			MainRepository<Item> drinkRepository = new MainRepository<Item>();
			drinkRepository.ReadDataFromFile(@"C:\Users\Ingiux\source\repos\Restaurant\Restaurant\Files\drinks.json");
			TableRepository.ReadTablesFromFile(@"C:\Users\Ingiux\source\repos\Restaurant\Restaurant\Files\tables.json");
			bool toDoProgram = true;

			while (toDoProgram)
			{
				Console.Clear();
				Console.WriteLine("[1] Užsakymai \n[2] Čekiai \n[3] Staliukai \n[4] Patiekalai ir gėrimai \n[5] Baigti");
				Console.WriteLine();
				Console.WriteLine("Pasirinkite: ");
				var input = Validation.GetValidNumbersFromConsole(5);
				switch (input)
				{
					case 1:
						OrderInter.Start();
						break;
					case 2:
						ChequeInter.Start();
						break;
					case 3:
						TablesInter.Start();
						break;
					case 4:
						ItemsInter.Start(foodRepository, drinkRepository);
						break;
					case 5:
						toDoProgram = false;
						break;
					default:
						break;
				}
			}
		}
	}
}
