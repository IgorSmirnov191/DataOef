using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace OpDePoef
{
    class Program
    {
        static void Main(string[] args)
        {
            double poefKassa = 0.0;
            string invoer;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Voer bedrag in? ");
                invoer = Console.ReadLine();
                poefKassa += double.Parse(invoer.Trim(), CultureInfo.InvariantCulture);
                Console.WriteLine($"De poef staat op" +
                    $" {poefKassa.ToString("##.##", CultureInfo.InvariantCulture)} euro");
            }
           Console.WriteLine("*************************");
           Console.WriteLine($"Het totaal van  de poef is " +
               $"{poefKassa.ToString("##.##", CultureInfo.InvariantCulture)}" +
               $" en zal {Math.Round(poefKassa / 10)} " +
               $"weken duren om volledig afbetaald te worden");

        }
    }
}
