using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Moment4
{
    internal class KortLek1
    {

        public  void Kortlek1()
        {
            // Skapa en lista för kortleken
            List<string> kortlek = SkapaKortlek();

            // Skapa en slumpgenerator
            Random slumpGenerator = new Random();

            Console.WriteLine("Drar kort från kortleken:");

            // Loopa tills alla kort är dragna
            while (kortlek.Count > 0)
            {
                // Generera ett slumpmässigt index för att dra ett kort från kortleken
                int index = slumpGenerator.Next(0, kortlek.Count);

                // Dra och skriv ut det dragna kortet
                string dragenKort = kortlek[index];
                Console.WriteLine($"Draget kort: {dragenKort}");

                // Ta bort det dragna kortet från kortleken
                kortlek.RemoveAt(index);
            }

            Console.WriteLine("Alla kort har dragits.");
        }

        // Funktion för att skapa en kortlek
        static List<string> SkapaKortlek()
        {
            List<string> kortlek = new List<string>();

            string[] färger = { "k", "h", "s", "r" }; // Klöver, Hjärter, Spader, Ruter
            string[] valörer = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Kn", "D", "E", "A" }; // Valörer

            // Fyll på kortleken med alla kombinationer av färg och valör
            foreach (string färg in färger)
            {
                foreach (string valör in valörer)
                {
                    kortlek.Add(färg + valör);
                }
            }

            return kortlek;
        }
    }
}

