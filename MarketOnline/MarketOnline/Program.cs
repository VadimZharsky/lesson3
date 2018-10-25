using System;
using MarketOnline.SellerWork;

namespace MarketOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var sell = new Seller();
            sell.SellerWork();;
            Console.ReadKey();  
        }
       
    }
}
