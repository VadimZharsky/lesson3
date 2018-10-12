using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    class Song
    {
        public string songName, artist, year, lyrics, genre;
        public double duration;

        
        public Song(string songName, string artist, string year, string lyrics, string genre, double duration)
        {
            this.songName = songName;
            this.artist = artist;
            this.year = year;
            this.lyrics = lyrics;
            this.genre = genre;
            this.duration = duration;

        }
    }
}