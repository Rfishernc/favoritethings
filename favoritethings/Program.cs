using System;

namespace favoritethings
{
    class Program
    {
        static void Main(string[] args)
        {
            var NYPizza = new pizza
            {
                Style = "New York",
                Crust = "Thin"
            };
            var ChiPizza = new pizza
            {
                Style = "Chicago",
                Crust = "Deep Dish"
            };
            var Badger1 = new honeyBadger
            {
                Weight = 50,
                Age = 10,
            };
            var Badger2 = new honeyBadger
            {
                Weight = 35,
                Age = 8
            };
            
            Console.ReadLine();
        }
    }
}
