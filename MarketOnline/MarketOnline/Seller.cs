using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOnline
{
    class Seller
    {
        public List<Item> items = new List<Item>();
        public void SellerWork()
        {


            items.Add(new Smartphone() { Id = "77875578", Name = "Samsung", Model = "S8+", CpuMod = "SnapDragon835", GpuMod = "Adreno510", EditionYear = "2017", ScreenSize = "5.45" });
            items.Add(new Smartphone() { Id = "44122474", Name = "Xiaomi", Model = "Mi8", CpuMod = "SnapDragon845", GpuMod = "Adreno630", EditionYear = "2018", ScreenSize = "6.20" });
            items.Add(new VacuumCleaner() { Id = "77875578", Name = "Zelmer", Model = "ZVC752SPRU", Power = "1600", NoizeLevel = "80" });
            items.Add(new VacuumCleaner() { Id = "45177742", Name = "Bosch", Model = "BCH6ATH18", Power = "2400", NoizeLevel = "90" });
            var prices = new Item();
            items[0].SetPrice(700);
            items[1].SetPrice(510);
            items[2].SetPrice(180);
            items[3].SetPrice(200);
            foreach (Item item in items)
            {
                Console.Write(item.SeeItems());
                Console.WriteLine("---------");
            }
            Console.WriteLine(items[0] < items[2]);
            Console.WriteLine(items[0] > items[2]);
            Console.WriteLine(items[0] == items[2]);
            Console.WriteLine(items[0] != items[2]);
        }

    }
}
