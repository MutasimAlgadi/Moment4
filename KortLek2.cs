using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Moment4
{
    internal class KortLek2
    {

        public  void Kortlek2()
        {
            Dictionary<string, int> kortlek = SkapaKortlek();
            Random slumpGenerator = new Random();
            int antalPar = 0;

            Console.WriteLine("Drar två kort från kortleken:");

            for (int i = 0; i < 1000; i++)
            {
             // Slumpmässigt välj två kort från kortleken
                List<string> kortnycklar = new List<string>(kortlek.Keys);
                string förstaKort = kortnycklar[slumpGenerator.Next(kortnycklar.Count)];
                string andraKort = kortnycklar[slumpGenerator.Next(kortnycklar.Count)];

             // Skriv ut de dragna korten
                Console.WriteLine($"Draget kort 1: {förstaKort}, Draget kort 2: {andraKort}");

             // Kontrollera om det är ett par
                if (kortlek[förstaKort] == kortlek[andraKort])
                {
                    Console.WriteLine("PAR!");
                    antalPar++;
                }
            }

            Console.WriteLine($"Antal PAR efter 1000 dragningar: {antalPar}");
        }

        static Dictionary<string, int> SkapaKortlek()
        {
            Dictionary<string, int> kortlek = new Dictionary<string, int>();

            string[] färger = { "k", "h", "s", "r" }; // Klöver, Hjärter, Spader, Ruter
            string[] valörer = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Kn", "D", "E", "A" }; // Valörer

            int värde = 1;
            foreach (string färg in färger)
            {
                foreach (string valör in valörer)
                {
                    string nyckel = färg + valör;
                    kortlek.Add(nyckel, värde);
                    värde = (värde % 13) + 1; // Öka värdet och börja om från 1 efter Kung (13)
                }
            }

            return kortlek;
        }
        }
}

