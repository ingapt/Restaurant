namespace Restaurant.Entities
{
	public class RestaurantCheque
	{
		public int TableNum { get; set; }
		public int OrderId { get; set; }
		public List<ChequeItem> FoodList { get; set; } = new List<ChequeItem>();
		public List<ChequeItem> DrinksList { get; set; } = new List<ChequeItem> { };
		public double AllPrice { get; set; }
		public DateTime DateTime { get; set; }
	
		public RestaurantCheque(int tableNum, int orderId, List<ChequeItem> foodList, List<ChequeItem> drinksList, double allPrice, DateTime dateTime)
		{
			TableNum = tableNum;
			OrderId = orderId;
			FoodList = foodList;
			DrinksList = drinksList;
			AllPrice = allPrice;
			DateTime = dateTime;
		}
	}
}
