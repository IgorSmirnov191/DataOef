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

        public static double Voorwerp(string naam, double prijs, ref string value)
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
            string s_TussenPrijs = ""; 
            double tussenPrijs = Voorwerp("Frietjes?", mosselenMetFrietjesJPrijs, ref s_TussenPrijs);
            tussenPrijs += Voorwerp("Koninginenhapjes ?", koninginenhapjePrijs, ref s_TussenPrijs);
            tussenPrijs += Voorwerp("Ijsjes?", ijsjePrijs, ref s_TussenPrijs);
            tussenPrijs += Voorwerp("Dranken ?", drankPrijs, ref s_TussenPrijs);

            Console.WriteLine($"Het totaal te betalen bedrag is" +
                $" {tussenPrijs.ToString("#.## EURO", CultureInfo.InvariantCulture)}");
        }
    }
}
