using Restaurant.Entities;
using Restaurant.Repositories;

namespace Restaurant.Classes
{
	public static class ItemNameAndPriceUpdate
	{
		public static void ItemNameChange(MainRepository<Item> repository, List<Item> itemList, int id, string name, string fileName)
		{
			foreach (var item in itemList)
			{
				if (item.Id == id)
				{
					item.Name = name;
				}
			}

			repository.WriteItemsToJsonFile(itemList, fileName);
		}

		public static void ItemPriceChange(MainRepository<Item> repository, List<Item> itemList, int id, double price, string fileName)
		{
			foreach (var item in itemList)
			{
				if (item.Id == id)
				{
					item.Price = price;
				}
			}

			repository.WriteItemsToJsonFile(itemList, fileName);
		}
	}
}
