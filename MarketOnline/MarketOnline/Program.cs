﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOnline
{
    class Program
    {
        static void Main(string[] args)
        {

            var sell = new Seller();
            var cust = new Customer();
            sell.SellerWork();
            cust.ShoppingTable();
            Console.ReadKey();  
        }
       
    }
}
