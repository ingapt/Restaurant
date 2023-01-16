namespace Restaurant.Entities
{
	public class ClientCheque
	{
		public int OrderId {get; set;}
		public List<ChequeItem> FoodList { get; set; } = new List<ChequeItem>();
		public List<ChequeItem> DrinksList { get; set; } = new List<ChequeItem> { };
		public double AllPrice { get; set; }
		public DateTime DateTime { get; set; }

		public ClientCheque(int orderId, List<ChequeItem> food, List<ChequeItem> drinks, double allPrice, DateTime dateTime)
		{
			OrderId = orderId;
			FoodList = food;
			DrinksList= drinks;
			AllPrice = allPrice;
			DateTime = dateTime;
		}
	}
}
