using ConsoleApp1;
using System.Security.Cryptography;

using ConsoleApp2;
 
namespace ConsolApp1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Manager m = new Manager();

         }
      

        public void EventTest()
        {
            Stock stock = new Stock("Amazon", 290.00d);
            stock.StockPriceChange += Stock_StockPriceChange;
            stock.StockPriceChange += Output;
            stock.ChangeStockPriceBy(.02d);
            stock.ChangeStockPriceBy(.00);
            stock.ChangeStockPriceBy(-.04);


        }
        private static void Output(Stock s, double OldPrice)
        {
            Console.WriteLine("Event was Called");


        }
        private static void Stock_StockPriceChange(Stock s, double OldPrice)
        {
            if (s.Price > OldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Smaller Price");
            }
            else if (s.Price == OldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Same price");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Greater Price");
            }
        }
    }
}

    

 

 