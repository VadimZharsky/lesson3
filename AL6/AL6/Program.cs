using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace AL6
{
    class Program
    {
        public delegate void serializ<T>(T item);

        static void Main(string[] args)
        {
            //DirectoryInfo dir = new DirectoryInfo(@"C:\Program Files\Autodesk");
            //string addedDir = @"C:\program FIles Copy";
            //GetInfoAboutDirectory(dir);
            //Console.WriteLine();
            //FileInfo firstFile = GetFileInfo(dir);
            //Directory.CreateDirectory(addedDir);
            //CopyFirstFile(addedDir,firstFile);
            //Chatt.Chatting();
            serializ<Song> del = ConsoleSrlz;
            del += FileSrlz;


            Song song = new Song() { title = "primiere chanson", author = "some author", duration = 334, year = "2018" };
            del(song);

            Console.ReadKey();
        }

        private static void ConsoleSrlz(Song song)
        {
            
            XmlSerializer xs = new XmlSerializer(typeof(Song));
            MemoryStream memory = new MemoryStream();
            string str = "";
            xs.Serialize(Console.Out, song);
            xs.Serialize(memory, song);
            byte[] bytes = memory.GetBuffer();
            foreach (byte b in bytes)
                str+=(char)b;
            StringReader reader = new StringReader(str);
            Song anotherSong = null;
            anotherSong = (Song)xs.Deserialize(reader);
            Console.WriteLine($"another song is:::{anotherSong.title}:::{anotherSong.author}:::{anotherSong.year}:::{anotherSong.year}:::{anotherSong.duration}");
        }


        private static void FileSrlz(Song song)
        {
            FileStream fs = new FileStream("srlz.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Song));
            xs.Serialize(fs, song);
            fs.Close();
            StreamReader reader = new StreamReader("srlz.txt");
            string s = reader.ReadToEnd();
            StringReader stringReader = new StringReader(s);
            Song thatSong =(Song) xs.Deserialize(stringReader);
            Console.WriteLine(s);
        
            Console.WriteLine($"that song is:::{thatSong.title}:::{thatSong.author}:::{thatSong.year}:::{thatSong.year}:::{thatSong.duration}");
        }



        private static void GetInfoAboutDirectory(DirectoryInfo dir)
        {
            Console.WriteLine("Name: {0}\nCreation time : {1}",dir.Name, dir.CreationTime);
        }
        private static FileInfo GetFileInfo(DirectoryInfo dir)
        {
            List<FileInfo> files = new List<FileInfo>(dir.GetFiles("*.",SearchOption.AllDirectories));
            foreach (FileInfo file in files)
            {
                Console.WriteLine("FileName: {0}\nCreationTime: {1}\nSize: {2} bytes",file.Name,file.CreationTime, file.Length);
            }
            return files[files.Count-1];
        }
        private static void CopyFirstFile(string addedDir, FileInfo firstFile)
        {
            try
            {
                string path = Path.Combine(addedDir, firstFile.Name);
                firstFile.CopyTo(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}
