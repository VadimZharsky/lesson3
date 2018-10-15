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
        List<string> sorted = new List<string>();
        public Playlist()
        {
        }
        public Playlist(List<string> bySong, List<string> byAuthor)
        {
            this.bySong = bySong;
            this.byAuthor = byAuthor;
            Observer(this.bySong, this.byAuthor);
            
        }
        public void Observer(List<string> bySong, List<string> byAuthor)
        {
            foreach (string s in byAuthor)
            {
                Console.WriteLine(s+" by Author");
            }
            foreach (string s in bySong)
            {
                Console.WriteLine(s + " by Song");
            }
            Song sent = new Song(bySong);


        }
        public void Sorting(List<string> forSort)
        {
            sorted = forSort;
            for (int i = sorted.Capacity-1; i >= 0; i--)
            {
                for (int j = 0; j < sorted.Capacity - 1; j++)
                {
                    string temp = sorted[j].ToLower();
                    string temp2 = sorted[j + 1].ToLower();
                    string forInsertFirst = EachCharSort(temp, temp2);
                    string forInsertSecond = (forInsertFirst == temp) ? temp2 : temp;
                    
                    sorted.Remove(sorted[j]);
                    sorted.Remove(sorted[j]);
                    sorted.Insert(j, forInsertSecond);
                    sorted.Insert(j, forInsertFirst);
                }  
            }
            foreach(string s in sorted)
                Console.WriteLine("::::::::::::"+s+":::::::::::::::");

        }
        private string EachCharSort(string one, string two)
        {
            int counter = 0;
            byte index, index2;
            int lengthOne = one.Length;
            int lengthTwo = two.Length;
            int maximum = (lengthOne < lengthTwo) ? lengthOne : lengthTwo;
            index = (byte)one[counter];
            index2 = (byte)two[counter];
            if (index < index2) { return one; }
            else if (index == index2)
            {
                return deepSort(one, two, counter, maximum);
            }
            else { return two; } 
        }

        private string deepSort(string one, string two, int counter, int maximum)
        {
            counter++;
            byte index, index2;
            index = (byte)one[counter];
            index2 = (byte)two[counter];
            bool match = (index == index2) ? true : false;
            if (match == true && counter < maximum-1) { return deepSort(one, two, counter, maximum); }
            else
            {
                if (index < index2) { return one; }
                else { return two; }
            }
        }
    }
}
