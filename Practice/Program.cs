using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("02 08 17 Practice");
            Cook cook1 = new Cook("Cook 1", 5);
            Cook cook2 = new Cook("Cook 2", 15);

            Server server1 = new Server("Server 1", 5);
            Server server2 = new Server("Server 2", 2);

            // cook1.OutputProps();
            // cook2.OutputProps();
            // Console.WriteLine("--------------------------------");

            server1.OutputProps();
            server2.OutputProps();
            Console.WriteLine("--------------------------------");

            // cook2.UpdateShifts();
            // server1.UpdateShifts();
            // Console.WriteLine("--------------------------------");

            // cook1.AddRecipe();
            // cook1.AddRecipe();
            // cook1.AddRecipe();
            // Console.WriteLine("--------------------------------");
            // cook1.OutputRecipes();
            // cook1.FilterRecipes();
            // cook1.RecipeDetail();
            // Console.WriteLine("--------------------------------");

            server2.UpdateTables();
            server2.UpdateTables();
            // server2.UpdateTables();
            Console.WriteLine("--------------------------------");
            server2.OutputTables();
            Console.WriteLine("--------------------------------");
        }
    }
}
