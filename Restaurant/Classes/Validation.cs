using System;

namespace Restaurant.Classes
{
	public class Validation
	{
		public int GetValidNumbersFromConsole(int num)
		{
			bool isCorrectNumber = false;
			int value = 0;
			while (!isCorrectNumber)
			{
				string userInput = Console.ReadLine();
				if (int.TryParse(userInput, out value))
				{
					if (value > 0 && value <= num)
					{
						return value;
						isCorrectNumber = true;
					}
					else
					{
						Console.WriteLine("Įveskite tinkamą pasirinkimą.");

					}
				}
				else
				{
					Console.WriteLine("Įveskite tinkamą pasirinkimą. ");
				}
			}
			return value;
		}

		public int GetValidIntergerNumber()
		{
			bool isCorrectNumber = false;
			int value = 0;

			while (!isCorrectNumber)
			{
				string userInput = Console.ReadLine();
				if (int.TryParse(userInput, out value))
				{
					isCorrectNumber = true;
				}
				else
				{
					Console.WriteLine("Įveskite staliuko vietų skaičių. ");
				}
			}

			return value;
		}
	}
}
