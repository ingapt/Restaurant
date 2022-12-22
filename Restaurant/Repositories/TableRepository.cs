using Restaurant.Entities;
using System.Security.Cryptography.X509Certificates;

namespace Restaurant.Repositories
{
	public static class TableRepository
	{
		public static List<Table> Tables { get; set; } = new List<Table>();

		public static List<Table> CreateTables()
		{ 
			Tables.Add(new Table(1, 5, true));
			Tables.Add(new Table(2, 4, true));
			Tables.Add(new Table(3, 4, true));
			Tables.Add(new Table(4, 2, true));
			Tables.Add(new Table(5, 3, true));

			return Tables;
		}

		public static void DisplayTables()
		{
			
			foreach (var table in Tables)
			{
				if (table.Status == true)
				{
					Console.WriteLine($"{table.Num} {table.SeatsNum} Laisvas");
				}
				else if (table.Status == false)
				{
					Console.WriteLine($"{table.Num} {table.SeatsNum} Užimtas");
				}
				
			}
		}

		public static void InsertInToTableList(int seatsNum)
		{
			var num = Tables.Last().Num;
			num = num + 1;

			Tables.Add(new Table(num, seatsNum, true));

		}

		public static bool IsNumberOfTableInTablesList(int number)
		{
			
			return Tables.Exists(x => x.Num == number);
		
		}
		public static void UpdateTableNumber(int number, int newNumber)
		{
			var table = Tables.SingleOrDefault(x => x.Num == number);
			table.Num = newNumber;
		}

		public static void UpdateSeatsOfTableNumber(int number, int newNumber)
		{
			var table = Tables.SingleOrDefault(x => x.Num == number);
			table.SeatsNum = newNumber;
		}

		public static bool TableStatusIsFree(int number)
		{
			var table = Tables.SingleOrDefault(x => x.Num == number);
			bool tableStatus = table.Status;

			return tableStatus;
		}

		public static void DeleteTableFromList(int number)
		{
			var table = Tables.SingleOrDefault(x => x.Num == number);
			Tables.Remove(table);
		}
	}
}
