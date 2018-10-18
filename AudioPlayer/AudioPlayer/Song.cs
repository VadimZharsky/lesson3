using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    class Song
    {
        [Flags]
        public enum genres
        {
            pop = 1,
            rock = 2,
            metal = 4,
            alternative = 8,
            hiphop = 16,
            edm = 32,
            ebm = 64,
            wave = 128,
            Minimalsynth = 512,
            ambient = 1024,
            notDefined = 2048
        }
        public string songName { get; set; }
        public Artist artist { get; set; }
        public string year { get; set; }
        public Album album { get; set; }
        public string lyrics{ get; set; }
        private genres genre;
        public double duration { get; set; }
        public bool like { get; set; }

        public genres Genre
        {
            get
            {
                if (genre == 0)
                { return genres.notDefined; }
                else { return genre; }
            }
            set
            {
                genre = value;
            }
        }
    }
}