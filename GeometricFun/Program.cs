﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace GeometricFun
{
    class Program
    {
        const string inputError = "Invoer bevat de fout. Probeer het opnieuw...";
        const string messageEsc = "Klik op ESC om op elk moment te kunnen stoppen";
 
        static void Main(string[] args)
        {
            double hoekGraden = 45.0;
            Console.WriteLine(messageEsc);
            Console.WriteLine("Tik aub een hoek in graden\n" +
                $"bv. {hoekGraden.ToString("#.00", CultureInfo.InvariantCulture)}");
            ConsoleKeyInfo cki_Key;
            while ((cki_Key = Console.ReadKey()).Key != ConsoleKey.Escape)
            {
                string invoerLine = cki_Key.KeyChar.ToString() + Console.ReadLine();
                try
                {
                    double hoekRadialen = (Math.PI / 180.0) * double.Parse(invoerLine, CultureInfo.InvariantCulture);
                    Console.WriteLine($"de sinus {Math.Sin(hoekRadialen).ToString("0.000000", CultureInfo.InvariantCulture)}, " +
                        $"cosinus {Math.Cos(hoekRadialen).ToString("0.000000", CultureInfo.InvariantCulture)} " +
                        $"en tangens {Math.Tan(hoekRadialen).ToString("0.000000", CultureInfo.InvariantCulture)} "+
                        $"van de hoek { hoekRadialen.ToString("0.0000", CultureInfo.InvariantCulture)} radialen");

                }
                catch (System.FormatException e)
                {
                    Console.WriteLine(inputError);

                }
            }
        }
    }
}
