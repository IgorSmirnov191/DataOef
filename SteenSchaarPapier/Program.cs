using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteenSchaarPapier
{
    internal class Program
    {
        const string inputError = "Invoer bevat een fout. Probeer het opnieuw...";
        const string inputGebaar = "Bent u een steen(1) of een papier(2) of een schaar(3) ?";
        const int scoreWinner = 10;
        enum SteenSchaarPapier {None, Draw , Win, Loss};
        static SteenSchaarPapier ShowResultScore(char gebaarChar, int randomInvoer)
        {
            if((gebaarChar == '1' && randomInvoer == 1) 
                || (gebaarChar =='2' && randomInvoer == 2) 
                || (gebaarChar == '3' && randomInvoer == 3))       
            { return SteenSchaarPapier.Draw;}
            else if((gebaarChar == '1' && randomInvoer == 2) 
                || (gebaarChar == '2' && randomInvoer == 3)
                || (gebaarChar == '3' && randomInvoer == 1))
                { return SteenSchaarPapier.Loss; }
            else if ((gebaarChar == '1' && randomInvoer == 3)
                || (gebaarChar == '2' && randomInvoer == 1)
                || (gebaarChar == '3' && randomInvoer == 2))
                { return SteenSchaarPapier.Win; }
         return SteenSchaarPapier.None;
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki_Key;
            bool isInputCorrect = false;
            Random random = new Random();
            int scoreUser = 0;
            int scoreRandom = 0; 
            while ( scoreUser != scoreWinner && scoreRandom != scoreWinner && !isInputCorrect )
                try
                {
                    Console.Write(inputGebaar);
                    cki_Key = Console.ReadKey();
                    int randomgetaal = random.Next(1, 4);
                    SteenSchaarPapier result = ShowResultScore(cki_Key.KeyChar, randomgetaal);
                    switch (result)
                    { 
                        case(SteenSchaarPapier.Win):
                            {
                                scoreUser += 1;
                                Console.WriteLine($"\nUser won. Score User {scoreUser} : {scoreRandom} Computer");
                                break;
                            }
                        case (SteenSchaarPapier.Loss):
                            {
                                scoreRandom += 1;
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
                                isInputCorrect =false;
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

