using System;

namespace SteenSchaarPapier
{
    internal class Program
    {
        private const string inputError = "Invoer bevat een fout. Probeer het opnieuw...";
        private const string inputGebaar = "Bent u een steen(1) of een papier(2) of een schaar(3) ?";
        private const int scoreWinner = 10;

        /// <summary>
        /// Enum with possible outcomes from Rock Paper Scissors game
        /// </summary>
        private enum SteenSchaarPapier
        { None, Draw, Win, Loss };

        /// <summary>
        /// Get result score from compare two play gestures
        /// </summary>
        /// <param name="gebaarChar"></param>
        /// <param name="randomInvoer"></param>
        /// <returns></returns>
        private static SteenSchaarPapier GetResultScore(int gebaarChar, int randomInvoer)
        {
            if ((gebaarChar == 49 && randomInvoer == 1)
                || (gebaarChar == 50 && randomInvoer == 2)
                || (gebaarChar == 51 && randomInvoer == 3))
            { return SteenSchaarPapier.Draw; }
            if ((gebaarChar == 49 && randomInvoer == 2)
                || (gebaarChar == 50 && randomInvoer == 3)
                || (gebaarChar == 51 && randomInvoer == 1))
            { return SteenSchaarPapier.Loss; }
            if ((gebaarChar == 49 && randomInvoer == 3)
                || (gebaarChar == 50 && randomInvoer == 1)
                || (gebaarChar == 51 && randomInvoer == 2))
            { return SteenSchaarPapier.Win; }
            return SteenSchaarPapier.None;
        }

        private static void Main(string[] args)
        {
            ConsoleKeyInfo cki_Key;
            bool isInputCorrect = true;
            Random random = new Random();
            int scoreUser = 0;
            int scoreRandom = 0;
            while (scoreUser != scoreWinner && scoreRandom != scoreWinner && isInputCorrect)
                try
                {
                    Console.Write(inputGebaar);
                    cki_Key = Console.ReadKey();
                    int randomgetaal = random.Next(1, 4);

                    SteenSchaarPapier result = GetResultScore((int)cki_Key.KeyChar, randomgetaal);
                    switch (result)
                    {
                        case (SteenSchaarPapier.Win):
                            {
                                scoreUser++;
                                Console.WriteLine($"\nUser won. Score User {scoreUser} : {scoreRandom} Computer");
                                break;
                            }
                        case (SteenSchaarPapier.Loss):
                            {
                                scoreRandom++;
                                Console.WriteLine($"\nUser loss. Score User {scoreUser} : {scoreRandom} Computer");
                                break;
                            }
                        case (SteenSchaarPapier.Draw):
                            {
                                Console.WriteLine($"\nDraw game. Score User {scoreUser} : {scoreRandom} Computer");
                                break;
                            }
                        case (SteenSchaarPapier.None):
                            {
                                Console.WriteLine(inputError);
                                isInputCorrect = false;
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }
                catch (Exception e)
                {
                    isInputCorrect = false;
                    Console.WriteLine(inputError);
                }
            Console.WriteLine($"Game over. Score User {scoreUser} : {scoreRandom} Computer");
        }
    }
}