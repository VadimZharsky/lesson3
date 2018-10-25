using System;
using System.Collections.Generic;


namespace MarketOnline.SellerWork
{
    class Seller
    {
        public List<Item> items = new List<Item>();
        public void SellerWork()
        {


            items.Add(new Smartphone() { id = "77875578", name = "Samsung", Model = "S8+", CpuMod = "SnapDragon835", GpuMod = "Adreno510", EditionYear = "2017", ScreenSize = "5.45" });
            items.Add(new Smartphone() { id = "44122474", name = "Xiaomi", Model = "Mi8", CpuMod = "SnapDragon845", GpuMod = "Adreno630", EditionYear = "2018", ScreenSize = "6.20" });
            items.Add(new VacuumCleaner() { id = "77875578", name = "Zelmer", Model = "ZVC752SPRU", Power = "1600", NoizeLevel = "80" });
            items.Add(new VacuumCleaner() { id = "45177742", name = "Bosch", Model = "BCH6ATH18", Power = "2400", NoizeLevel = "90" });
            var prices = new Item();
            items[0].Price = 780;
            items[1].Price = 510;
            items[2].Price = 180;
            items[3].Price =200;
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
