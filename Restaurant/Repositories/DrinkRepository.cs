using Restaurant.Entities;

namespace Restaurant.Repositories
{
	public class DrinkRepository
	{
		private List<Drink> Drinks { get; set; } = new List<Drink>();
		private List<string> allLines = new List<string>();
		public DrinkRepository() 
		{ 
			ReadDataFile();
			string[] lines = new string[] { };

			foreach (var line in allLines)
			{ 
				lines = line.Split('.');
				var id = Convert.ToInt32(lines[0].Trim());
				var name = lines[1].Trim();
				var price = Convert.ToDouble(lines[2].Trim());

				Drinks.Add(new Drink(id, name, price));
			}
		}

		private void ReadDataFile()
		{
			using (StreamReader reader = File.OpenText(@"C:\Users\Ingiux\Documents\GitHub\Restaurant\Restaurant\txtfiles\Drinks.txt"))
			{
				string line = "";
				while ((line = reader.ReadLine()) != null)
				{
					allLines.Add(line);
				}
			}
		}
	}
}
