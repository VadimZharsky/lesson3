﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    class Playlist
    {
        public static List<Song> SongsToPlay(List<Song> songs)
        {
            return songs;
        }

        public static List<Song> SongsToPlay(List<Song> songsToPlay, int choise)
        {
            switch (choise)
            {
                case 1:
                    songsToPlay = songsToPlay.OrderBy(obj=>obj.songName).ToList();
                    break;
                case 2:
                    songsToPlay = songsToPlay.OrderBy(obj => obj.artist).ToList();
                    break;
                case 3:
                    songsToPlay = songsToPlay.OrderBy(obj => obj.year).ToList();
                    break;
                case 4:
                    songsToPlay = songsToPlay.OrderBy(obj => obj.Genre).ToList();
                    break;
                case 5:
                    songsToPlay = songsToPlay.OrderBy(obj => obj.duration).ToList();
                    break;
            }
            return songsToPlay;
        }

        public static List<Song> ShuffleList(List<Song> songsToPlay)
        {
            List<Song> tempList = new List<Song>();
            Random rnd = new Random();
            string s = "";
            string str = "";
            for (int i = 0; i < songsToPlay.Count; i++)
                s += i;
            while (str.Length < s.Length)
            {
                string x = rnd.Next(0, s.Length).ToString();
                if (!str.Contains(x))
                {
                    str += x;
                    tempList.Add(songsToPlay[Convert.ToInt32(x)]);
                }

            }
            return tempList;
        }
        public static List<Song> sortBySongList(List<Song> songsToPlay, string searchParam, string searchWord)
        {
            List<Song> selectedList = new List<Song>();
            switch (searchParam)
            {
                case "songName":
                    foreach (Song song in songsToPlay)
                    {
                        if (song.songName == searchWord)
                            selectedList.Add(song);
                    }
                    break;
                case "artist":
                    foreach (Song song in songsToPlay)
                    {
                        if (song.artist == searchWord)
                            selectedList.Add(song);
                    }
                    break;
                case "year":
                    foreach (Song song in songsToPlay)
                    {
                        if (song.year == searchWord)
                            selectedList.Add(song);
                    }
                    break;
                case "genre":
                    foreach (Song song in songsToPlay)
                    {
                        if (song.Genre == searchWord)
                            selectedList.Add(song);
                    }
                    break;
            }
            Console.WriteLine($"Found nexts songs \"{searchWord}\" in {searchParam}:");
            foreach (Song song in selectedList)
                Console.WriteLine($"   {song.songName}");

            return selectedList;
        }
    }
}
