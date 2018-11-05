using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL6
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo dir = new DirectoryInfo(@"C:\Program Files\Autodesk");
            //string addedDir = @"C:\program FIles Copy";
            //GetInfoAboutDirectory(dir);
            //Console.WriteLine();
            //FileInfo firstFile = GetFileInfo(dir);
            //Directory.CreateDirectory(addedDir);
            //CopyFirstFile(addedDir,firstFile);
            Chatt.Chatting();
            Console.ReadKey();
        }

        private static void Chatting()
        {
            throw new NotImplementedException();
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
