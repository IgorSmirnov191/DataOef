using System;

namespace SteenSchaarPapier
{
    internal class Program
    {
        private const string messageRepeat = "Probeer het opnieuw";
        private const string inputGebaar = "Bent u een steen(1) of een papier(2) of een schaar(3) ?";
        private const int scoreWinner = 10;

        /// <summary>
        /// Enum with possible outcomes from Rock Paper Scissors game
        /// </summary>
        private enum SteenSchaarPapier
        { None, Draw, Win, Loss };

        /// <summary>
        /// Enum with possible users keys from menu Rock Paper Scissors game
        /// </summary>
        public enum UserKeys
        { None = -1, Esc = 27, Steen = 49, Papier = 50, Schaar = 51 };

        /// <summary>
        /// Enum with random gesture
        /// </summary>
        public enum RandomKeys
        { None = 0, Steen, Papier, Schaar };

        /// <summary>
        /// Translate inputs user keys to processing keys
        /// </summary>
        /// <param name="KeyChar"></param>
        /// <returns></returns>
        public static UserKeys GetUserInvoerKey(char KeyChar)
        {
            switch (KeyChar)
            {
                case ('1'): return UserKeys.Steen;
                case ('2'): return UserKeys.Papier;
                case ('3'): return UserKeys.Schaar;
                case ('\u001b'): return UserKeys.Esc;
                default: break;
            }
            return UserKeys.None;
        }

        /// <summary>
        /// Get result score from compare two play gestures
        /// </summary>
        /// <param name="userInvoer"></param>
        /// <param name="randomInvoer"></param>
        /// <returns></returns>
        private static SteenSchaarPapier GetResultScore(UserKeys userInvoer, int randomInvoer)
        {
            if ((userInvoer == UserKeys.Steen && randomInvoer == (int)RandomKeys.Steen)
                || (userInvoer == UserKeys.Papier && randomInvoer == (int)RandomKeys.Papier)
                || (userInvoer == UserKeys.Schaar && randomInvoer == (int)RandomKeys.Schaar))
            { return SteenSchaarPapier.Draw; }
            if ((userInvoer == UserKeys.Steen && randomInvoer == (int)RandomKeys.Papier)
                || (userInvoer == UserKeys.Papier && randomInvoer == (int)RandomKeys.Schaar)
                || (userInvoer == UserKeys.Schaar && randomInvoer == (int)RandomKeys.Steen))
            { return SteenSchaarPapier.Loss; }
            if ((userInvoer == UserKeys.Steen && randomInvoer == (int)RandomKeys.Schaar)
                || (userInvoer == UserKeys.Papier && randomInvoer == (int)RandomKeys.Steen)
                || (userInvoer == UserKeys.Schaar && randomInvoer == (int)RandomKeys.Papier))
            { return SteenSchaarPapier.Win; }
            return SteenSchaarPapier.None;
        }

        private static void Main(string[] args)
        {
            ConsoleKeyInfo cki_Key;
            bool isProcessing = true;
            Random random = new Random();
            int scoreUser = 0;
            int scoreRandom = 0;
            Console.WriteLine("Klik op ESC om op elk moment te kunnen stoppen");
            while (scoreUser != scoreWinner && scoreRandom != scoreWinner && isProcessing)
                try
                {
                    Console.Write(inputGebaar);
                    cki_Key = Console.ReadKey();
                    UserKeys invoer = GetUserInvoerKey(cki_Key.KeyChar);
                    if (invoer == UserKeys.Esc)
                    {
                        isProcessing = false;
                        Console.WriteLine();
                        throw new Exception("Processing is gestopt. " + messageRepeat + " later");
                    }
                    int randomgetaal = random.Next(1, 4);

                    SteenSchaarPapier result = GetResultScore(invoer, randomgetaal);
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
                                throw new Exception("Een verkeerde toets was gedrukt. " + messageRepeat);
                            }
                        default:
                            {
                                throw new Exception("Een verkeerde toets was gedrukt. " + messageRepeat);
                            }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            Console.WriteLine($"Game over. Score User {scoreUser} : {scoreRandom} Computer");
        }
    }
}