using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace imageWork
{
    class Program
    {
        static void Main(string[] args)
        {

            //Bitmap bitmap = new Bitmap("20181015_225242.jpg");
            var image = Image.FromFile("20181015_225242.jpg");
            var r = new Regex(":");
            PropertyItem propItem = image.GetPropertyItem(36867);
            string dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "_", 4);
            
            Console.WriteLine(dateTaken);

            
            Console.ReadKey();
        }
    }
}
