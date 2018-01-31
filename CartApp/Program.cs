using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "The Market";          

            Dictionary<int, string> Inventory = StockInventory();

            PrintMenu(Inventory);

            //ORDER?
            Console.Write("\nWhat item would you like to order? ");

            int ChosenItem = int.Parse(Console.ReadLine());

            if (Inventory.TryGetValue(ChosenItem, out string message))
            {
                
            }

            Console.WriteLine("Adding {0} to cart at X", ChosenItem/*,Price*/);

            //MORE ORDER?
            Console.Write("\nWould you like to order anything else (y/n)? ");
            char OrderAgain = char.Parse(Console.ReadLine());

            //MENU: ITEMLIST    PRICELIST
            /*DECISION*/
            Console.WriteLine("User Decision...");
            Console.WriteLine("[1] apple\t$0.99\n[2] banana\t$0.77\n[3] " +
                              "carrot\t$1.10\n[4] dip         $3.00\n[5] eggs\t$0.20\n[6] " +
                              "froyo\t$4.30\n[7] grain\t$5.00\n[8] hops\t$9.00");

            //OOPS ORDER
            Console.Write("\nWhat item would you like to order? ");
            string Item2 = Console.ReadLine();
            Console.WriteLine("Sorry we don't have that item. Come back later");

            //MENU: ITEMLIST    PRICELIST
            Console.WriteLine("\n(if user enters yes)");
            Console.WriteLine("[1] apple\t$0.99\n[2] banana\t$0.77\n[3] " +
                              "carrot\t$1.10\n[4] dip         $3.00\n[5] eggs\t$0.20\n[6] " +
                              "froyo\t$4.30\n[7] grain\t$5.00\n[8] hops\t$9.00");
        }

        private static Dictionary<int, string> StockInventory()
        {          
            return new Dictionary<int, string>
            {
                { 1, "Apple" },
                { 2, "Banana" },
                { 3, "Carrot" },
                { 4, "Dip" },
                { 5, "Egg" },
                { 6, "Fry" },
                { 7, "HotPocket" },
                { 8, "Granola" }
            };
        }

        private static void PrintMenu(Dictionary<int, string> Inventory)
        {
            Console.WriteLine("Item\t\tPrice");
            Console.WriteLine(new string('=', 30));

            foreach (KeyValuePair<int, string> item in Inventory)
                Console.WriteLine("[{0}]\t\t{1}", item.Key, item.Value);            
        }
    }
}
