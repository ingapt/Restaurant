namespace Restaurant.Entities
{
	public class Order
	{
		public int Id { get; set; }
		public int TableNum { get; set; }
		public int FoodId { get; set; }
		public int DrinkId { get; set; }
		public int Quantity { get; set; }
		public DateTime Date { get; set; }

		public Order(int id, int tableNum, int foodId, int drinkId, int quantity, DateTime date)
		{
			Id = id;
			TableNum = tableNum;
			FoodId = foodId;
			DrinkId = drinkId;
			Quantity = quantity;
			Date = date;
		}

		public Order() { }

	}
}
