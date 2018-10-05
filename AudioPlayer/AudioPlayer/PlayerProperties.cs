using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public class PlayerProperties
    {
        private double volume;
        
        public double Volume
        {
            get { return volume; }
            set
            {
                if (value > 0)
                {
                    if (value > 100) { volume = 100; }
                    else { volume = value; }
                }
                else { volume = 0; }
            }
        }
    }
}
