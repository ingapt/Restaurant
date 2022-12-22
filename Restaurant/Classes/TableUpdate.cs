using Restaurant.Repositories;
using System.IO.Compression;

namespace Restaurant.Classes
{
	public class TableUpdate
	{
		public void UpdateTableInTablesList()
		{
			Validation validation = new Validation();
			
			Console.WriteLine("Pasirinkite: ");
			Console.WriteLine("[1] Atnaujinti staliuko numerį. [2] Atnaujinti staliuko vietų skaičių.");
			var input = validation.GetValidNumbersFromConsole(2);
			switch (input)
			{
				case 1:
					Console.WriteLine("Įveskite staliuko numerį, kurį reikia pakeisti. ");
					var input1 = validation.GetValidIntergerNumber();
					bool goodTable = TableRepository.IsNumberOfTableInTablesList(input1);
					if (goodTable)
					{
						Console.WriteLine("Įveskite naują staliuko numerį.");
						var input2 = validation.GetValidIntergerNumber();
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
					input1 = validation.GetValidIntergerNumber();
					goodTable = TableRepository.IsNumberOfTableInTablesList(input1);
					if (goodTable)
					{
						Console.WriteLine("Įveskite naują staliuko vietų skaičių: ");
						var input2 = validation.GetValidIntergerNumber();
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
