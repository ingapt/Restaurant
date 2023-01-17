using Restaurant.Entities;
using Restaurant.Repositories;

namespace TestRestaurant
{
	public class Tests
	{
		MainRepository<Item> foodRepository = new MainRepository<Item>();
		

		[SetUp]
		public void Setup()
		{
		}

		//MainRepository 
		[Test]
		public void GetLastItemIdFromTheList()
		{
			var foodList = foodRepository.Retreive();
			// Arrange
			var countItem = foodList.Count();

			//Act
			var lastItemId = foodRepository.GetLastId(foodList);
			
			//Assert
			Assert.AreEqual(lastItemId, countItem);
		}

		[Test]
		public void InsertItemToTheList ()
		{
			var foodList = foodRepository.Retreive();
			// Arrange
			var lastItemId = foodRepository.GetLastId(foodList);
			int id = lastItemId + 1;
			string name = "Antienos file su darþovëmis";
			double price = 7.50;

			var foodItem = new Item(id, name, price);
			foodList.Add(new Item(id, name, price));

			var countItems = foodList.Count;

			//Act
			foodRepository.InsertItemInToList(foodItem);
			lastItemId = foodRepository.GetLastId(foodList);

			//Assert
			Assert.Equals(lastItemId, countItems);
		}

		[Test]
		public void GetItemFromTheListById()
		{
			var foodList = foodRepository.Retreive();

			// Arrange
			var lastItemId = foodRepository.GetLastId(foodList);
			var random = new Random();
			var lastItem = lastItemId + 1;
			var rndId = random.Next(1, lastItem);
			var fooditem = foodList.Single(x => x.Id == rndId);

			//Act
			var item = foodRepository.Retreive(rndId);

			//Assert
			Assert.AreEqual(item, fooditem);
		}

		[Test]
		public void IsAnyItemIdOnTheList()
		{
			var foodList = foodRepository.Retreive();

			// Arrange
			var lastItemId = foodRepository.GetLastId(foodList);
			var random = new Random();
			var lastItem = lastItemId + 1;
			var rndId = random.Next(1, lastItem);

			//Act
			var item = foodRepository.IsItemIdInItemsList(rndId);

			//Assert
			Assert.IsTrue(item);
		}

		[Test]
		public void DeleteAnyItemFromTheList()
		{
			var foodList = foodRepository.Retreive();

			// Arrange
			var lastItemId = foodRepository.GetLastId(foodList);
			var random = new Random();
			var lastItem = lastItemId + 1;
			var rndId = random.Next(1, lastItem);
			var foodItem = foodList.Single(x => x.Id == rndId);
			foodList.Remove(foodItem);

			var ItemsCount = foodList.Count();
			//Act
			foodRepository.DeleteItemFromList(rndId);
			var foodItems = foodRepository.GetLastId(foodList);

			//Assert
			Assert.AreEqual(foodItems, ItemsCount);
		}
	}
}