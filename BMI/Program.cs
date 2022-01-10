using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    internal class Program
    {
        const string inputError = "Invoer bevat de fout. Probeer het opnieuw...";
        const string inputGewichtVraag = "Tik aub uw gewicht in kg ?";
        const string inputLengteVraag = "Tik aub uw lengte in m ?";
        const double gewichtMax = 727.00; // de zwaarste man ter wereld ooit - Carol Yager
        const double gewichtMin = 0.0;
        const double lengteMax = 2.72; // de gootste man ter wereld ooit - Robert Wadlow
        const double lengteMin = 0.0;
        public static bool BMIberekenaar(double gewicht, double lengte)
        {
            string naarGelang;
            if (gewicht > gewichtMin 
                && gewicht <= gewichtMax 
                && lengte > lengteMin
                && lengte <= lengteMax)
            {
                double bodyMassIndex = Math.Round(gewicht / Math.Pow(lengte, 2), 2);
                if (bodyMassIndex > 0 && bodyMassIndex < 18.5)
                {
                    naarGelang = "Onder de 18,5: ondergewicht.";
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (bodyMassIndex >= 18.5 && bodyMassIndex < 24.9)
                {
                    naarGelang = "Tussen de 18,5 en de 24,9: normaal gewicht.";
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (bodyMassIndex >= 24.9 && bodyMassIndex < 29.9)
                {
                    naarGelang = "Tussen de 25 en de 29,9 : overgewicht. Je loopt niet echt een risico, maar je mag niet dikker worden.";
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else if (bodyMassIndex >= 29.9 && bodyMassIndex < 39.9)
                {
                    naarGelang = "Tussen de 30 en de 39,9 : Zwaarlijvigheid (obesitas). Verhoogde kans op allerlei aandoeningen zoals diabetes, hartaandoeningen en rugklachten. Je zou 5 tot 10 kg moeten vermageren.";
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (bodyMassIndex >= 40)
                {
                    naarGelang = "Boven de 40 : ernstige zwaarlijvigheid. Je moet dringend vermageren want je gezondheid is in gevaar (of je hebt je lengte of gewicht in verkeerde eenheid ingevoerd).";
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else
                {
                    Console.WriteLine(inputError);
                    return false;
                }
                Console.WriteLine($"Uw BMI(Body Mass Index) is {bodyMassIndex} kg/m2.");
                Console.WriteLine(naarGelang);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine(inputError);
                return false;

            }
            return true;
        }
        static void Main(string[] args)
        {
            double inputLengte;
            double inputGewicht;
            bool inputCorrect = false;
            while (!inputCorrect)
                try
                {
                    Console.Write(inputLengteVraag);
                    inputLengte = Double.Parse(Console.ReadLine());
                    Console.Write(inputGewichtVraag);
                    inputGewicht = Double.Parse(Console.ReadLine());
                    inputCorrect = BMIberekenaar(inputGewicht, inputLengte);
                }
                catch (Exception e)
                {
                    inputCorrect = false;
                    Console.WriteLine(inputError);

                }

        }
    }
}
