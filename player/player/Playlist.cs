using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player
{
     class Playlist
    {
        List<string> bySong = new List<string>();
        List<string> byAuthor = new List<string>();

        public Playlist()
        {
        }
        public Playlist(List<string> bySong, List<string> byAuthor)
        {
            this.bySong = bySong;
            this.byAuthor = byAuthor;

        }
        public void Observer()
        {
            foreach (string s in byAuthor)
            {
                Console.WriteLine(s);
            }
            foreach (string s in bySong)
            {
                Console.WriteLine(s);
            }
            Song sent = new Song(bySong);
        }
    }
}
