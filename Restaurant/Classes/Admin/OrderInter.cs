using Restaurant.Entities;
using Restaurant.Repositories;

namespace Restaurant.Classes.Admin
{
    public static class OrderInter
    {
        public static void Start(this MainRepository<Item> foodRepository, MainRepository<Item> drinkRepository, MainRepository<Item> orderRepository)
        {
            bool toDoOrderInter = true;

            while (toDoOrderInter)
            {
                Console.Clear();
                Console.WriteLine("[1] Užsakymų sąrašas \n[2] Atnaujinti užsakymą \n[3] Ištrinti vieną užsakymą \n[4] Ištrinti visus užsakymus \n[5] Grįžti atgal");
                var input = 5.GetValidNumbersFromConsole();
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Užsakymų sąrašas.");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Atnaujinti užsakymą. ");
                        break;
                    case 3:
                        Console.WriteLine("Ištrinti vieną užsakymą. ");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Ištrinti visus užsakymus. ");
                        Console.ReadKey();
                        break;
                    case 5:
                        toDoOrderInter = false;
                        break;
                    default:
                        break;

                }
            }
        }
    }
}
