using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StringFormatter.Program;

namespace StringFormatter
{
    static class StringExtension
    {
        public static List<string> StringWorker(this stringFormatter formatter, List<string> list)
        {
            List<string> vs = new List<string>(5);
            for (int i = 0; i < list.Count; i++)
            {
                formatter = ToUpperCase;
                string s = formatter(list[i]);
                formatter = ReplaceSpaceToUnderscore;
                s = formatter(s);
                vs.Add(s);
            }
            return vs;
        }

        public static string ToUpperCase(string str)
        {
            string temp = str.ToUpper();
            return temp;
        }
        public static string ReplaceSpaceToUnderscore(string str)
        {
            if (str.Contains(' '))
            {
                string temp = str.Replace(' ', '_');
                return temp;
            }
            return str;
        }

    }
}
