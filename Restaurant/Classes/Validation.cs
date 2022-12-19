namespace Restaurant.Classes
{
	public class Validation
	{
		public int GetValidNumbersOfFourFromConsole()
		{
			bool isCorrectNumber = false;
			int value = 0;

			while (!isCorrectNumber)
			{
				string userInput = Console.ReadLine();
				if (int.TryParse(userInput, out value))
				{
					if (value > 0 && value < 5)
					{
						return value;
						isCorrectNumber = true;
					}
					else
					{
						Console.WriteLine("Įveskite skaičių [1 - 4]. ");

					}
				}
				else
				{
					Console.WriteLine("Įveskite skaičių [1 - 4]. ");
				}

			}

			return value;
		}
	}
}
