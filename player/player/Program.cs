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
            Song [] songs = new Song[34];
            songs[0] = new Song("les mains sales", "FonkyFamily", "1998", "");
            songs[1] = new Song("eye of Ra", "Nile", "2007", "");
            songs[2] = new Song("drowning", "Sixth June", "2014", "");
            songs[3] = new Song("", "e-life", "1995", "");
            songs[4] = new Song("Anybody", "Currensy", "2000", "");
            songs[5] = new Song("Water", "Sterbend", "1990", "");
            songs[6] = new Song("Against the wall", "Group Home", "2016", "");
            songs[7] = new Song("Orchidea", "Kauan", "2010", "");
            Console.WriteLine(songs[0].locked);
            songs[0].Lock();
            Console.WriteLine(songs[0].locked);
            songs[0].Play();
            Console.WriteLine(songs[0].isPlaying);
            for (int i=0; i < 8; i++)
            {
                Console.WriteLine($"{songs[i].songName} {songs[i].author} {songs[i].year} {songs[i].lyrics}");
            }
            Playlist nouveaux = new Playlist(null,null,null,null);
            nouveaux.observer();
            
            Console.ReadKey();

        }
    }
}
