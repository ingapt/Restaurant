namespace Restaurant.Entities
{
	public class Drink
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }

		public Drink(int iD, string name, double price)
		{
			ID = iD;
			Name = name;
			Price = price;
		}

		public Drink() { }
	}
}
