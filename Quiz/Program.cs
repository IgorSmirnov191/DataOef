using System;

namespace Quiz
{
    internal class Program
    {
        public enum Antwoord
        {
            None = 0b_0000_0000, //0
            A = 0b_0000_1000, //8
            B = 0b_0000_0100, //4
            C = 0b_0000_0010, //2
            D = 0b_0000_0001  //1
        }

        private static int QuizResult(Antwoord correctAntwoord)
        {
            int result;
            ConsoleKeyInfo cki_Key = Console.ReadKey();
            switch (cki_Key.Key)
            {
                case ConsoleKey.A:
                    {
                        result = (Antwoord.A == correctAntwoord) ? 2 : -1;
                        break;
                    }
                case ConsoleKey.B:
                    {
                        result = (Antwoord.B == correctAntwoord) ? 2 : -1;
                        break;
                    }
                case ConsoleKey.C:
                    {
                        result = (Antwoord.C == correctAntwoord) ? 2 : -1;
                        break;
                    }
                case ConsoleKey.D:
                    {
                        result = (Antwoord.D == correctAntwoord) ? 2 : -1;
                        break;
                    }
                default:
                    {
                        result = 0;
                        break;
                    }
            }
            return result;
        }

        private static void Main(string[] args)
        {
            Antwoord[] quizCorrectAntwoorden = { Antwoord.B, Antwoord.A, Antwoord.D };
            int result = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red + i;
                Console.WriteLine($"Voer het antwoord op vraag n.{i + 1} (a,b,c of d) ? ");
                result += QuizResult(quizCorrectAntwoorden[i]);
            }
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine($"U bent op {result} punten gescoord");
        }
    }
}