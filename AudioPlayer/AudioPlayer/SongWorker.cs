using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    class SongWorker
    {
        List<string> genre = new List<string>();
        List<string> songNames = new List<string>();
        List<string> artist = new List<string>();
        List<string> year = new List<string>();
        List<double> duration = new List<double>();
        List<string> sorted = new List<string>();
        private int numSong;

        public int NumSong
        {
            get => numSong;
            set
            {
                if (value >= songNames.Count - 1)
                {
                    numSong = songNames.Count - 1;
                }
                else if (value < 0)
                {
                    numSong = 0;
                }
                else { numSong = value; }
            }
        }
        public void UploadSongs()
        {
            List<Song> songs = new List<Song>();
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
        }
        public string ToPlay()
        {
            Console.WriteLine($"Playing songs {songNames[numSong]}");
            return songNames[numSong];

        }
        public string PlayNext()
        {
            Console.WriteLine("Playing songs {songNames[numSong]}");
            return songNames[numSong+1];

        }
        public string PlayPrevious()
        {
            Console.WriteLine("Playing songs {songNames[numSong]}");
            return songNames[numSong-1];
        }
        public void ShowSongs()
        {
            Console.WriteLine("show :\n1.Songs\n2.Artists\n3.years\n4.genres");
            byte choise = Convert.ToByte(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Observer(songNames);
                    break;
                case 2:
                    Observer(artist);
                    break;
                case 3:
                    Observer(year);
                    break;
                case 4:
                    Observer(genre);
                    break;
            }
        }
        private void Observer(List<string> show)
        {
            foreach (string s in show)
                Console.WriteLine(s);
        }

        public void SortSongs()
        {
            Console.WriteLine("sort by :\n1.Song\n2.Artist\n3.year\n4.genre");
            byte choise = Convert.ToByte(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Sorting(songNames);
                    break;
                case 2:
                    Sorting(artist);
                    break;
                case 3:
                    Sorting(year);
                    break;
                case 4:
                    Sorting(genre);
                    break;
            }
        }
        public void Sorting(List<string> forSort)
        {
            sorted = forSort;
            for (int i = sorted.Capacity - 1; i >= 0; i--)
            {
                for (int j = 0; j < sorted.Capacity - 1; j++)
                {
                    string temp = sorted[j].ToLower();
                    string temp2 = sorted[j + 1].ToLower();
                    string forInsertFirst = EachCharSort(temp, temp2);
                    string forInsertSecond = (forInsertFirst == temp) ? temp2 : temp;

                    sorted.Remove(sorted[j]);
                    sorted.Remove(sorted[j]);
                    sorted.Insert(j, forInsertSecond);
                    sorted.Insert(j, forInsertFirst);
                }
            }
            foreach (string s in sorted)
                Console.WriteLine("::::::::::::" + s + ":::::::::::::::");

        }
        private string EachCharSort(string one, string two)
        {
            int counter = 0;
            byte index, index2;
            int lengthOne = one.Length;
            int lengthTwo = two.Length;
            int maximum = (lengthOne < lengthTwo) ? lengthOne : lengthTwo;
            index = (byte)one[counter];
            index2 = (byte)two[counter];
            if (index < index2) { return one; }
            else if (index == index2)
            {
                return deepSort(one, two, counter, maximum);
            }
            else { return two; }
        }

        private string deepSort(string one, string two, int counter, int maximum)
        {
            counter++;
            byte index, index2;
            index = (byte)one[counter];
            index2 = (byte)two[counter];
            bool match = (index == index2) ? true : false;
            if (match == true && counter < maximum - 1) { return deepSort(one, two, counter, maximum); }
            else
            {
                if (index < index2) { return one; }
                else { return two; }
            }
        }


    }
}
