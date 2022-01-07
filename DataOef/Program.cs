using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DataOef
{
    class Program
    {
        static string s_InputError = "Invoer bevat de fout. Probeer het opnieuw...";

        static void Main(string[] args)
        {
            double d_GetaalEen = 1.0;
            double d_GetaalTwee = 2.0;
            double d_GetaalDrie = 3.0;
            Console.WriteLine("Klik op ESC om op elk moment te kunnen stoppen");
            Console.WriteLine("Tik aub 3 kommagetallen met spacie als scheidingsteken\n" +
                $"bv. {d_GetaalEen.ToString("#.00",CultureInfo.InvariantCulture)}" +
                $" {d_GetaalTwee.ToString("#.00",CultureInfo.InvariantCulture)}" +
                $" {d_GetaalDrie.ToString("#.00",CultureInfo.InvariantCulture)}");
            ConsoleKeyInfo cki_Key;
            while ((cki_Key = Console.ReadKey()).Key != ConsoleKey.Escape)
                {
                    string s_InvoerLine  = cki_Key.KeyChar.ToString()+ Console.ReadLine();
                    try
                    {
                        string[] subs = s_InvoerLine.Trim().Split(' ');
                        d_GetaalEen = double.Parse(subs[0], CultureInfo.InvariantCulture);
                        d_GetaalTwee = double.Parse(subs[1], CultureInfo.InvariantCulture);
                        d_GetaalDrie = double.Parse(subs[2], CultureInfo.InvariantCulture);

                    Console.WriteLine("Er zijn 3 kommagetallen van invoer: " +
                        $"{d_GetaalEen.ToString("#.00", CultureInfo.InvariantCulture)}" +
                        $" {d_GetaalTwee.ToString("#.00", CultureInfo.InvariantCulture)}" +
                        $" {d_GetaalDrie.ToString("#.00", CultureInfo.InvariantCulture)}");

                    Console.WriteLine($"Gemiddelde van deze 3 (de eerste) getallen is " +
                            $"{((d_GetaalEen + d_GetaalTwee + d_GetaalDrie) / 3).ToString("#.00", CultureInfo.InvariantCulture)}");
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        Console.WriteLine(s_InputError);
                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine(s_InputError);

                    }

                }
            


        }
    }
}
