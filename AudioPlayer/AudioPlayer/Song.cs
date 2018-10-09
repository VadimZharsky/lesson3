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
        List<string> songList = new List<string>();
        List<string> artistList = new List<string>();
        List<string> genreList = new List<string>();
        List<double> durationList = new List<double>();
        
        public Song(string songName, string artist, string year, string lyrics, string genre, double duration)
        {
            this.songName = songName;
            this.artist = artist;
            this.year = year;
            this.lyrics = lyrics;
            this.genre = genre;
            this.duration = duration;

        }
        public Song(List<string> songList)
        {
            this.songList = songList;
        }
        public Song(List<double> songNames)
        {
            durationList = songNames;
        }
        public void SelectedList(List<string> thatList)
        {
            Console.WriteLine(thatList.Capacity);
            foreach (string s in thatList)
            {
                Console.WriteLine(s);
            }
        }
        public void forDuration(List<double> thatList)
        {
            Console.WriteLine(thatList.Capacity);
            foreach (double s in thatList)
            {
                Console.WriteLine(s);
            }
        }

    }
}