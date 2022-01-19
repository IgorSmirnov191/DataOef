using System;

namespace CaesarEncryptie
{
    internal class Program
    {
        private const string messageRepeat = "Probeer het opnieuw";
        private const string inputCypherVraag = "Tik een cypher in aub ?";
        private const string inputTextVraag = "Voer een text in aub :";
        private const string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        /// <summary>
        /// Enum with processing keys from menu CaesarEncryptie
        /// </summary>
        public enum UserKeys
        { None = -1, Decrypt = 68, Encrypt = 69, Stop = 83 };

        /// <summary>
        /// Translate inputs user keys to processing keys
        /// </summary>
        /// <param name="KeyChar"></param>
        /// <returns></returns>
        public static UserKeys GetMenuControlKey(char KeyChar)
        {
            switch (KeyChar)
            {
                case ('d'):
                case ('D'): return UserKeys.Decrypt;
                case ('e'):
                case ('E'): return UserKeys.Encrypt;
                case ('s'):
                case ('S'): return UserKeys.Stop;
                default: break;
            }
            return UserKeys.None;
        }

        /// <summary>
        /// Create encrypted alphabet from original latin alphabet and cypher value
        /// </summary>
        /// <param name="cypher"></param>
        /// <returns></returns>
        public static char[] CreateAlphabet(int cypher)
        {
            string original = alfabet;
            original = original.Substring(cypher, original.Length - cypher) + original.Substring(0, cypher);
            return original.ToCharArray();
        }

        /// <summary>
        /// Encrypt user message with Ceaser algorithm
        /// </summary>
        /// <param name="decrMessage"></param>
        /// <param name="cypher"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Decrypt user message with Caesar algorithm
        /// </summary>
        /// <param name="encrMessage"></param>
        /// <param name="cypher"></param>
        /// <returns></returns>
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

        private static void Main(string[] args)
        {
            ConsoleKeyInfo cki_Key;
            int inputCypher;
            string inputText;
            bool isProcessing = true;
            while (isProcessing)
                try
                {
                    Console.Write("Wilt u een geheime bericht schrijven(e), lezen(d) of stoppen(s) ?");
                    cki_Key = Console.ReadKey();
                    Console.WriteLine();
                    switch (GetMenuControlKey(cki_Key.KeyChar))
                    {
                        case (UserKeys.Stop):
                            {
                                isProcessing = false;
                                throw new Exception("Processing is gestopt. " + messageRepeat + " later");
                            }
                        case (UserKeys.Encrypt):
                            {
                                Console.Write(inputCypherVraag);
                                inputCypher = int.Parse(Console.ReadLine());
                                Console.Write(inputTextVraag);
                                inputText = Console.ReadLine();
                                Console.WriteLine(EncryptMessage(inputText.ToUpper().ToCharArray(), inputCypher));
                                break;
                            }
                        case (UserKeys.Decrypt):
                            {
                                Console.Write(inputCypherVraag);
                                inputCypher = int.Parse(Console.ReadLine());
                                Console.Write(inputTextVraag);
                                inputText = Console.ReadLine();
                                Console.WriteLine(DecryptMessage(inputText.ToUpper().ToCharArray(), inputCypher));
                                break;
                            }
                        default:
                            throw new Exception("Een verkeerde toets was gedrukt. " + messageRepeat);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
        }
    }
}