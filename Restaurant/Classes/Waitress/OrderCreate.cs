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
            var menuList = foodList.Concat(drinksList);

            foreach (var menuItem in menuList)
            {
                Console.WriteLine($"{menuItem.Id} {menuItem.Name} {menuItem.Price}");
            }

            Console.ReadKey();
            /*		var orderList = orderRepository.Retreive();

                    if (orderRepository.IsAnyItemInList(orderList))
                    {
                        var orderId = orderRepository.GetLastId(orderList) + 1;
                        Console.WriteLine($"Užsakymo numeris: {orderId}");
                        Console.WriteLine($"Staliuko numeris: {tableNumber}");
                        Console.ReadKey();

                    }
                    else
                    {
                        var orderId = 1;
                        bool menu = true;

                        while (menu)
                        {	

                            Console.WriteLine("Pasrinkite: \n[1] Patiekalų Menu \n[2] Gėrimų menu \n[3] Grįžti atgal");
                            var input = Validation.GetValidNumbersFromConsole(3);
                            switch (input)
                            {
                                case 1:
                                    OrderFoodAndDrinks.OrderFood(foodRepository, orderId, tableNumber);
                                    break;
                                case 2:
                                    break;
                                case 3:
                                    menu = false;
                                    break;
                                default:
                                    break;
                            }

                        }

                    }*/

        }
    }
}
