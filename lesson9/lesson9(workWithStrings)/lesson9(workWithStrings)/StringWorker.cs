using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9_workWithStrings_
{
    static class StringWorker
    {
        public static string Worker(this string line)
        {
            if(line.Length>13)
                return $"{line.Remove(13,line.Length-13)}...";
            return line;
            
        }
    }
}
