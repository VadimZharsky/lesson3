using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    class Artist
    {
        private string artistName;

        public string ArtistName
        {
            get
            {
                if (artistName.Length == 0) { return "Unknown artist"; }
                else { return artistName; }
            }
            set { artistName = value; }
        }
    }
}
