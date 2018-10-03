using System;
using System.Collections.Generic;

namespace player
{
    public class Song
    {
        public bool locked, isPlaying = false;
        
        public string songName, author, year, lyrics;

        public Song(string songName, string author, string year, string lyrics)
        {
            this.songName = songName;
            this.author = author;
            this.year = year;
            if (lyrics.Length > 0)
                this.lyrics = lyrics;
            else
                this.lyrics = "some lyrics";
            new Playlist(songName, author, year, lyrics);
            SongAdded(this.songName, this.author, this.year,this.lyrics);
        }
        public bool Lock()
        {
            Logger("player was locked");
            return locked = true;
        }
        public bool Unlock()
        {
            Logger("player was unlocked");
            return locked = false;
        }
        public bool Play()
        {
            if (!locked)
            {
                Logger("play mode is activated");
                return isPlaying = true;
            }
            else
            {
                Logger("play mode is unavaible while locked");
                return isPlaying = false;
            }
            
        }
        void Logger(string text)
        {
            Console.WriteLine(text);
        }
        private Playlist SongAdded(string songName, string author, string year, string lyrics)
        {
            return new Playlist (songName, author, year, lyrics);
        }


    }
}