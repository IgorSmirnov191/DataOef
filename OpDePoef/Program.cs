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
            double d_PoefCassa = 0.0;
            string s_Invoer;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Voer bedrag in? ");
                s_Invoer = Console.ReadLine();
                d_PoefCassa += double.Parse(s_Invoer.Trim(), CultureInfo.InvariantCulture);
                Console.WriteLine($"De poef staat op " +
                    $"{d_PoefCassa.ToString("##.##", CultureInfo.InvariantCulture)} euro");
            }
           Console.WriteLine("*************************");
           Console.WriteLine($"Het totaal van  de poef is " +
               $"{d_PoefCassa.ToString("##.##", CultureInfo.InvariantCulture)}" +
               $" en zal {Math.Round(d_PoefCassa / 10)} " +
               $"weken duren om volledig afbetaald te worden");

        }
    }
}
