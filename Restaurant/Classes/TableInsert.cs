using Restaurant.Repositories;

namespace Restaurant.Classes
{
	public static class TableInsert
	{
		public static void InsertTableInTablesList()
		{
			Console.WriteLine("Staliukų įterpimas į sąrašą. ");
			Console.WriteLine();
			Console.WriteLine("Įveskite naujojo staliuko vietų skaičių");
			var input = Validation.GetValidIntergerNumber();
			TableRepository.InsertInToTableList(input);
			TableRepository.WriteDataToJsonFile();
			Console.WriteLine("Naujas staliukas įvestas. ");
		}
	}
}
