namespace Restaurant
{
	public interface IEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }	
		public double Price { get; set; }
	}
}
