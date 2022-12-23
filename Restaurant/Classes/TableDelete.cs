using Restaurant.Repositories;

namespace Restaurant.Classes
{
	public static class TableDelete
	{
		public static void DeleteTableFromTablesList()
		{ 
			Console.WriteLine("Ištrinti staliuką: ");
			Console.WriteLine();
			Console.WriteLine("Įveskite staliuko numerį, kurį reikia ištrinti. ");
			var input = Validation.GetValidIntergerNumber();
			if (TableRepository.IsNumberOfTableInTablesList(input))
			{
				if (TableRepository.TableStatusIsFree(input))
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
