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
        public List<string> artists = new List<string>();
        public string ArtistName
        {
            get
            {
                if (artistName == null) { return "Unknown artist"; }
                else { return artistName; }
            }
            set
            {
                artistName = value;
                if (artists.Contains(artistName))
                {
                    artists.Add(artistName);
                }
            }
        }
    }
}
