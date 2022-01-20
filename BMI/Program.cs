using System;

namespace BMI
{
    internal class Program
    {
        private const string inputError = "Invoer bevat de fout. Probeer het opnieuw...";
        private const string inputGewichtVraag = "Tik aub uw gewicht in kg ?";
        private const string inputLengteVraag = "Tik aub uw lengte in m ?";
        private const decimal gewichtMax = 727.00m; // de zwaarste man ter wereld ooit - Carol Yager
        private const decimal gewichtMin = 0.0m;
        private const decimal lengteMax = 2.72m; // de gootste man ter wereld ooit - Robert Wadlow
        private const decimal lengteMin = 0.0m;

        public enum GewichtenSorten
        { None = -1, OnvoldoendeGewicht, NormalGewicht, PreObees, Obees, ErnstigeZwaarlijvigheid }

        //
        public static GewichtenSorten GetGewichtenSorten(double bodyMassIndex)
        {
            if (bodyMassIndex > 0 && bodyMassIndex < 18.5)
            {
                return GewichtenSorten.OnvoldoendeGewicht;
            }
            else if (bodyMassIndex < 24.9)
            {
                return GewichtenSorten.NormalGewicht;
            }
            else if (bodyMassIndex < 29.9)
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

        public static bool BMIberekenaar(decimal gewicht, decimal lengte)
        {
            string naarGelang = "";
            if (gewicht > gewichtMin
                && gewicht <= gewichtMax
                && lengte > lengteMin
                && lengte <= lengteMax)
            {
                double bodyMassIndex = Math.Round((double)gewicht / Math.Pow(Convert.ToDouble(lengte), 2), 2);
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

        private static void Main(string[] args)
        {
            decimal inputLengte = 0.0m;
            decimal inputGewicht = 0.0m;
            bool inputCorrect = false;
            while (!inputCorrect)
                try
                {
                    Console.Write(inputLengteVraag);
                    inputLengte = Convert.ToDecimal(Console.ReadLine());
                    Console.Write(inputGewichtVraag);
                    inputGewicht = Convert.ToDecimal(Console.ReadLine());
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