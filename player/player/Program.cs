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
            List<Song> songs = new List<Song>(9);
            List<string> songName = new List<string>(songs.Capacity);
            List<string> byAuthor = new List<string>(songs.Capacity);
            List<string> byYear = new List<string>(songs.Capacity);
            List<string> byGenre = new List<string>(songs.Capacity);
            songs.Add(new Song( "aux absents" , "FonkyFamily",  "1998","",  "hiphop" ));
            songs.Add(new Song( "In the name of Amun" ,  "Nile",  "2007", "", "technicalDeath" ));
            songs.Add(new Song( "drowning" ,  "Sixth June",  "2014", "", "minimalSynth/darkwave" ));
            songs.Add(new Song( "More days to come" ,  "e-life",  "2001", "", "hiphop" ));
            songs.Add(new Song( "Anybody" ,  "Currensy",  "2000", "", "hiphop"));
            songs.Add(new Song( "Solitude depth" ,  "Sterbend",  "1990", "", "dsbm"));
            songs.Add(new Song( "Keep Rising" ,  "Group Home",  "2016", "", "hiphop" ));
            songs.Add(new Song( "Orchidea" ,  "Kauan",  "2010", "", "atmospheric doom/dark"));
            songs.Add(new Song("Younger Dryas" , "Linea Aspera", "2005", "", "minimalSynth/darkwave" ));

            //songs.Add(new Song(){"Younger Dryas", "Linea Aspera", "2005", "", "minimalSynth/darkwave"});
            Text(songs[0].locked.ToString());
            songs[0].Lock();
            Text(songs[0].locked.ToString());
            songs[0].Play();
            Text(songs[0].isPlaying.ToString());
            Text(songs.Capacity.ToString());
            for (int i=0; i < songs.Capacity; i++)
            {
                songName.Add(songs[i].songName);
                byAuthor.Add(songs[i].author);
                byYear.Add(songs[i].year);
                byGenre.Add(songs[i].genre);
            }

            Playlist play = new Playlist(songName, byAuthor);
            Playlist sort = new Playlist();
            sort.Sorting(songName);
            Text("----------------");
            sort.Sorting(byAuthor);
            Text("----------------");
            sort.Sorting(byYear);
            Text("----------------");
            sort.Sorting(byGenre);

            Console.ReadKey();

        }
        public static void Text(string s)
        {
            Console.WriteLine(s);
        }
    }
}
