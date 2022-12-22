﻿namespace Restaurant.Entities
{
	public class Item
	{
		public int Id { get; set; }	
		public string Name { get; set; }
		public double Price { get; set; }

		public Item(int id, string name, double price)
		{
			Id = id;
			Name = name;
			Price = price;
		}

		public Item() { }
	}
}
