using Restaurant.Interfaces;
namespace Restaurant.Entities
{
	public class OrderItem
	{
		public int Id { get; set; }
		public int Quantity { get; set; }

		public OrderItem(int id, int quantity)
		{
			Id = id;
			Quantity = quantity;
		}

		public OrderItem()
		{
		}
	}
}
