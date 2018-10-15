using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7_HomeWork_
{
    class Program
    {
        static void Main(string[] args)
        {
            Texter("Select a task number:\n3.Task 3\n4.Task 4\n5.Task 5");
            byte choise = Convert.ToByte(Console.ReadLine());
            if (choise == 3) { TaskOne(); }
            if (choise == 4) { NeighbourCreator.Creator(); }
            if (choise == 5) { NeighbourCreator.TryingDictionary(); }

            Console.ReadKey();
            
        }

        private static void TaskOne()
        {
            List<Song> songs = new List<Song>();
            SongCreator(songs);
            for (int i = 0; i < songs.Count; i++)
                Texter($"that is Lyrics for song#{i + 1}:\n{songs[i].Lyrics}\n::::::::::::::::");
        }
        private static void SongCreator(List<Song> songs)
        {
            Random rnd = new Random();
            for (int i = 0; i <=4; i++)
                songs.Add(new Song());   
            songs[0].Lyrics = LyricsCreator(rnd);
            songs[1].Lyrics = LyricsCreator(rnd);
            songs[2].Lyrics = LyricsCreator(rnd);
            songs[3].Lyrics = LyricsCreator(rnd);
            songs[4].Lyrics = LyricsCreator(rnd);
        }
        private static string LyricsCreator(Random rnd)
        {

            string line = "цй укеооонллгшщ зхллъфыв атттпр олд жэоячс мить бю.";
            string paroles = "";
            for (int i = 0; i < (rnd.Next(4, 8)); i++)
            {
                for (int j = 0; j <= (rnd.Next(20, 50)); j++)
                    paroles += line[rnd.Next(0, line.Length - 1)];
                paroles += ",\n";
            }
            return paroles;
        }
        public static void Texter(string text)
        {
            Console.WriteLine(text);
        }
    }
}
