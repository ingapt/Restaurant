using Restaurant.Entities;

namespace Restaurant.Repositories
{
	public class FoodRepository
	{
		private List<Food> Food { get; set; } = new List<Food>();
		private List<string> allLines = new List<string>();

		public FoodRepository() 
		{ 
			ReadDataFile();
			string[] lines = new string[] { };

			foreach (var line in allLines)
			{
				lines = line.Split('.');
				var id = Convert.ToInt32(lines[0].Trim());
				string name = lines[1].Trim();
				var price = Convert.ToDouble(lines[2].Trim());

				Food.Add(new Food(id, name, price));
			}
		}

		private void ReadDataFile()
		{
			using (StreamReader reader = File.OpenText(@"C:\Users\Ingiux\Documents\GitHub\Restaurant\Restaurant\txtfiles\Food.txt"))
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
