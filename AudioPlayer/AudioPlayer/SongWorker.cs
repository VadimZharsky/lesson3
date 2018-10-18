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
            
            songs.Add(new Song() { songName = "sans rémission", artist = new Artist(), year = "1998", duration = 140, Genre = 0 });
            songs.Add(new Song() { songName = "In the name of Amun",artist = new Artist() { ArtistName="Nile"}, year = "2007", duration = 251, Genre = Song.genres.metal });
            songs.Add(new Song() { songName = "Static Cold", artist = new Artist() { ArtistName = "Frozen Autumn" }, year = "2014", duration = 187, Genre = Song.genres.Minimalsynth|Song.genres.wave });
            songs.Add(new Song() { songName = "Hinterland", artist = new Artist() { ArtistName = "Linea Aspera" }, year = "2005", duration = 134, Genre = Song.genres.Minimalsynth | Song.genres.wave });
            songs.Add(new Song() { songName = "Anybody", artist = new Artist() { ArtistName = "Curren$y" }, year = "2000", duration = 274, Genre = Song.genres.hiphop });
            songs.Add(new Song() { songName = "L'été indien",album = new Album(), artist = new Artist() { ArtistName = "Joe Dassin" }, year = "1990", duration = 225, Genre = Song.genres.pop });
            songs.Add(new Song() { songName = "Im Wasser", artist = new Artist() { ArtistName = "Schwefelgelb" }, year = "2016", duration = 533, Genre = Song.genres.ebm|Song.genres.Minimalsynth });
            songs.Add(new Song() { songName = "Orkidea", artist = new Artist() { ArtistName = "Kauan" }, year = "2010", duration = 421, Genre = Song.genres.rock|Song.genres.ambient });
            songs[0].album = new Album() { AlbumName = "Si dieu veut" };
            songs[1].album = new Album() { AlbumName = "What Should Not Be Unearthed" };
            songs[2].album = new Album() { AlbumName = "Is Anybody There?"};
            songs[3].album = new Album() { AlbumName = "Linea Aspera" };
            songs[4].album = new Album() { AlbumName = "Andretti 9/30" } ;
            songs[6].album = new Album() { AlbumName = "Den Umgekehrten Atem" };
            songs[7].album = new Album() { AlbumName = "Tietäjän laulu" };
            songs[0].lyrics = "Pour tous les quartiers de Marseille, sans rémission";
            songs[1].lyrics = "In the name of the God Amun I wage war";
            songs[2].lyrics = "On the ground Alone in static cold";
            songs[3].lyrics = "Let me tread your wilderness";
            songs[4].lyrics = "Exotics and low riders front my house I dreamed about it";
            songs[5].lyrics = "et l'on s'aimera encore, lorsque l'amour sera mort";
            songs[6].lyrics = "";
            songs[7].lyrics = "Hylätty. Sumun kuristama. Ilman sielua";
            songsToPlay = songs.SongsToPlay();
            IfLiked(songsToPlay);
        }

        private void IfLiked(List<Song> songsToPlay)
        {
            Random rnd = new Random();
            string[] liked = new string[] { "True", "False"};
            foreach (Song song in songsToPlay)
            {
                song.like = Convert.ToBoolean(liked[rnd.Next(0,2)]);
            }
        }

        public void ToPlay()
        {
            if (songsToPlay.Count > 0)
            {
                
                playOrNot = true;
                //Console.WriteLine(GetSongData(songsToPlay[numSong])); 
                if (songsToPlay[NumSong].like) { Console.BackgroundColor = ConsoleColor.DarkRed; }
                else { Console.BackgroundColor = ConsoleColor.DarkGray; }
                Console.WriteLine(GetsongData(songsToPlay[NumSong]));
            }
            else { NoSongs(); }

        }

        private string GetsongData(Song song)
        {
            
            string inminutes = Convert.ToString((int)song.duration / 60);
            string inseconds = Convert.ToString((int)song.duration % 60);
            return $"Song: {song.songName}\n{inminutes}.{inseconds}\nArtist: {song.artist.ArtistName}\nAlbum: {song.album.AlbumName}\n" +
                $"Year: {song.year}\nGenre: {song.Genre.ToString()}\nLyrics: {song.lyrics}";
        }

        Tuple<string, string, string, string, string, string> GetSongData(Song songsToPlay)
        {
            string inminutes = Convert.ToString((int)songsToPlay.duration / 60);
            string inseconds = Convert.ToString((int)songsToPlay.duration % 60); 
            return new Tuple<string, string, string, string, string, string>(
                songsToPlay.songName, songsToPlay.artist.ArtistName, songsToPlay.year, songsToPlay.Genre.ToString(), inminutes+" minutes", inseconds+" seconds");
        }

        internal void Clear()
        {
            songsToPlay.Clear();
            Console.WriteLine("current playlist has been deleted. Reload please");
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
                            Console.WriteLine(song.artist.ArtistName);
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
                Console.WriteLine("search in :\n1.Songs\n2.Artists\n3.years\n4.genres");
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
                Console.WriteLine($"Input searching {searchParam} to make a playlist");
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
