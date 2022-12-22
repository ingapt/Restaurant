using Restaurant.Entities;
using Restaurant.Repositories;

namespace Restaurant.Classes
{
	public class TablesInter
	{
		public void Start()
		{
			bool toDoTablesInter = true;
			Validation validation = new Validation();
			TableUpdate tableUpdate = new TableUpdate();
			TableDelete tableDelete = new TableDelete();
			TableInsert tableInsert = new TableInsert();
			TableRepository.CreateTables();

			while (toDoTablesInter)
			{
				Console.Clear();
				Console.WriteLine("[1] Staliukų sąrašas \n[2] Įterpti naują staliuką \n[3] Atnaujinti esamą staliuką  \n[4] Ištrinti esamą staliuką \n[5] Grįžti atgal");
				Console.WriteLine();
				Console.WriteLine("Pasirinkite:");
				var input = validation.GetValidNumbersFromConsole(5);
				switch (input)
				{
					case 1:
						Console.WriteLine("Staliukų sąrašas: ");
						TableRepository.DisplayTables();
						Console.ReadKey();
						break;
					case 2:
						tableInsert.InsertTableInTablesList();
						Console.ReadKey();
						break;
					case 3:
						tableUpdate.UpdateTableInTablesList();
						Console.ReadKey();
						break;
					case 4:
						tableDelete.DeleteTableFromTablesList();
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
