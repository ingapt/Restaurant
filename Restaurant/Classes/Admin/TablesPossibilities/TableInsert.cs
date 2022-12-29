using Restaurant.Repositories;

namespace Restaurant.Classes.Admin.TablesPossibilities
{
    public static class TableInsert
    {
        public static void InsertTableInTablesList()
        {
            Console.WriteLine("Staliukų įterpimas į sąrašą. ");
            Console.WriteLine();
            Console.WriteLine("Įveskite naujojo staliuko vietų skaičių");
            var input = Validation.GetValidIntergerNumber();
            input.InsertInToTableList();
            TableRepository.WriteDataToJsonFile();
            Console.WriteLine("Naujas staliukas įvestas. ");
        }
    }
}
