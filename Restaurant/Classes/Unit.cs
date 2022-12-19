namespace Restaurant.Classes
{
	public class Unit
	{
		public void Start()
		{
			bool toDoProgram = true;
			Validation validation = new Validation();

			while (toDoProgram)
			{
				Console.Clear();
				Console.WriteLine("[1] Staliukai \n[2] Užsakymai \n[3] Čekiai \n[4] Baigti");
				Console.WriteLine();
				Console.WriteLine("Pasirinkite: ");
				var choise = validation.GetValidNumbersOfFourFromConsole();
				switch (choise)
				{
					case 1:
						
						var tablesInter = new TablesInter();
						tablesInter.Start();
						break;
					case 2:
						var orderInter = new OrderInter();
						orderInter.Start();
						break;
					case 3:
						var chequeInter = new ChequeInter();
						chequeInter.Start();
						break;
					case 4:
						toDoProgram= false;
						break;
					default:
						break;
				}
			}
		}
	}
}
