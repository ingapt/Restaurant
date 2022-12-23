using Restaurant.Repositories;
using System.IO.Compression;

namespace Restaurant.Classes
{
	public static class TableUpdate
	{
		public static void UpdateTableInTablesList()
		{
			Console.WriteLine("Pasirinkite: ");
			Console.WriteLine("[1] Atnaujinti staliuko numerį. [2] Atnaujinti staliuko vietų skaičių.");
			var input = Validation.GetValidNumbersFromConsole(2);
			switch (input)
			{
				case 1:
					Console.WriteLine("Įveskite staliuko numerį, kurį reikia pakeisti. ");
					var input1 = Validation.GetValidIntergerNumber();
					if (TableRepository.IsNumberOfTableInTablesList(input1))
					{
						Console.WriteLine("Įveskite naują staliuko numerį.");
						var input2 = Validation.GetValidIntergerNumber();
						TableRepository.UpdateTableNumber(input1, input2);
						Console.WriteLine("Staliuko numeris atnaujintas. ");
						Console.ReadKey();
					}
					else
					{
						Console.WriteLine("Tokio staliuko numerio nėra. ");
					}
					break;
				case 2:
					Console.WriteLine("Įveskite staliuko numerį, kurio pasikeitė vietų skaičius. ");
					input1 = Validation.GetValidIntergerNumber();
					if (TableRepository.IsNumberOfTableInTablesList(input1))
					{
						Console.WriteLine("Įveskite naują staliuko vietų skaičių: ");
						var input2 = Validation.GetValidIntergerNumber();
						TableRepository.UpdateSeatsOfTableNumber(input1, input2);
						Console.WriteLine("Staliuko vietų skaičius atnaujintas. ");
						Console.ReadKey();
					}
					else
					{
						Console.WriteLine("Tokio staliuko numerio nėra. ");
					}
					break;
				default:
					break;
			}
		}
	}
}
