using Restaurant.Entities;
using Restaurant.Repositories;

namespace Restaurant.Classes.Admin.ItemsPossibilities
{
    public static class DrinkInter
    {
        public static void Start(MainRepository<Item> drinkRepository)
        {
            bool toDo = true;

            while (toDo)
            {
                Console.Clear();
                Console.WriteLine("[1] Gėrimo įtraukimas į sąrašą. \n[2] Gėrimo atnaujimas. \n[3] Gėrimo pašalinimas \n[4] Grįžti atgal");
                var input = 4.GetValidNumbersFromConsole();
                switch (input)
                {
                    case 1:
                        drinkRepository.DrinkItemInsert();
                        break;
                    case 2:
                        drinkRepository.DrinkItemUpdate();
                        break;
                    case 3:
                        drinkRepository.DrinkItemDelete();
                        break;
                    case 4:
                        toDo = false;
                        break;
                    default:
                        break;
                }

            }

        }
    }
}
