using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Program
    {
        static int QuizResult(string correctAntwoord)
        {
            int result;
            ConsoleKeyInfo cki_Key = Console.ReadKey();

            switch (cki_Key.Key)
            {
                case ConsoleKey.A: //1000
                    {
                        result = ("1000" == correctAntwoord) ? 2 : -1;
                        break;
                    }
                case ConsoleKey.B: //0100
                    {
                        result = ("0100" == correctAntwoord) ? 2 : -1;
                        break;
                    }
                case ConsoleKey.C://0010
                    {
                        result = ("0010" == correctAntwoord) ? 2 : -1;
                        break;
                    }
                case ConsoleKey.D: //0001
                    {
                        result = ("0001" == correctAntwoord) ? 2 : -1;
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
        
        static void Main(string[] args)
        {
            string[] quizAntwoord = { "0100", "1000", "0001" };
            int result = 0;
           
            for (int i = 0; i < 3; i++)
            { 
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red + i;
                Console.WriteLine($"Voer het antwoord op vraag n.{i+1} (a,b,c of d) ? ");
                result += QuizResult(quizAntwoord[i]);
            }
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine($"U bent op {result} punten gescoord");

        }
    }
}
