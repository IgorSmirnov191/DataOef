using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaadHetGetal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal;
            int poging = 0;
            int aantalPogingen = 0;
            string pogingString;
            bool gevonden = false;
            Random rand = new Random();
            getal = rand.Next(0, 10);

            while (!gevonden)
            {
                aantalPogingen++;
                Console.WriteLine("Geef een getal tussen 0 en 10");
                pogingString = Console.ReadLine();
                poging = int.Parse(pogingString);

                if (getal > poging)
                {
                    Console.WriteLine("Het gezochte getal is groter, probeer opnieuw.");
                }
                else if (getal < poging)
                {
                    Console.WriteLine("Het gezochte getal is kleiner, probeer opnieuw.");
                }
                else
                    gevonden = true;
            }
            Console.WriteLine($"Gevonden! Het te zoeken getal was inderdaad {getal} je had er {aantalPogingen} pogingen voor nodig.");
        }
    }
}
