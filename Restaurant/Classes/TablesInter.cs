using Restaurant.Entities;
using Restaurant.Repositories;

namespace Restaurant.Classes
{
	public static class TablesInter
	{
		public static void Start()
		{
			bool toDoTablesInter = true;

			while (toDoTablesInter)
			{
				Console.Clear();
				Console.WriteLine("[1] Staliukų sąrašas \n[2] Įterpti naują staliuką \n[3] Atnaujinti esamą staliuką  \n[4] Ištrinti esamą staliuką \n[5] Grįžti atgal");
				Console.WriteLine();
				Console.WriteLine("Pasirinkite:");
				var input = Validation.GetValidNumbersFromConsole(5);
				switch (input)
				{
					case 1:
						Console.WriteLine("Staliukų sąrašas: ");
						TableRepository.DisplayTables();
						Console.ReadKey();
						break;
					case 2:
						TableInsert.InsertTableInTablesList();
						Console.ReadKey();
						break;
					case 3:
						TableUpdate.UpdateTableInTablesList();
						Console.ReadKey();
						break;
					case 4:
						TableDelete.DeleteTableFromTablesList();
						Console.ReadKey();
						break;
					case 5:
						toDoTablesInter = false;
						break;
					default:
						break;
				}
			}
		}
	}
}
