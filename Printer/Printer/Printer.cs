using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;


namespace Printer
{
    abstract class Printer
    {
       public abstract void Print();
    }
    class ToConsole : Printer
    {
       public string text { get; set; }
       public override void Print()
        {
            Console.WriteLine(text);
        }
    }
    class ToFile : Printer
    {
        public string text { get; set; }
        public override void Print()
        {
            File.WriteAllText("Printed Text.txt", text); 
        }
    }
    class ToImage : Printer
    {
        public string text { get; set; }
        public override void Print()
        {
            Bitmap bitmap = new Bitmap(400, 400);
            FileStream stream = new FileStream("TestImage.jpg", FileMode.Create, FileAccess.ReadWrite);
            Graphics graphicImage = Graphics.FromImage(bitmap);
            graphicImage.Clear(Color.White);
            graphicImage.DrawString(text, new Font("Arial", 20, FontStyle.Bold),
            Brushes.Black, new Point(10, 10));
            graphicImage.Save();
            bitmap.Save(stream, ImageFormat.Jpeg);
        }
    }
}
