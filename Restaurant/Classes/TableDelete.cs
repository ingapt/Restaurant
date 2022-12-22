using Restaurant.Repositories;

namespace Restaurant.Classes
{
	public class TableDelete
	{
		public void DeleteTableFromTablesList()
		{ 
			Validation validation = new Validation();

			Console.WriteLine("Ištrinti staliuką: ");
			Console.WriteLine();
			Console.WriteLine("Įveskite staliuko numerį, kurį reikia ištrinti. ");
			var input = validation.GetValidIntergerNumber();
			bool goodTable = TableRepository.IsNumberOfTableInTablesList(input);
			if (goodTable)
			{
				bool goodTableStatus = TableRepository.TableStatusIsFree(input);
				if (goodTableStatus)
				{
					TableRepository.DeleteTableFromList(input);
					Console.WriteLine("Staliukas ištrintas. ");
					Console.ReadKey();
				}
				else
				{
					Console.WriteLine("Staliuko ištrinti negalima. Vis dar vykdomas užsakymas.");
				}
			}
			else
			{
				Console.WriteLine("Staliuko su tokiu numeriu nėra. ");
				Console.ReadKey();
			}
		}
	}
}
