using Restaurant.Entities;
using Restaurant.Repositories;

namespace Restaurant.Classes
{
	public static class OrderInter
	{
		public static void Start(this MainRepository<Item> foodRepository, MainRepository<Item> drinkRepository, MainRepository<Item> orderRepository)
		{
			bool toDoOrderInter = true;
			
			while (toDoOrderInter)
			{
				Console.Clear();
				Console.WriteLine("[1] Kurti užsakymą \n[2] Atnaujinti užsakymą. \n[3] Naikinti užsakymą \n[4] Peržiūrėti užsakymą \n[5] Visi įvykdyti užsakymai\n[6] Grįžti atgal");
				var input = Validation.GetValidNumbersFromConsole(6);
				switch (input)
				{
					case 1:
						Console.WriteLine("Kurti užsakymą: ");
						OrderCreate.CreateOrder(foodRepository, drinkRepository, orderRepository);
						Console.ReadKey();
						break;
					case 2:
						Console.WriteLine("Atnaujinti užsakymą; ");
						Console.ReadKey();
						break;
					case 3:
						Console.WriteLine("Naikinami sukurti, bet nevykdomi užsakymai. T.y. staliuko atlaisvinimas ir užsakymo ištrinimas iš sąrašo. ");
						Console.ReadKey();
						break;
					case 4:
						Console.WriteLine("Peržiūrėti užsakymą");
						Console.ReadKey();
						break;
					case 5:
						Console.WriteLine("Visi įvykdyti užsakymai. ");
						break;
					case 6:
						toDoOrderInter= false;
						break;
					default: 
						break;

				}
			}
		}
	}
}
