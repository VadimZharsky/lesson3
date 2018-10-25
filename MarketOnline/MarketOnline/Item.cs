

namespace MarketOnline
{
    class Item
    {

        private string name;
        private int price;
        private string id;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Price
        {
            get { return price; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public void SetPrice(int price)
        {
            this.price = price;
        }
        public virtual string SeeItems() { return ""; }
        public static bool operator ==(Item item, Item item2)
        {
            return item.Price == item2.Price;
        }
        public static bool operator !=(Item item, Item item2)
        {
            return item.Price != item2.Price;
        }
        public static bool operator <(Item item, Item item2)
        {
            return item.Price < item2.Price;
        }
        public static bool operator >(Item item, Item item2)
        {
            return item.Price > item2.Price;
        }
    }
    class Smartphone : Item
    {
        private string model;
        private string screenSize;
        private string cpuMod;
        private string gpuMod;
        private string editionYear;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string ScreenSize
        {
            get { return screenSize; }
            set { screenSize = value; }
        }
        public string CpuMod
        {
            get { return cpuMod; }
            set { cpuMod = value; }
        }
        public string GpuMod
        {
            get { return gpuMod; }
            set { gpuMod = value; }
        }
        public string EditionYear
        {
            get { return editionYear; }
            set { editionYear = value; }
        }
        public override string SeeItems()
        {
            return $"Name: {Name}\nModel: {Model}\nScreenSize: {ScreenSize}\nProcessor: {CpuMod}\nGraphics: {GpuMod}\nYear: {EditionYear}\nPrice{Price}$\n";
        }
    }
    class VacuumCleaner : Item
    {
        private string model;
        private string power;
        private string noizeLevel;

        public string Power
        {
            get { return power; }
            set { power = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string NoizeLevel
        {
            get { return noizeLevel; }
            set { noizeLevel = value; }
        }
        public override string SeeItems()
        {
            return $"Name: {Name}\nModel: {Model}\nPower: {Power}\nNoize Level: {NoizeLevel}\nPrice{Price}$\n";
        }
        
    }
    
}
