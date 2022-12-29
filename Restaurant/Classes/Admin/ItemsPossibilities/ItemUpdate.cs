using Restaurant.Entities;
using Restaurant.Repositories;

namespace Restaurant.Classes.Admin.ItemsPossibilities
{
    public static class ItemUpdate
    {
        public static void FoodItemUpdate(this MainRepository<Item> foodRepository)
        {
            List<Item> foodList = foodRepository.Retreive();
            Console.Clear();
            Console.WriteLine("Pasirinkite: ");
            Console.WriteLine("[1] Pakeisti patiekalo pavadinimą \n[2] Pakeisti patiekalo kainą \n[3] Grįžti atgal");
            var input1 = 3.GetValidNumbersFromConsole();
            switch (input1)
            {
                case 1:
                    Console.WriteLine("Patiekalo pavadinimo keitimas. Įveskite patiekalo ID: ");
                    var input2 = Validation.GetValidIntergerNumber();
                    if (foodRepository.IsItemIdInItemsList(input2))
                    {
                        Console.WriteLine("Įveskite naują patiekalo pavadinimą. ");
                        string name = Console.ReadLine();
                        ItemNameAndPriceUpdate.ItemNameChange(foodRepository, foodList, input2, name, "food.json");
                        Console.WriteLine();
                        Console.WriteLine("Patiekalo pavadinimas pakeistas.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Su šiuo ID patiekalo meniu nėra. ");
                        Console.ReadKey();
                    }
                    break;
                case 2:
                    Console.WriteLine("Patiekalo kainos keitimas. Įveskite patiekalo ID: ");
                    input2 = Validation.GetValidIntergerNumber();
                    if (foodRepository.IsItemIdInItemsList(input2))
                    {
                        Console.WriteLine("Įveskite naują patiekalo kainą. ");
                        var input3 = Validation.GetValidDoubleNumber();
                        ItemNameAndPriceUpdate.ItemPriceChange(foodRepository, foodList, input2, input3, "food.json");
                        Console.WriteLine();
                        Console.WriteLine("Patiekalo kaina pakeista.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Su šiuo ID patiekalo meniu nėra. ");
                        Console.ReadKey();
                    }
                    break;
                case 3:
                    break;
            }
        }

        public static void DrinkItemUpdate(this MainRepository<Item> drinkRepository)
        {
            List<Item> drinksList = drinkRepository.Retreive();
            Console.Clear();
            Console.WriteLine("Pasirinkite: ");
            Console.WriteLine("[1] Pakeisti gėrimo pavadinimą \n[2] Pakeisti gėrimo kainą \n[3] Grįžti atgal");
            var input = 3.GetValidNumbersFromConsole();
            switch (input)
            {
                case 1:
                    Console.WriteLine("Patiekalo pavadinimo keitimas. Įveskite patiekalo ID: ");
                    var input2 = Validation.GetValidIntergerNumber();
                    if (drinkRepository.IsItemIdInItemsList(input2))
                    {
                        Console.WriteLine("Įveskite naują patiekalo pavadinimą. ");
                        string name = Console.ReadLine();
                        ItemNameAndPriceUpdate.ItemNameChange(drinkRepository, drinksList, input2, name, "drinks.json");
                        Console.WriteLine();
                        Console.WriteLine("Patiekalo pavadinimas pakeistas.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Su šiuo ID patiekalo meniu nėra. ");
                        Console.ReadKey();
                    }
                    break;
                case 2:
                    Console.WriteLine("Gėrimo kainos keitimas. Įveskite gėrimo ID: ");
                    input2 = Validation.GetValidIntergerNumber();
                    if (drinkRepository.IsItemIdInItemsList(input2))
                    {
                        Console.WriteLine("Įveskite naują patiekalo kainą. ");
                        var input3 = Validation.GetValidDoubleNumber();
                        ItemNameAndPriceUpdate.ItemPriceChange(drinkRepository, drinksList, input2, input3, "drinks.json");
                        Console.WriteLine();
                        Console.WriteLine("Gėrimo kaina pakeista.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Su šiuo ID gėrimo meniu nėra. ");
                        Console.ReadKey();
                    }
                    break;
                case 3:
                    break;
            }
        }
    }
}
