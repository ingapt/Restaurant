namespace Restaurant.Entities
{
	public class Table
	{
		public int Num { get; set; }
		public int SeatsNum { get; set; }
		public bool Status { get; set; }

		public Table(int num, int seatsNum, bool status)
		{
			Num = num;
			SeatsNum = seatsNum;
			Status = status;
		}

		public Table() { }
	}
}
