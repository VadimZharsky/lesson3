using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticUnicId
{
    class Item
    {
        public int id { get; private set; }
        public string name { get; set; }
        static public int nextId = 1;
        static Item()
        {
            nextId = 1000;
        }
        public Item()
        {
            id = nextId;
            nextId++;
        }
    }
}
