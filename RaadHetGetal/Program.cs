using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaadHetGetal
{
    internal class Program
    {
        const string errorBuitenBereik = "Oops. Het poging is buiten bereik";
        static void Main(string[] args)
        {
            
            int getal=0, poging = 0, aantalPogingen = 0;
            int lowrand = 0, highrand = 100, intervaal = highrand;
            int maxAantalPogingen = 0;
            while ((intervaal=intervaal/2) != 0)
            { 
                maxAantalPogingen++; 
            } ;
            Random rand = new Random();
            getal = rand.Next(lowrand, highrand);
            bool gevonden = false;
            while ((aantalPogingen < maxAantalPogingen) && !gevonden)
            {
                Console.WriteLine($"Geef een getal tussen {lowrand} en {highrand}. U hebt nog {maxAantalPogingen-aantalPogingen} pogingen");
                poging = int.Parse(Console.ReadLine());
                if (getal > poging)
                {
                    if (poging < highrand && poging >= lowrand)
                    {
                        lowrand = poging;
                        Console.WriteLine($"Het gezochte getal is groter dan invoer, het moet groter dan {poging} zijn maar kleiner dan {highrand}, probeer opnieuw.");
                        aantalPogingen++;
                    }
                    else
                        Console.WriteLine(errorBuitenBereik);

                }
                else if (getal < poging)
                {
                    if (poging > lowrand && poging <= highrand)
                    {
                        highrand = poging;
                        Console.WriteLine($"Het gezochte getal is kleiner dan invoer, moet kleiner dan {poging} zijn maar groter dan {lowrand}, probeer opnieuw.");
                        aantalPogingen++;
                    }
                    else
                        Console.WriteLine(errorBuitenBereik);
                }
                else
                {
                    gevonden = true;
                    aantalPogingen++;
                }
            }
            if (gevonden) Console.WriteLine($"Gevonden! Het te zoeken getal was inderdaad {getal} je had er {aantalPogingen} pogingen voor nodig.");
            else Console.WriteLine("Oops. U hebt geen pogingen meer");
        }
    }
}
