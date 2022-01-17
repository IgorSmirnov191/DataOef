using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarEncryptie
{
    
    internal class Program
    {
        const string inputError = "Probeer het opnieuw...";
        const string inputFunctie = "Wilt u een geheime bericht schrijven(e), lezen(d) of stoppen(s) ?";
        const string inputCypherVraag = "Tik een cypher in aub ?";
        const string inputTextVraag = "Voer een text in aub :";
        const string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static char[] CreateAlphabet(int cypher)
        {
            string original = alfabet;
            original = original.Substring(cypher, original.Length-cypher) + original.Substring(0, cypher);
            return original.ToCharArray();
        }
        public static char[] EncryptMessage(char[] decrMessage, int cypher)
        {
            char[] originalAlfabet = alfabet.ToCharArray();
            char[] alfabetCypher = CreateAlphabet(cypher);
            string encrMessage = "";

            for (int i = 0; i < decrMessage.Length; i++)
            {
                if (decrMessage[i] == ' ' || Array.BinarySearch(originalAlfabet, decrMessage[i]) == -1)
                {
                    encrMessage += " ";
                }
                else
                {
                    encrMessage += alfabetCypher[Array.BinarySearch(originalAlfabet, decrMessage[i])];
                }
            }
            return encrMessage.ToCharArray();
        }
        public static char[] DecryptMessage(char[] encrMessage, int cypher)
        {
            char[] originalAlfabet = alfabet.ToCharArray();
            char[] alfabetCypher = CreateAlphabet(cypher);
            string decrMessage = "";
            for (int i = 0; i < encrMessage.Length; i++)
            {
                if (encrMessage[i] == ' ' || Array.BinarySearch(alfabetCypher, encrMessage[i]) == -1)
                {
                    decrMessage += " ";
                }
                else
                {
                    decrMessage += originalAlfabet[Array.BinarySearch(alfabetCypher, encrMessage[i])];
                }
            }

            return decrMessage.ToCharArray();
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki_Key;
            int inputCypher;
            string inputText;
            bool isInputCorrect = false;
            while (!isInputCorrect)
                try
                {
                    Console.Write(inputFunctie);
                    cki_Key = Console.ReadKey();
                    Console.WriteLine();
                    if ((cki_Key.KeyChar == 's'|| cki_Key.KeyChar == 'S') &&
                        cki_Key.KeyChar != 'e' && cki_Key.KeyChar != 'E' &&
                           cki_Key.KeyChar != 'd' && cki_Key.KeyChar != 'D' )
                    {
                        Console.WriteLine(inputError);
                        break;

                    }
                    Console.Write(inputCypherVraag);
                    inputCypher = int.Parse(Console.ReadLine());
                    Console.Write(inputTextVraag);
                    inputText = Console.ReadLine();

                    if (cki_Key.KeyChar == 'e' || cki_Key.KeyChar == 'E')
                    {
                        Console.WriteLine(EncryptMessage(inputText.ToUpper().ToCharArray(), inputCypher));
                    }
                    else if (cki_Key.KeyChar == 'd' || cki_Key.KeyChar == 'D')
                    {
                        Console.WriteLine(DecryptMessage(inputText.ToUpper().ToCharArray(), inputCypher));
                    }
                    
                    
                }
                catch (Exception e)
                {
                    isInputCorrect = false;
                    Console.WriteLine(inputError);
                }
        }
    }
}
