using System;

namespace LeveringsBedrijf
{
    internal class Program
    {
        private const string inputError = "Invoer bevat een fout or postcode ontbekend. Probeer het opnieuw...";
        private const string messageEsc = "Klik op ESC om op elk moment te kunnen stoppen";
        private const string inputPostCode = "Naar welke postcode wenst u dit pakket te versturen?";
        private const string inputGewicht = "Geef gewicht pakket";

        private static void Main(string[] args)
        {
            string[] postCodeSorted = { "2000", "2200", "2300", "2400", "2500", "2600", "2630", "2800", "2900", "2990" };
            decimal[] prijPerKg = { 1.2m, 1.3m, 2.5m, 3.0m, 2.0m, 1.2m, 1.3m, 1.8m, 1.5m, 2.0m };

            ConsoleKeyInfo cki_Key;
            bool isActive = true;
            decimal gewicht = 0.0m;
            uint postcode;
            Console.WriteLine(messageEsc);
            while (isActive)
            {
                try
                {
                    Console.WriteLine(inputGewicht);
                    cki_Key = Console.ReadKey();
                    if (cki_Key.Key == ConsoleKey.Escape)
                    {
                        isActive = false;
                        break;
                    }
                    string invoerLine = cki_Key.KeyChar.ToString() + Console.ReadLine();
                    gewicht = Convert.ToDecimal(invoerLine);
                    Console.WriteLine(inputPostCode);
                    invoerLine = Console.ReadLine();
                    postcode = Convert.ToUInt16(invoerLine);
                    int indexArr = Array.BinarySearch(postCodeSorted, invoerLine);
                    if (indexArr == -1 || postcode == 0) throw new Exception();
                    Console.WriteLine($"Dit zal {prijPerKg[indexArr] * gewicht} euro kosten.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(inputError);
                }
            }
        }
    }
}