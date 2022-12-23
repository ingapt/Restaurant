using Restaurant.Repositories;

namespace Restaurant.Classes
{
	public static class OrderCreate
	{
		public static void CreateOrder()
		{
			Console.Clear();
			Console.WriteLine("Įveskite staliuko numerį: ");
			var input = Validation.GetValidIntergerNumber();
			if (TableRepository.IsNumberOfTableInTablesList(input))
			{
				if (TableRepository.TableStatusIsFree(input))
				{
					Console.WriteLine("Rinktis patiekalus ir gėrimus: ");
					//Atkeliauja patiekalų ir gėrimų sąrašai. Kreiptis į MainRepository.

				}
				else
				{
					Console.WriteLine("Šis staliukas jau užimtas");
				}
			}
			else 
			{
				Console.WriteLine("Tokio staliuko numerio nėra. ");
			}
		}
	}
}
