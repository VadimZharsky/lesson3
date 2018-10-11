using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7_HomeWork_
{
    class NeighbourCreator
    {
        public static void Creator()
        {
            List<Neighbour> floorNeighbours = new List<Neighbour>();
            floorNeighbours.Add(new Neighbour() { FullName=  "Иванов Иван", FlatNumber="74", PhoneNumber="3457845"});
            floorNeighbours.Add(new Neighbour() { FullName = "Светова Света", FlatNumber = "75", PhoneNumber = "3407212" });
            floorNeighbours.Add(new Neighbour() { FullName = "Грецкий Олег", FlatNumber = "76", PhoneNumber = "3415564" });
            floorNeighbours.Add(new Neighbour() { FullName = "Летунова Жанна", FlatNumber = "77", PhoneNumber = "3415520" });
            floorNeighbours.Add(new Neighbour() { FullName = "Патриархатов Кирилл", FlatNumber = "78", PhoneNumber = "3451718" });
            floorNeighbours.Add(new Neighbour() { FullName = "Ситник Ксения", FlatNumber = "79", PhoneNumber = "3401468" });
            floorNeighbours.Add(new Neighbour() { FullName = "Ярмоленко Анатолий", FlatNumber = "80", PhoneNumber = "3419952" });
            floorNeighbours.Add(new Neighbour() { FullName = "Тимошенко Юлия", FlatNumber = "81", PhoneNumber = "3451212" });
            floorNeighbours.Add(new Neighbour() { FullName = "Бандера Степан", FlatNumber = "82", PhoneNumber = "3450045" });
            floorNeighbours.Add(new Neighbour() { FullName = "Лепэн Марин", FlatNumber = "83", PhoneNumber = "3413451" });
            floorNeighbours.Add(new Neighbour() { FullName = "", FlatNumber = "84", PhoneNumber = "" });

            FindYourFriends(floorNeighbours);
            
        }

        public static void TryingDictionary()
        {
            Dictionary<int, Neighbour> neighbourHood= new Dictionary<int, Neighbour>();

            neighbourHood.Add(74, new Neighbour() { FullName = "Иванов Иван", PhoneNumber = "3457845" });
            neighbourHood.Add(75, new Neighbour() { FullName = "Светова Света", PhoneNumber = "3407212" });
            neighbourHood.Add(76, new Neighbour() { FullName = "Грецкий Олег", PhoneNumber = "3415564" });
            neighbourHood.Add(77, new Neighbour() { FullName = "Летунова Жанна", PhoneNumber = "3415520" });
            neighbourHood.Add(78, new Neighbour() { FullName = "Патриархатов Кирилл", PhoneNumber = "3451718" });
            neighbourHood.Add(79, new Neighbour() { FullName = "Ситник Ксения", PhoneNumber = "3401468" });
            neighbourHood.Add(80, new Neighbour() { FullName = "Ярмоленко Анатолий", PhoneNumber = "3419952" });
            neighbourHood.Add(81, new Neighbour() { FullName = "Тимошенко Юлия", PhoneNumber = "3451212" });
            neighbourHood.Add(82, new Neighbour() { FullName = "Бандера Степан", PhoneNumber = "3450045" });
            neighbourHood.Add(83, new Neighbour() { FullName = "Лепэн Марин", PhoneNumber = "3413451" });
            neighbourHood.Add(84, new Neighbour() { FullName = "", PhoneNumber = "" });
            FindByDictionary(neighbourHood);
        }

        private static void FindByDictionary(Dictionary<int, Neighbour> neighbourHood)
        {
            Program.Texter("Input a flat number to get an info about neighbour");
            int flat = Convert.ToInt16(Console.ReadLine());
            if (neighbourHood.ContainsKey(flat))
            {
                Program.Texter($"Neighbour's fullname: {neighbourHood[flat].FullName}\nHis phone number: {neighbourHood[flat].PhoneNumber}");
            }
            else { Program.Texter("this flat doesn't exist in a database"); }
        }

        private static void FindYourFriends(List<Neighbour>floorNeighbours)
        {
            //friend is too close...
            // uno secondo per favore
            Program.Texter("Input a flat number to get an info about neighbour");
            string flat = Convert.ToString(Console.ReadLine());
            bool isShowed = false;
            foreach (Neighbour neighbour in floorNeighbours)
            {
                
                if (neighbour.FlatNumber.Contains(flat))
                {
                    Program.Texter($"Neighbour's fullname: {neighbour.FullName}\nHis phone number: {neighbour.PhoneNumber}");
                    isShowed = true;
                }
            }
            if (isShowed == false) { Program.Texter("this flat doesn't exist in a database"); }
        }
    }
}
