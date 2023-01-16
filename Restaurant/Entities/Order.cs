using Restaurant.Interfaces;
namespace Restaurant.Entities
{
	public class Order : IEntity
	{
		public int Id { get; set; }
		public int TableNum { get; set; }
		public List<OrderItem> FoodIdList { get; set; } = new List<OrderItem>();
		public List<OrderItem> DrinkIdList { get; set; } = new List<OrderItem>();
		public DateTime Date { get; set; }

		public Order(int id, int tableNum, List<OrderItem> foodIdList, List<OrderItem> drinkIdList, DateTime date)
		{
			Id = id;
			TableNum = tableNum;
			FoodIdList = foodIdList;
			DrinkIdList = drinkIdList;
			Date = date;
		}

		public Order() { }

	}
}
