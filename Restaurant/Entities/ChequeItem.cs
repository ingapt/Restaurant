
namespace Restaurant.Entities
{
	public class ChequeItem
	{
		public string Name { get; set; }
		public int Quantity { get; set; }
		public double Price { get; set; }

		public ChequeItem(string name, int quantity, double price)
		{ 
			Name = name;
			Quantity = quantity;
			Price = price;
		}
	}
}
