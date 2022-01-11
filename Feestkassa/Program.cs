using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Feestkassa
{
    class Program
    {
        const string tussenPrijsLeeg = "Tussenprijs = ";
        const double mosselenMetFrietjesJPrijs = 20.00;
        const double koninginenhapjePrijs = 10.00;
        const double ijsjePrijs = 3.00;
        const double drankPrijs = 2.00;

        public static double BerekenTussenPrijs(string naam, double prijs, ref string value)
        {
            Console.WriteLine(naam);
            int aantal = int.Parse(Console.ReadLine());
            double tussenPrijsBedrag = aantal * prijs;
            string tussenPrijsBedragString = tussenPrijsBedrag.ToString("#.## euro", CultureInfo.InvariantCulture);
            if (value == "")
            {
                value = tussenPrijsLeeg + tussenPrijsBedragString; 
            }
            else
            {
                 value += " + " + tussenPrijsBedragString;
            }
            Console.WriteLine(value);
            return tussenPrijsBedrag;
        }

        static void Main(string[] args)
        {
            string tussenPrijsBedragString = ""; 
            double tussenPrijs = BerekenTussenPrijs("Frietjes?", mosselenMetFrietjesJPrijs, ref tussenPrijsBedragString);
            tussenPrijs += BerekenTussenPrijs("Koninginenhapjes ?", koninginenhapjePrijs, ref tussenPrijsBedragString);
            tussenPrijs += BerekenTussenPrijs("Ijsjes?", ijsjePrijs, ref tussenPrijsBedragString);
            tussenPrijs += BerekenTussenPrijs("Dranken ?", drankPrijs, ref tussenPrijsBedragString);

            Console.WriteLine($"Het totaal te betalen bedrag is" +
                $" {tussenPrijs.ToString("#.## EURO", CultureInfo.InvariantCulture)}");
        }
    }
}
