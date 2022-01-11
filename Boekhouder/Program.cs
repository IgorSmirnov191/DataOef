using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Boekhouder
{
    internal class Program
    {
        const string inputError = "Invoer bevat een fout. Probeer het opnieuw...";
        static void Main(string[] args)
        {
            decimal balans = 0, debet = 0, credit = 0;
            int aantal = 0;
            Console.WriteLine("Klik op ESC om op elk moment te kunnen stoppen");
            Console.WriteLine("Tik aub bedragen met spacie als scheidingsteken\n");

            ConsoleKeyInfo cki_Key;
            while ((cki_Key = Console.ReadKey()).Key != ConsoleKey.Escape)
            {
                string invoerLine = cki_Key.KeyChar.ToString() + Console.ReadLine();
                try
                {
                    string[] subs = invoerLine.Trim().Split(' ');

                    foreach (string value in subs)
                    {
                        decimal bedraag = Decimal.Parse(value);
                        if (bedraag > 0)
                        {
                            credit += bedraag; //opbrengsten
                        }
                        else
                        {
                            debet += Math.Abs(bedraag); //kosten
                        }
                        balans += bedraag;
                        aantal++;
                    }
                    Console.WriteLine($"Balans: {balans.ToString("#.00")} euro, " +
                        $"Oopbrengsten: {credit.ToString("#.00")} euro, " +
                        $"Kosten: {debet.ToString("#.00")} euro, " +
                        $"Gemiddelde: {(balans / aantal).ToString("#.00")} euro / bedraag ");

                }
                catch (System.IndexOutOfRangeException)
                {
                    Console.WriteLine(inputError);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine(inputError);
                }
            }
        }
    }
}
