using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            


            /*Texter("==================");

            Song songlist = new Song(songNames);
            songlist.SelectedList(songNames);
            Texter("==================");
            Song artistlist = new Song(artist);
            songlist.SelectedList(artist);
            Texter("==================");
            Song genrelist = new Song(genre);
            songlist.SelectedList(genre);
            Texter("==================");
            Song durationlist = new Song(duration);
            songlist.forDuration(duration);
            FullDuration(duration);
            PlayerProperties volume = new PlayerProperties();
            volume.Volume = 12;
            for (int i = 0; i < 15; i++)
            {
                volume.VolumeDown();
                Texter($"now volume is: {volume.Volume.ToString()}");
            }
            */
            PlayerCommand.Command();
            Console.ReadKey();
        }
        public static void Texter(string s)
        {
            Console.WriteLine(s);
        }
        public static double FullDuration(List<double> duration)
        {
            double full = 0;
            foreach (double d in duration)
            {
                int temp = (int)d;
                double remainder = d - temp;
                remainder *= 100;
                temp *= 60;
                double inSec = temp + remainder;
                full += inSec;
                Texter($"start: {d},, inSec: {inSec}");
            }
            
            return 0;
        }
    }
}
