using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    class SongWorker
    {
        List<Song> songs = new List<Song>();
        
        List<Song> songsToPlay = new List<Song>();

        private bool playOrNot = false;
        private int numSong;

        public int NumSong
        {
            get
            { return numSong; }
            set
            {
                if (value >= songsToPlay.Count - 1) { numSong = songsToPlay.Count - 1; }
                else if (value < 0) { numSong = 0; }
                else { numSong = value; }
            }
        }
        public void UploadSongs()
        {
            
            songs.Add(new Song() { songName = "aux absents", artist = "FonkyFamily", year = "1998", duration = 140, Genre = 0 });
            songs.Add(new Song() { songName = "In the name of Amun",artist = "Nile", year = "2007", duration = 251, Genre = Song.genres.metal });
            songs.Add(new Song() { songName = "drowning", artist = "Sixth June", year = "2014", duration = 187, Genre = Song.genres.Minimalsynth|Song.genres.wave });
            songs.Add(new Song() { songName = "Younger Dryas", artist = "Linea Aspera", year = "2005", duration = 134, Genre = Song.genres.Minimalsynth | Song.genres.wave });
            songs.Add(new Song() { songName = "Anybody", artist = "Currensy", year = "2000", duration = 274, Genre = Song.genres.hiphop });
            songs.Add(new Song() { songName = "Solitude depth", artist = "Sterbend", year = "1990", duration = 225, Genre = Song.genres.metal });
            songs.Add(new Song() { songName = "Im Wasser", artist = "Schwefelgelb", year = "2016", duration = 533, Genre = Song.genres.ebm|Song.genres.Minimalsynth });
            songs.Add(new Song() { songName = "Orchidea", artist = "Kauan", year = "2010", duration = 421, Genre = Song.genres.rock|Song.genres.ambient });
            songsToPlay = songs.SongsToPlay();
        }
        public void ToPlay()
        {
            if (songsToPlay.Count > 0)
            {

                playOrNot = true;
                Console.WriteLine(GetSongData(songsToPlay[numSong]));   
            }
            else { NoSongs(); }

        }
        Tuple<string, int, int, string, string, string> GetSongData(Song songsToPlay)
        {
            int inminutes = (int)songsToPlay.duration / 60;
            int inseconds = (int)songsToPlay.duration % 60;
            return new Tuple<string, int, int, string, string, string>(songsToPlay.songName, inminutes, inseconds, songsToPlay.artist, songsToPlay.year, songsToPlay.Genre.ToString());
        }
        public  void Stop()
        {
            playOrNot = false;
        }
        public void PlayNext()
        {
            if (numSong + 1 < songsToPlay.Count && playOrNot == true) { numSong++; }
            if (playOrNot) { ToPlay(); }
        }
        public void PlayPrevious()
        {
            if (numSong - 1 >= 0 && playOrNot == true) { numSong--; }
            if (playOrNot) { ToPlay(); }
        }
        public void ShowSongs()
        {
            if (songsToPlay.Count > 0)
            {
                Console.WriteLine("show :\n1.Songs\n2.Artists\n3.years\n4.genres\n5.Duration");
                byte choise = Convert.ToByte(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        foreach (Song song in songsToPlay)
                            Console.WriteLine(song.songName);
                        break;
                    case 2:
                        foreach (Song song in songsToPlay)
                            Console.WriteLine(song.artist);
                        break;
                    case 3:
                        foreach (Song song in songsToPlay)
                            Console.WriteLine(song.year);
                        break;
                    case 4:
                        foreach (Song song in songsToPlay)
                            Console.WriteLine(song.Genre);
                        break;
                    case 5:
                        foreach (Song song in songsToPlay)
                            Console.WriteLine(song.duration);
                        break;
                }
            
            }
            else { NoSongs(); }
        }
        public void SortSongs()
        {
            if (songsToPlay.Count > 0)
            {
                Console.WriteLine("sort by :\n1.Song\n2.Artist\n3.year\n4.genre\n5.Duration");
                byte choise = Convert.ToByte(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        songsToPlay = songsToPlay.SongsToPlay(1);
                        break;
                    case 2:
                        songsToPlay = songsToPlay.SongsToPlay(2);
                        break;
                    case 3:
                        songsToPlay = songsToPlay.SongsToPlay(3);
                        break;
                    case 4:
                        songsToPlay = songsToPlay.SongsToPlay(4);
                        break;
                    case 5:
                        songsToPlay = songsToPlay.SongsToPlay(5);
                        break;
                }
            }
            else { NoSongs(); }

        }

        public void sortByWord()
        {
            if (songsToPlay.Count > 0)
            {
                Console.WriteLine("search by :\n1.Songs\n2.Artists\n3.years\n4.genres");
                byte choise = Convert.ToByte(Console.ReadLine());
                string searchParam = "";
                switch (choise)
                {
                    case 1:
                        searchParam = "songName";
                        break;
                    case 2:
                        searchParam = "artist";
                        break;
                    case 3:
                        searchParam = "year";
                        break;
                    case 4:
                        searchParam = "genre";
                        break;
                }
                Console.WriteLine($"Insert searching {searchParam} to make a playlist");
                string searchWord = Convert.ToString(Console.ReadLine());
                songsToPlay = songsToPlay.sortBySongList(searchParam, searchWord);
            }
            else { NoSongs(); }

        }

        public void ShuffleSongs()
        {
            if (songsToPlay.Count > 0)
                songsToPlay = songsToPlay.ShuffleList();
            else { NoSongs(); }
        }
        private void NoSongs()
        { Console.WriteLine("there is no any song.please before upload songs"); }
    }
}
