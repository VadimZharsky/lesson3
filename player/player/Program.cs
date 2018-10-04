using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();
            List<string> songName = new List<string>();
            List<string> byAuthor = new List<string>();
            songs.Add(new Song("aux absents", "FonkyFamily", "1998", ""));
            songs.Add(new Song("eye of Ra", "Nile", "2007", ""));
            songs.Add(new Song("drowning", "Sixth June", "2014", ""));
            songs.Add(new Song("More days to come", "e-life", "2001", ""));
            songs.Add(new Song("Anybody", "Currensy", "2000", ""));
            songs.Add(new Song("Solitude depth", "Sterbend", "1990", ""));
            songs.Add(new Song("Against the wall", "Group Home", "2016", ""));
            songs.Add(new Song("Orchidea", "Kauan", "2010", ""));
            Console.WriteLine(songs[0].locked);
            songs[0].Lock();
            Console.WriteLine(songs[0].locked);
            songs[0].Play();
            Console.WriteLine(songs[0].isPlaying);
            for (int i=0; i < songs.Capacity; i++)
            {
                songName.Add(songs[i].songName);
                byAuthor.Add(songs[i].author);
            }
            Playlist play = new Playlist(songName, byAuthor);
            play.Observer();
            
            Console.ReadKey();

        }
    }
}
