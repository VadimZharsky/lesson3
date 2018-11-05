using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesCalc
{
    public static class StringWorker
    {
        public static List<string> StringWorkerMethod(List<string>toWork)
        {
            List<string> sorting = new List<string>();
            foreach (string s in toWork)
            {
                sorting.Add(s.ToUpper());
            }

                
            return sorting;
        }
        public static List<string> SpaceThroughLetter(List<string> toWork)
        {
            List<string> sorting = new List<string>();
            foreach (string s in toWork)
            {
                string temp = Splitter(s);
                sorting.Add(temp);
            }


            return sorting;
        }

        private static string Splitter(string s)
        {
            string temp = "";
            foreach (char c in s)
            {
                temp += $"{c} ";
            }
            return temp;
        }
    }
}
