using Restaurant.Entities;
using Restaurant.Interfaces;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

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

		public bool IsItemIdInItemsList(int id)
		{ 
			return AnyList.Exists(item => item.Id == id);
		}

		public void DeleteItemFromList(int id)
		{ 
			var item = AnyList.SingleOrDefault(item => item.Id == id);
			AnyList.Remove(item);
		}

		public void WriteOrdersToJsonFile(List<T> list)
		{
			var jsonList = JsonSerializer.Serialize(list);
			var path = @"./orders.json";
			File.WriteAllText(path, jsonList);
		}

		public void WriteItemsToJsonFile(List<T> list, string fileName)
		{
			string directory = @"C:\Users\Ingiux\source\repos\Restaurant\Restaurant\Files\";

			var encoderSettings = new TextEncoderSettings();
			encoderSettings.AllowCharacters('\u0105', '\u010D', '\u0119', '\u0117', '\u012F', '\u0161', '\u0173', '\u016B', '\u017E');
			encoderSettings.AllowRange(UnicodeRanges.All);

			var options = new JsonSerializerOptions()
			{
				Encoder = JavaScriptEncoder.Create(encoderSettings),
				WriteIndented = true
			};
			var jsonList = JsonSerializer.Serialize(list, options);
			var path = Path.Combine(directory, fileName);
			File.WriteAllText(path, jsonList);
		}
	}
}
