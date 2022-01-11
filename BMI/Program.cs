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
        public enum GewichtenSorten {None = -1, OnvoldoendeGewicht, NormalGewicht, PreObees, Obees, ErnstigeZwaarlijvigheid }
        //
        public static GewichtenSorten GetGewichtenSorten(double bodyMassIndex)
        {
            if (bodyMassIndex > 0 && bodyMassIndex < 18.5)
            {
                return GewichtenSorten.OnvoldoendeGewicht;
            }
            else if ( bodyMassIndex < 24.9)
            {
                return GewichtenSorten.NormalGewicht;
            }
            else if ( bodyMassIndex < 29.9)
            {
                return GewichtenSorten.PreObees;
            }
            else if (bodyMassIndex < 39.9)
            {
                return GewichtenSorten.Obees;
            }
            else if (bodyMassIndex >= 40)
            {
                return GewichtenSorten.ErnstigeZwaarlijvigheid;
            }
        return GewichtenSorten.None;
        }
        public static bool BMIberekenaar(double gewicht, double lengte)
        {
            string naarGelang ="";
            if (gewicht > gewichtMin 
                && gewicht <= gewichtMax 
                && lengte > lengteMin
                && lengte <= lengteMax)
            {
                double bodyMassIndex = Math.Round(gewicht / Math.Pow(lengte, 2), 2);
                switch (GetGewichtenSorten(bodyMassIndex))
                { 
                    case GewichtenSorten.OnvoldoendeGewicht:
                        {
                            naarGelang = "Onder de 18,5: ondergewicht.";
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        }
                    case GewichtenSorten.NormalGewicht:
                        {
                            naarGelang = "Tussen de 18,5 en de 24,9: normaal gewicht.";
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        }
                    case GewichtenSorten.PreObees:
                        {
                            naarGelang = "Tussen de 25 en de 29,9 : overgewicht (pre-obees). Je loopt niet echt een risico, maar je mag niet dikker worden.";
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;
                        }
                    case GewichtenSorten.Obees:
                        {
                            naarGelang = "Tussen de 30 en de 39,9 : zwaarlijvigheid (obesitas). Verhoogde kans op allerlei aandoeningen zoals diabetes, hartaandoeningen en rugklachten. Je zou 5 tot 10 kg moeten vermageren.";
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        }
                    case GewichtenSorten.ErnstigeZwaarlijvigheid:
                        {
                            naarGelang = "Boven de 40 : ernstige zwaarlijvigheid. Je moet dringend vermageren want je gezondheid is in gevaar (of je hebt je lengte of gewicht in verkeerde eenheid ingevoerd).";
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine(inputError);
                            break;
                        }
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
