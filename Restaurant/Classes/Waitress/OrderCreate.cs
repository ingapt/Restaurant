using Restaurant.Entities;
using Restaurant.Repositories;

namespace Restaurant.Classes.Waitress
{
    public static class OrderCreate
    {
        public static void CreateOrder(this MainRepository<Item> foodRepository, MainRepository<Item> drinkRepository, MainRepository<Item> orderRepository, int tableNumber)
        {
            var foodList = foodRepository.Retreive();
            var drinksList = drinkRepository.Retreive();

            Console.Clear();
            Console.WriteLine($"Staliuko numeris: {tableNumber}");
            Console.WriteLine();
            DisplayFoodAndDrinksItems.FoodItemsToDisplay(foodList);

            Console.WriteLine();
            Console.WriteLine("Pasirinkite patiekalo id: ");
            var foodId = Validation.GetValidNumbersFromConsole(foodRepository.GetLastId(foodList));
            Console.WriteLine();
            Console.Clear();

            DisplayFoodAndDrinksItems.DrinkItemsToDisplay(drinksList);
            Console.WriteLine("Pasirinkite gėrimų id: ");
            var drinkId = Validation.GetValidNumbersFromConsole(drinkRepository.GetLastId(drinksList));
            
            //Čia turi būti data. :) 

            Console.ReadKey();
        }
    }
}
