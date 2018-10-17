using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    class Album
    {
        private string albumName;
        public string AlbumName
        {
            get
            {
                if (albumName.Length == 0) { return "Unknown album"; }
                else { return albumName; }
            }
            set { albumName = value; }
        }
    }
}
