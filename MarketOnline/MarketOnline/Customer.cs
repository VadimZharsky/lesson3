using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOnline
{
    class Customer
    {
        public  void ShoppingTable()
        {
            var seller = new Seller(); 
            List<Item> shoppingTable = new List<Item>();
            shoppingTable = seller.GetItems();
            foreach (Item item in shoppingTable)
            {
                item.SeeItems();
            }
        }
    }
}
