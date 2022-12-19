namespace Restaurant.Entities
{
	public class Table
	{
		public int TableNum { get; set; }
		public int SeatsNum { get; set; }
		public bool TableStatus { get; set; }

		public Table(int tableNum, int seatsNum, bool tableStatus)
		{
			TableNum = tableNum;
			SeatsNum = seatsNum;
			TableStatus = tableStatus;
		}

		public Table() { }
	}
}
