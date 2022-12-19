namespace Restaurant.Classes
{
	public class OrderInter
	{
		public void Start()
		{
			bool toDoOrderInter = true;
			Validation validation = new Validation();

			while (toDoOrderInter)
			{
				Console.Clear();
				Console.WriteLine("[1] Užsakymų informacija \n[2] Kurti užsakymą \n[3] Naikinti užsakymą \n[4] Grįžti atgal");
				var input = validation.GetValidNumbersOfFourFromConsole();
				switch (input)
				{
					case 1:
						Console.WriteLine("Čia bus informacija apie esamus užsakymus");
						Console.ReadKey();
						break;
					case 2:
						Console.WriteLine("Čia bus kuriami nauji užsakymai");
						Console.ReadKey();
						break;
					case 3:
						Console.WriteLine("Naikinami sukurti, bet nevykdomi užsakymai. T.y. staliuko atlaisvinimas ir užsakymo ištrinimas iš sąrašo. ");
						Console.ReadKey();
						break;
					case 4:
						toDoOrderInter= false;
						break;
					default: 
						break;

				}
			}
		}
	}
}
