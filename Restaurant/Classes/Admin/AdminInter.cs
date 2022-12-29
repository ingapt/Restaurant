using Restaurant.Classes.Admin.ItemsPossibilities;
using Restaurant.Classes.Admin.TablesPossibilities;
using Restaurant.Entities;
using Restaurant.Repositories;

namespace Restaurant.Classes.Admin
{
    public static class AdminInter
    {
        public static void Start(this MainRepository<Item> foodRepository, MainRepository<Item> drinkRepository, MainRepository<Item> orderRepository)
        {
            bool toDo = true;

            while (toDo)
            {
                Console.Clear();
                Console.WriteLine("[1] Užsakymai \n[2] Čekiai \n[3] Staliukai \n[4] Patiekalai ir gėrimai \n[5] Baigti");
                Console.WriteLine();
                Console.WriteLine("Pasirinkite: ");
                var input = 5.GetValidNumbersFromConsole();
                switch (input)
                {
                    case 1:
                        OrderInter.Start(foodRepository, drinkRepository, orderRepository);
                        break;
                    case 2:
                        ChequeInter.Start();
                        break;
                    case 3:
                        TablesInter.Start();
                        break;
                    case 4:
                        ItemsInter.Start(foodRepository, drinkRepository);
                        break;
                    case 5:
                        toDo = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
