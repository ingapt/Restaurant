using Restaurant.Entities;

namespace Restaurant.Repositories
{
	public class TableRepository
	{
		private List<Table> Tables { get; set; } = new List<Table>();
		private List<string> allLines = new List<string>();

		public TableRepository() 
		{
			ReadDataFile();
			string[] lines = new string[] { };

			foreach (var line in allLines)
			{ 
				lines = line.Split(',');	
				var tableNum = Convert.ToInt32(lines[0].Trim());
				var seatsNum = Convert.ToInt32(lines[1].Trim());
				var tableStatus = Convert.ToBoolean(lines[2].Trim());

				Tables.Add(new Table(tableNum, seatsNum, tableStatus));
			}
		}

		private void ReadDataFile()
		{
			using (StreamReader reader = File.OpenText(@"C:\Users\Ingiux\Documents\GitHub\Restaurant\Restaurant\txtfiles\Tables.txt"))
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
