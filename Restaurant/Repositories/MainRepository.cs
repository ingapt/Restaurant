using Restaurant.Interfaces;
using System.Text;
using System.Text.Json;

namespace Restaurant.Repositories
{
	public class MainRepository<T> where T : IEntity
	{
		private List<T> AnyList { get; set; } = new List<T>();

		public List<T> ReadDataFromFile(string path)
		{
			var itemList = new List<T>();
			
			using (StreamReader reader = new StreamReader(path))
			{ 
				string json = reader.ReadToEnd();
				itemList = JsonSerializer.Deserialize<List<T>>(json);

			}

			if (itemList != null && itemList.Count > 0)
			{
				foreach (var item in itemList)
				{ 
					AnyList.Add(item);
				}
			}
			
			return AnyList;
		}

		public List<T> Retreive()
		{
			return AnyList;
		}

		public T Retreive(int anyId)
		{
			foreach (var item in AnyList)
			{
				if (item.Id == anyId)
				{
					return item;
				}
			}

			return default;
		}

		public void InsertItemInToList(T Item) 
		{ 
			AnyList.Add(Item);
		}

		public int GetLastId(List<T> items)
		{ 
			return AnyList.Last().Id;
		}

		public void CreateJsonFile(List<T> list)
		{
			var jsonList = JsonSerializer.Serialize(list);
			var path = @"./orders.json";
			File.WriteAllText(path, jsonList);
		}

		public void WriteToJsonFile(List<T> list, string fileName)
		{
			string directory = @"C:\Users\Ingiux\source\repos\Restaurant\Restaurant\Files\";

			var jsonList = JsonSerializer.Serialize(list);
			var path = Path.Combine(directory, fileName);
			File.WriteAllText(path, jsonList, Encoding.UTF8);
		}
	}
}
