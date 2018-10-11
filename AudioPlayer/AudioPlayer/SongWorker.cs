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
        List<string> genre = new List<string>();
        List<string> songNames = new List<string>();
        List<string> artist = new List<string>();
        List<string> year = new List<string>();
        List<double> duration = new List<double>();
        List<string> sorted = new List<string>();
        private bool playOrNot = false;
        private int numSong;

        public int NumSong
        {
            get
            {return numSong;}
            set
            {
                if (value >= songNames.Count - 1){ numSong = songNames.Count - 1;}
                else if (value < 0) {numSong = 0;}
                else { numSong = value; }
            }
        }
        public void UploadSongs()
        {
            
            songs.Add(new Song("aux absents", "FonkyFamily", "1998", "", "hiphop", 4.25));
            songs.Add(new Song("In the name of Amun", "Nile", "2007", "", "technicalDeath", 3.44));
            songs.Add(new Song("drowning", "Sixth June", "2014", "", "minimalSynth/darkwave", 5.14));
            songs.Add(new Song("More days to come", "e-life", "2001", "", "hiphop", 2.25));
            songs.Add(new Song("Anybody", "Currensy", "2000", "", "hiphop", 3.14));
            songs.Add(new Song("Solitude depth", "Sterbend", "1990", "", "dsbm", 3.40));
            songs.Add(new Song("Keep Rising", "Group Home", "2016", "", "hiphop", 4.13));
            songs.Add(new Song("Orchidea", "Kauan", "2010", "", "atmospheric doom/dark", 5.57));
            for (int i = 0; i < songs.Count; i++)
            {
                songNames.Add(songs[i].songName);
                artist.Add(songs[i].artist);
                year.Add(songs[i].year);
                genre.Add(songs[i].genre);
                duration.Add(songs[i].duration);
            }
            songsToPlay = Playlist.SongsToPlay(songs);
        }
        public string ToPlay()
        {
            if (songsToPlay.Count > 0)
            {
                playOrNot = true;
                return $"Playing song: {songsToPlay[numSong].songName} {{{numSong}}}";    
            }
            else { return "there is no any song.please before upload songs"; }
            
        }
        public  void Stop()
        {
            playOrNot = false;
        }
        public string PlayNext()
        {
            if (numSong + 1 < songs.Count && playOrNot == true) { numSong++; }
            return $"Playing song: {songsToPlay[numSong].songName} {{{numSong}}}";
        }
        public string PlayPrevious()
        {
            if (numSong - 1 >= 0 && playOrNot == true) { numSong--; }
            return $"Playing song: {songsToPlay[numSong].songName} {{{numSong}}}";
        }
        public void ShowSongs()
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
                        Console.WriteLine(song.genre);
                    break;
                case 5:
                    foreach (Song song in songsToPlay)
                        Console.WriteLine(song.duration);
                    break;
            }
        }
        public void SortSongs()
        {
            
            Console.WriteLine("sort by :\n1.Song\n2.Artist\n3.year\n4.genre\n5.Duration");
            byte choise = Convert.ToByte(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    songsToPlay = Playlist.SongsToPlay(songsToPlay, 1);
                    break;
                case 2:
                    songsToPlay = Playlist.SongsToPlay(songsToPlay, 2);
                    break;
                case 3:
                    songsToPlay = Playlist.SongsToPlay(songsToPlay, 3);
                    break;
                case 4:
                    songsToPlay = Playlist.SongsToPlay(songsToPlay, 4);
                    break;
                case 5:
                    songsToPlay = Playlist.SongsToPlay(songsToPlay, 5);
                    break;
            }
        }

        internal void ShuffleSongs()
        {
            songsToPlay = Playlist.ShuffleList(songsToPlay);
        }
    }
}
