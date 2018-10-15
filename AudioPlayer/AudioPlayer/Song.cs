using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    class Song
    {
        public enum genres
        {
            pop, rock, metal, alternative, hiphop, edm, ebm, wave, synth, ambient
        }
        public string songName { get; set; }
        public string artist { get; set; }
        public string year { get; set; }
        public string lyrics{ get; set; }
        private string genre;
        public double duration { get; set; }

        public string Genre
        {
            get { return genre; }
            set
            {
                if (genres.alternative.ToString() == value) { genre = "alternative"; }
                if (genres.metal.ToString() == value) { genre = "metal"; }
                if (genres.hiphop.ToString() == value) { genre = "hiphop"; }
                if (genres.edm.ToString() == value) { genre = "edm"; }
                if (genres.ebm.ToString() == value) { genre = "ebm"; }
                if (genres.wave.ToString() == value) { genre = "wave"; }
                if (genres.pop.ToString() == value) { genre = "pop"; }
                if (genres.rock.ToString() == value) { genre = "rock"; }
                if (genres.synth.ToString() == value) { genre = "synth"; }
                if (genres.ambient.ToString() == value) { genre = "ambient"; }
            }
        }
    }
}