using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7_arrayList_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List <char> chars = new List<char>();
            var point = new ArrayList();
            point.Add("sdsd");
            point.Add("sedc");
            point.Add("nbhng");
            point.Add("yryrtt");
            foreach (var s in point)
                Console.WriteLine(s);
            Console.WriteLine("------------------");
            point.Sort();
            
            object[] arr = (object[])point.ToArray(typeof(object));
            foreach (object ob in arr)
            {
                var s = new Song() { Lyrics = ob.ToString()};
                Console.WriteLine(s.Lyrics); 
            }
           
            Console.ReadKey();
                
  
        }
        
    }
}
