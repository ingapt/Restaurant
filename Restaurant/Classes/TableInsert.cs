using Restaurant.Repositories;

namespace Restaurant.Classes
{
	public class TableInsert
	{
		public void InsertTableInTablesList()
		{
			Validation validation= new Validation();

			Console.WriteLine("Staliukų įterpimas į sąrašą. ");
			Console.WriteLine();
			Console.WriteLine("Įveskite naujojo staliuko vietų skaičių");
			var input = validation.GetValidIntergerNumber();
			TableRepository.InsertInToTableList(input);
			Console.WriteLine("Naujas staliukas įvestas. ");
		}
	}
}
