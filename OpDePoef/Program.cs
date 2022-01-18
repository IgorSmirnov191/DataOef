using System;
using System.Globalization;

namespace OpDePoef
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double poefKassa = 0.0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Voer bedrag in? ");
                string invoer = Console.ReadLine();
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