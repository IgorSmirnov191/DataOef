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
            double saldo = poefKassa % 10;
            int aantalWeken = saldo == 0 ? ((int)poefKassa / 10) : ((int)poefKassa / 10 + 1);
            string saldoLastWeek = saldo > 0 ? $"Laatste week betaling zal zijn {saldo.ToString("##.##", CultureInfo.InvariantCulture)} euro" : "";
            Console.WriteLine($"Het totaal van de poef is " +
                $"{poefKassa.ToString("##.##", CultureInfo.InvariantCulture)} euro" +
                $" en zal {aantalWeken} " +
                $"weken duren om volledig afbetaald te worden. \n{saldoLastWeek}");
        }
    }
}