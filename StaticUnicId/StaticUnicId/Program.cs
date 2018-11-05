using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticUnicId
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            for (int i = 0; i < 50; i++)
            {
                items.Add(new Item() { name = "next Item"});
                
            }
            foreach (Item item in items)
            {
                Console.WriteLine("{0} : {1}", item.name, item.id);
            }
            Console.ReadKey();
        }
    }
}
