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
            List<Song> songs = new List<Song>();
            List<string> songNames = new List<string>(songs.Capacity);
            List<string> artist = new List<string>(songs.Capacity);
            List<string> genre = new List<string>(songs.Capacity);
            List<double> duration = new List<double>(songs.Capacity);
            songs.Add(new Song("aux absents", "FonkyFamily", "1998", "", "hiphop",4.25));
            songs.Add(new Song("In the name of Amun", "Nile", "2007", "", "technicalDeath",3.44));
            songs.Add(new Song("drowning", "Sixth June", "2014", "", "minimalSynth/darkwave",5.14));
            songs.Add(new Song("More days to come", "e-life", "2001", "", "hiphop",2.25));
            songs.Add(new Song("Anybody", "Currensy", "2000", "", "hiphop",3.14));
            songs.Add(new Song("Solitude depth", "Sterbend", "1990", "", "dsbm", 3.40));
            songs.Add(new Song("Keep Rising", "Group Home", "2016", "", "hiphop", 4.13));
            songs.Add(new Song("Orchidea", "Kauan", "2010", "", "atmospheric doom/dark", 5.57));

            for (int i = 0; i < songs.Capacity ; i++)
            {
                songNames.Add(songs[i].songName);
                artist.Add(songs[i].artist);
                genre.Add(songs[i].genre);
                duration.Add(songs[i].duration);
            }
            Texter("==================");

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
