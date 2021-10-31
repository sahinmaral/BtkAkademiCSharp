using System;

namespace EventsDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product harddisk = new Product(50);

            harddisk.ProductName = "Hard Disk";

            Product gsm = new Product(50);
            gsm.ProductName = "GSM";
            gsm.StockControlEvent += GsmOnStockControlEvent;

            for (int i = 0; i < 10; i++)
            {
                harddisk.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
            }
        }

        private static void GsmOnStockControlEvent()
        {
            Console.WriteLine("Gsm about to finish");
        }
    }
}