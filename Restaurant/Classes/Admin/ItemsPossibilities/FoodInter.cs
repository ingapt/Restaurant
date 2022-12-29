using Restaurant.Entities;
using Restaurant.Repositories;
using System.Runtime;

namespace Restaurant.Classes.Admin.ItemsPossibilities
{
    public static class FoodInter
    {
        public static void Start(this MainRepository<Item> foodRepository)
        {
            bool toDo = true;

            while (toDo)
            {
                Console.Clear();
                Console.WriteLine("[1] Patiekalo įtraukimas į sąrašą. \n[2] Patiekalo atnaujimas. \n[3] Patiekalo pašalinimas \n[4] Grįžti atgal");
                var input = 4.GetValidNumbersFromConsole();
                switch (input)
                {
                    case 1:
                        foodRepository.FoodItemInsert();
                        break;
                    case 2:
                        foodRepository.FoodItemUpdate();
                        break;
                    case 3:
                        foodRepository.FoodItemDelete();
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
