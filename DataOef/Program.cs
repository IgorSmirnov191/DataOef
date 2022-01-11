using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace GemiddeldeVan3
{
    class Program
    {
        const string inputError = "Invoer bevat de fout. Probeer het opnieuw...";
        static void Main(string[] args)
        {
            double getaalEen = 1.0;
            double getaalTwee = 2.0;
            double getaalDrie = 3.0;
            Console.WriteLine("Klik op ESC om op elk moment te kunnen stoppen");
            Console.WriteLine("Tik aub 3 kommagetallen met spacie als scheidingsteken\n" +
                $"bv. {getaalEen.ToString("#.00",CultureInfo.InvariantCulture)}" +
                $" {getaalTwee.ToString("#.00",CultureInfo.InvariantCulture)}" +
                $" {getaalDrie.ToString("#.00",CultureInfo.InvariantCulture)}");
            ConsoleKeyInfo cki_Key;
            while ((cki_Key = Console.ReadKey()).Key != ConsoleKey.Escape)
                {
                    string s_InvoerLine  = cki_Key.KeyChar.ToString()+ Console.ReadLine();
                    try
                    {
                        string[] subs = s_InvoerLine.Trim().Split(' ');
                        getaalEen = double.Parse(subs[0], CultureInfo.InvariantCulture);
                        getaalTwee = double.Parse(subs[1], CultureInfo.InvariantCulture);
                        getaalDrie = double.Parse(subs[2], CultureInfo.InvariantCulture);

                    Console.WriteLine("Er zijn 3 kommagetallen van invoer: " +
                        $"{getaalEen.ToString("#.00", CultureInfo.InvariantCulture)}" +
                        $" {getaalTwee.ToString("#.00", CultureInfo.InvariantCulture)}" +
                        $" {getaalDrie.ToString("#.00", CultureInfo.InvariantCulture)}");

                    Console.WriteLine($"Gemiddelde van deze 3 (de eerste) getallen is " +
                            $"{((getaalEen + getaalTwee + getaalDrie) / 3).ToString("#.00", CultureInfo.InvariantCulture)}");
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
