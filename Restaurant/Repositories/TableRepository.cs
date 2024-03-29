﻿using Restaurant.Entities;
using System.Text.Json;

namespace Restaurant.Repositories
{
	public static class TableRepository
	{
		public static List<Table> Tables { get; set; } = new List<Table>();

		public static List<Table> ReadTablesFromFile(string path)
		{
			var itemList = new List<Table>();

			using (StreamReader reader = new StreamReader(path))
			{
				string json = reader.ReadToEnd();
				itemList = JsonSerializer.Deserialize<List<Table>>(json);

			}

			if (itemList != null && itemList.Count > 0)
			{
				foreach (var item in itemList)
				{
					Tables.Add(item);
				}
			}

			return Tables;
		}

		public static List<Table> Retreive()
		{
			return Tables;
		}

		public static int GetLastTableNum()
		{
			return Tables.Last().Num;
			
		}

		public static int GetTableSeatsNumber(this int tableNum)
		{
			var table = Tables.SingleOrDefault(x => x.Num == tableNum);
			
			return table.SeatsNum;
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

		public static void DisplayTablesWithoutSeats()
		{
			foreach (var table in Tables)
			{
				if (table.Status == true)
				{
					Console.WriteLine($"{table.Num} Laisvas");
				}
				else if (table.Status == false)
				{
					Console.WriteLine($"{table.Num} Užimtas");
				}

			}
		}

		public static void InsertInToTableList(this int seatsNum)
		{
			var num = Tables.Last().Num;
			num = num + 1;

			Tables.Add(new Table(num, seatsNum, true));

		}

		public static bool IsNumberOfTableInTablesList(this int number)
		{

			return Tables.Exists(x => x.Num == number);

		}
		public static void UpdateTableNumber(this int number, int newNumber)
		{
			var table = Tables.SingleOrDefault(x => x.Num == number);
			table.Num = newNumber;
		}

		public static void UpdateSeatsOfTableNumber(this int number, int newNumber)
		{
			var table = Tables.SingleOrDefault(x => x.Num == number);
			table.SeatsNum = newNumber;
		}

		public static bool TableStatusIsFree(this int tableNumber)
		{
			var table = Tables.SingleOrDefault(x => x.Num == tableNumber);
			bool tableStatus = table.Status;

			return tableStatus;
		}
		public static void ChangeTableStatus(this int tableNumber)
		{

			foreach (var table in Tables)
			{
				var status = false;
				if (table.Num == tableNumber)
				{
					if (table.Status == true)
					{
						table.Status = false;
					}
					else if (table.Status == false)
					{
						table.Status = true;
					}
				}
			}
		}

		public static void DeleteTableFromList(this int number)
		{
			var table = Tables.SingleOrDefault(x => x.Num == number);
			Tables.Remove(table);
		}

		public static bool IsAnyTableFalse()
		{
			return Tables.Exists(x => x.Status == true);
		}

		public static void WriteDataToJsonFile()
		{
			var listToJson = JsonSerializer.Serialize(Tables);
			var path = @"C:\Users\Ingiux\source\repos\Restaurant\Restaurant\Files\tables.json";
			File.WriteAllText(path, listToJson);
		}
	}
}
