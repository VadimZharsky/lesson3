using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player
{
     class Playlist
    {
        List<Playlist> songsAdded = new List<Playlist>();
        public string songName, author, year, lyrics;

         public Playlist(string songName, string author, string year, string lyrics)
        {
            this.songName = songName;
            this.author = author;
            this.year = year;
            this.lyrics = lyrics;
            
        }
        public void observer()
        {
            foreach (object song in songsAdded)
            {
                Console.WriteLine(song.ToString());
            }
        }
    }
}
