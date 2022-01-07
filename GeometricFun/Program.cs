using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace GeometricFun
{
    class Program
    {
        static string s_InputError = "Invoer bevat de fout. Probeer het opnieuw...";
        static void Main(string[] args)
        {
            double d_HoekGraden = 45.0;
            Console.WriteLine("Klik op ESC om op elk moment te kunnen stoppen");
            Console.WriteLine("Tik aub een hoek in graden\n" +
                $"bv. {d_HoekGraden.ToString("#.00", CultureInfo.InvariantCulture)}");
            ConsoleKeyInfo cki_Key;
            while ((cki_Key = Console.ReadKey()).Key != ConsoleKey.Escape)
            {
                string s_InvoerLine = cki_Key.KeyChar.ToString() + Console.ReadLine();
                try
                {
                    double d_HoekRadialen = (Math.PI / 180.0) * double.Parse(s_InvoerLine, CultureInfo.InvariantCulture);
                    Console.WriteLine($"de sinus {Math.Sin(d_HoekRadialen).ToString("0.000000", CultureInfo.InvariantCulture)}, " +
                        $"cosinus {Math.Cos(d_HoekRadialen).ToString("0.000000", CultureInfo.InvariantCulture)} " +
                        $"en tangens {Math.Tan(d_HoekRadialen).ToString("0.000000", CultureInfo.InvariantCulture)} "+
                        $"van de hoek { d_HoekRadialen.ToString("0.0000", CultureInfo.InvariantCulture)} radialen");

                }
                catch (System.FormatException e)
                {
                    Console.WriteLine(s_InputError);

                }
            }
        }
    }
}
