using System;

namespace VraagArray
{
    internal class Program
    {
        private const string inputError = "Invoer bevat een fout. Probeer het opnieuw...";
        private const int MAX_LENGTH = 6;

        private static void Main(string[] args)
        {
            string[] arrVraag = {"Geef getaal n.1: ",
                                    "Geef getaal n.2: ",
                                    "Geef getaal n.3: ",
                                    "Geef getaal n.4: ",
                                    "Geef getaal n.5: ",
                                    "Geef getaal n.6: " };
            int[] arrAntword = new int[MAX_LENGTH];
            int score = 0;
            while (score < MAX_LENGTH)
                try
                {
                    Console.Write(arrVraag[score]);
                    string input = Console.ReadLine();
                    arrAntword[score] = Convert.ToInt32(input);
                    score++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(inputError);
                }
            Console.WriteLine();
            for (int i = 0; i < MAX_LENGTH; i++)
            {
                Console.WriteLine($"{arrVraag[i]}{arrAntword[i]}");
            }
        }
    }
}