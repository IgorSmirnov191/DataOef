using System;

namespace OrakelVanDelphi
{
    internal class Program
    {
        private const string inputError = "Invoer bevat een fout. Probeer het opnieuw...";
        private const string inputGeslacht = "Bent u een vrouw(v) of een man(m) ?";

        public static bool Orakeltje(char geslachtChar, int leeftijdValue)
        {
            Random rd_Orakel = new Random();
            int leeftijdVrouwMax = 150;
            int leeftijdManMax = 120;
            if (geslachtChar == 'v' || geslachtChar == 'V')
            {
                Console.WriteLine($"Je zal nog {rd_Orakel.Next(5, leeftijdVrouwMax - leeftijdValue)} jaar leven.");
            }
            else if (geslachtChar == 'm' || geslachtChar == 'M')
            {
                Console.WriteLine($"Je zal nog {rd_Orakel.Next(5, leeftijdManMax - leeftijdValue)} jaar leven.");
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
            ConsoleKeyInfo cki_Key;
            int inputLeeftijd;
            bool isInputCorrect = true;
            while (isInputCorrect)
                try
                {
                    Console.Write(inputGeslacht);
                    cki_Key = Console.ReadKey();
                    Console.WriteLine();
                    Console.Write("Tik uw leeftijd aub ?");
                    inputLeeftijd = int.Parse(Console.ReadLine());
                    isInputCorrect = Orakeltje(cki_Key.KeyChar, inputLeeftijd);
                }
                catch (Exception e)
                {
                    isInputCorrect = false;
                    Console.WriteLine($"Error: {e.Message} " + inputError);
                }
        }
    }
}