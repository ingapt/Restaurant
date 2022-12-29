using Restaurant.Entities;
using Restaurant.Repositories;

namespace Restaurant.Classes.Waitress
{
    public static class WaitressInter
    {
        public static void Start(this MainRepository<Item> foodRepository, MainRepository<Item> drinkRepository, MainRepository<Item> orderRepository)
        {
            Console.Clear();
            TableRepository.DisplayTablesWithoutSeats();
            Console.WriteLine();
            var tableLastNum = TableRepository.GetLastTableNum();
            Console.WriteLine("Įveskite staliuko numerį: ");
            var tableNum = tableLastNum.GetValidNumbersFromConsole();
            if (tableNum.TableStatusIsFree())
            {
                TablesMakeFreeOrFull.TableisFree(tableNum);
            }
            else
            {
                TablesMakeFreeOrFull.TableIsFull(foodRepository, drinkRepository, orderRepository, tableNum);
            }
        }
    }
}
