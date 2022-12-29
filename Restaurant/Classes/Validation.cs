using System;

namespace Restaurant.Classes
{
	public static class Validation
	{
		public static int GetValidNumbersFromConsole(this int options)
		{
			bool isCorrectNumber = false;
			int value = 0;
			while (!isCorrectNumber)
			{
				string userInput = Console.ReadLine();
				if (int.TryParse(userInput, out value) && value <= options && value > 0)
				{
					isCorrectNumber = true;

				}
				else
				{
					Console.WriteLine($"Pasirinkite nuo 1 iki {options}");
				}
			}
			return value;
		}

		public static int GetValidIntergerNumber()
		{
			bool isCorrectNumber = false;
			int value = 0;

			while (!isCorrectNumber)
			{
				string userInput = Console.ReadLine();
				if (int.TryParse(userInput, out value) && value > 0)
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

		public static double GetValidDoubleNumber() 
		{
			bool isCorrectNumber = false;
			double value = 0;

			while (!isCorrectNumber)
			{
				string userInput = Console.ReadLine();
				if (double.TryParse(userInput, out value) && value > 0)
				{
					isCorrectNumber = true;
				}
				else
				{
					Console.WriteLine("Įveskite tinkamą skaičių. pvz: 2.50 ");
				}
			}

			return value;
		}

		public static char GetYesOrNoFromConsole()
		{ 
			bool isCorrectInput = false;
			char value = ' ';
			while (!isCorrectInput)
			{ 
				var userInput = char.Parse(Console.ReadLine());
				value = Char.ToUpper(userInput);

				if (value.Equals('T') || value.Equals('N'))
				{
					isCorrectInput = true;
				}
				else
				{
					Console.WriteLine("Įveskite raidę: T, t - Taip; N, n - Ne");
				}

			}

			return value;
		}
	}
}
