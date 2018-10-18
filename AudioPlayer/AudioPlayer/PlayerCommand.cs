using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
     class PlayerCommand
    {
        public static List<string> keys = new List<string>(4)
        { "lock", "unlock","volume", "setvolume",  "volumeup", "volumeDown","uploadSongs", "sortSongs",
            "shuffle","sortBy","showSongs", "play","playNext","playPrevious","clear", "stop", "exit"};
        
        
        public static void Command()
        {
            PlayerProperties defaults = new PlayerProperties();
            SongWorker songWorker = new SongWorker();
            defaults.Volume = 50;
            Texter("Player Command 1.0.0.0\nFor more information tap <help> below...\n");
            foreach (string s in keys)
                Texter($" :: <{s}> ::\n");
            Management(defaults, songWorker);
        }
        private static void Management(PlayerProperties properties, SongWorker worker)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Texter("\nplayerCommand/keys/");
            string cmd = Convert.ToString(Console.ReadLine());
            Switcher(cmd, properties, worker);
            Management(properties, worker);
            
        }

        private static void Switcher(string cmd, PlayerProperties properties, SongWorker worker)
        {
            
            
            switch (cmd)
            {
                case "lock":
                    {
                        properties.LockPlay();
                        Texter("Player was loked");
                        break;
                    }
                case "unlock":
                    {
                        properties.UnlockPlay();
                        Texter("Player was unloked");
                        break;
                    }
                case "play":
                    {
                        properties.Play();
                        if (properties.IsPlaying() == true)
                        {
                            worker.ToPlay();
                        }
                        else { Texter("impossible action. Player was locked"); }
                        break;
                    }
                case "stop":
                    {
                        properties.Stop();
                        worker.Stop();
                        break;
                    }
                case "volume":
                    {
                        Texter($"now volume is  {properties.Volume}");
                        break;
                    }
                case "setVolume":
                    {
                        string temp = SetVolume(properties);
                        if (temp == "1") { Texter("incorrect input data"); }
                        else
                        {
                            Texter($"now volume is  {temp}");
                        } 
                        break;
                    }
                case "volumeUp":
                    {
                        properties.VolumeUp();
                        Texter($"now volume is  {properties.Volume}");
                        break;
                    }
                case "volumeDown":
                    {
                        properties.VolumeDown();
                        Texter($"now volume is  {properties.Volume}");
                        break;
                    }
                case "help":
                    {
                        helper();
                        break;
                    }
                case "exit":
                    {  
                        Texter("please, tap any key to exit");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    }
                case "uploadSongs":
                    {
                        worker.UploadSongs();
                        Texter("All songs were uploaded");
                        break;
                    }
                case "sortSongs":
                    {
                        worker.SortSongs();
                        break;
                    }
                case "shuffle":
                    {
                        worker.ShuffleSongs();
                        break;
                    }
                case "sortBy":
                    {
                        worker.sortByWord();
                        break;
                    }
                case "showSongs":
                    {
                        worker.ShowSongs();
                        
                        break;
                    }
                case "playNext":
                    {
                        worker.PlayNext();
                        break;
                    }
                case "playPrevious":
                    {
                        worker.PlayPrevious();
                        break;
                    }
                case "clear":
                    {
                        worker.Clear();
                        break;
                    }
                default:
                    Texter("not authorized command");
                    break;                    
            }
        }

        private static string SetVolume(PlayerProperties properties)
        {
            Texter("set new volume level: ");
            string temp = Convert.ToString(Console.ReadLine());
            try
            {
                byte level = Convert.ToByte(temp);
                properties.Volume = level;
                return properties.Volume.ToString();
            }
            catch { return "1";}           
        }
        private static void Texter(string text)
        {
            Console.Write(text);
        }
        private static void helper()
        {
            Texter("lock - установка блокировки плеера\n");
            Texter("unlock - снятие блокировки плеера\n");
            Texter("volume - текущий уровень громкости\n");
            Texter("setVolume - установить новое значение громкости\n");
            Texter("volumeUp - повысить уровень громкости на 1\n");
            Texter("volumeDown - понизить уровень громкости на 1\n");
            Texter("uploadSongs - загрузить песни\n");
            Texter("sortSongs - обычная сортировка\n");
            Texter("shuffle - произвольный плейлист\n");
            Texter("sortBy - искать по критерию\n");
            Texter("showSongs - вывести актуальный плейлист\n");
            Texter("play - воспроизведение\n");
            Texter("playNext - играть следующую\n");
            Texter("playPrevious - играть предыдущую\n");
            Texter("clear - удалить текущий плейлист\n");
            Texter("stop - стоп\n");
            Texter("exit - выйти из программы\n");
        }
    }
}
