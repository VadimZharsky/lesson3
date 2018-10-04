using System;
using System.Collections.Generic;

namespace player
{
    public class Song
    {
        public bool locked, isPlaying = false;
        
        public string songName, author, year, lyrics;
        List<string> received = new List<string>();
        public Song(string songName, string author, string year, string lyrics)
        {
            this.songName = songName;
            this.author = author;
            this.year = year;
            if (lyrics.Length > 0)
                this.lyrics = lyrics;
            else
                this.lyrics = "some lyrics";
            
        }
        public Song(List<string> received)
        {
            this.received = received;
            foreach(string str in this.received)
            Console.WriteLine(str+":received");
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
        public void Add(object newToPlay)
        {
            newToPlay.ToString();
        }
        private void Logger(string text)
        {
            Console.WriteLine(text);
        }


    }
}