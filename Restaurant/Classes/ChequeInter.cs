namespace Restaurant.Classes
{
	public class ChequeInter
	{
		public void Start()
		{ 
			bool toDoChequeInter = true;
			Validation validation = new Validation();

			while (toDoChequeInter)
			{ 
				Console.Clear();
				Console.WriteLine("[1] Čekiai \n[2] Kurti čekį \n[3] Ištrinti čekį \n[4] Grįžti atgal");
				Console.WriteLine();
				Console.WriteLine("Pasirinkite: ");
				var input = validation.GetValidNumbersOfFourFromConsole();
				switch (input)
				{
					case 1:
						Console.WriteLine("Atvaizduojami sukurti čekiai. ");
						Console.ReadKey();
						break;
					case 2:
						Console.WriteLine("Kurti naujus čekius. Nuėjus į kitą menu failą, \npasirinkimo galimybės: 1 - kurti čekį klientui, 2 - kurti čekį restoranui. \nPadaryti galimybę išsiųsti čekius emailu.");
						Console.ReadKey();
						break;
					case 3:
						Console.WriteLine("Ištrinti čekį iš restarono čekių sąrašo. ");
						Console.ReadKey();
						break;
					case 4:
						toDoChequeInter = false;
						break;
					default:
						break;
				}
			}
		}
	}
}
