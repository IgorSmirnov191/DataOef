using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrakelVanDelphi
{
    class Program
    {
        const string inputError = "Invoer bevat een fout. Probeer het opnieuw...";
        const string inputGeslacht = "Bent u een vrouw(v) of een man(m) ?";
        const string inputLeeftijdVraag = "Tik uw leeftijd aub ?";
        const int leeftijdVrouwMax = 150;
        const int leeftijdManMax = 120;
        public static bool Orakeltje(char geslachtChar, int leeftijdValue)
        {
            Random rd_Orakel = new Random();
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
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki_Key;
            int inputLeeftijd;
            bool isInputCorrect = false;
            while(!isInputCorrect)
            try
            {
                Console.Write(inputGeslacht);
                cki_Key = Console.ReadKey();
                Console.WriteLine();
                Console.Write(inputLeeftijdVraag);
                inputLeeftijd = int.Parse(Console.ReadLine());
                isInputCorrect = Orakeltje(cki_Key.KeyChar, inputLeeftijd);
            }
            catch (Exception e)
            { 
                    isInputCorrect = false;
                    Console.WriteLine(inputError);
            }
        }
    }
}
