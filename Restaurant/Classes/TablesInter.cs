namespace Restaurant.Classes
{
	public class TablesInter
	{
		public void Start()
		{
			bool toDoTablesInter = true;
			Validation validation = new Validation();

			while (toDoTablesInter)
			{
				Console.Clear();
				Console.WriteLine("[1] Staliukų sąrašas \n[2] Sukurti naują staliuką \n[3] Ištrinti esamą staliuką \n[4] Grįžti atgal");
				Console.WriteLine();
				Console.WriteLine("Pasirinkite:");
				var input = validation.GetValidNumbersOfFourFromConsole();
				switch (input)
				{
					case 1:
						Console.WriteLine("Čia spausdinamas staliukų sąrašas");
						Console.ReadKey();
						break;
					case 2:
						Console.WriteLine("Čia naujų staliukų įterpimas");
						Console.ReadKey();
						break;
					case 3:
						Console.WriteLine("Čia esamų staliukų ištrinimas");
						Console.ReadKey();
						break;
					case 4:
						toDoTablesInter = false;
						break;
					default:
						break;
				}
			}
		}
	}
}
