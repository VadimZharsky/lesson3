using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player
{
    class Program
    {
        static void Main(string[] args)
        {
            Song [] songs = new Song[34];
            songs[0] = new Song();
            songs[1] = new Song();
             Console.WriteLine(songs[0].locked);
            songs[0].Lock();
            Console.WriteLine(songs[0].locked);
            Console.ReadKey();

        }
    }
}
