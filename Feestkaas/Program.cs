using System;

namespace Feestkaas
{
    internal class Program
    {
        public enum UserKeys
        { None, New, Stop };

        public static UserKeys GetMenuControlKey(char KeyChar)
        {
            switch (KeyChar)
            {
                case ('n'):
                case ('N'): return UserKeys.New;
                case ('s'):
                case ('S'): return UserKeys.Stop;
                default: break;
            }
            return UserKeys.None;
        }

        public enum Producten
        { Frietjes, Koninginenhapjes, Ijsjes, Dranken };

        public static decimal BerekenProductPrijs(Producten product, int aantal)
        {
            decimal productPrijs = 0m;
            const decimal mosselenMetFrietjesJPrijs = 20.00m;
            const decimal koninginenhapjePrijs = 10.00m;
            const decimal ijsjePrijs = 3.00m;
            const decimal drankPrijs = 2.00m;
            switch (product)
            {
                case Producten.Frietjes:
                    {
                        productPrijs = mosselenMetFrietjesJPrijs * aantal;
                        break;
                    }
                case Producten.Koninginenhapjes:
                    {
                        productPrijs = koninginenhapjePrijs * aantal;
                        break;
                    }
                case Producten.Ijsjes:
                    {
                        productPrijs = ijsjePrijs * aantal;
                        break;
                    }
                case Producten.Dranken:
                    {
                        productPrijs = drankPrijs * aantal;
                        break;
                    }
                default:
                    break;
            }
            return productPrijs;
        }

        private static void Main(string[] args)
        {
            string messageRepeat = "Probeer het opnieuw";
            string[] producten = { "Frietjes ?", "Koninginenhapjes ?", "Ijsjes ?", "Dranken ?" };
            ConsoleKeyInfo cki_Key;
            bool isProcessing = true;
            while (isProcessing)
                try
                {
                    Console.Write("Wilt u een niew bestelling doen(n) of stoppen(s) ?");
                    cki_Key = Console.ReadKey();
                    Console.WriteLine();
                    switch (GetMenuControlKey(cki_Key.KeyChar))
                    {
                        case (UserKeys.Stop):
                            {
                                isProcessing = false;
                                throw new Exception("Processing is gestopt. " + messageRepeat + " later");
                            }
                        case (UserKeys.New):
                            {
                                decimal saldo = 0m;
                                string tussensaldo = "Tussenprijs = ";
                                for (int i = 0; i < producten.Length; i++)
                                {
                                    Console.WriteLine(producten[i]);
                                    decimal tussenPrijsBedrag = BerekenProductPrijs((Producten)i, Convert.ToInt32(Console.ReadLine()));
                                    if (tussenPrijsBedrag != 0)
                                    {
                                        if (saldo != 0m) tussensaldo += " + " + tussenPrijsBedrag.ToString("# euro");
                                        else tussensaldo += tussenPrijsBedrag.ToString("# euro");
                                        Console.WriteLine(tussensaldo);
                                        saldo += tussenPrijsBedrag;
                                    }
                                }
                                Console.WriteLine($"Het totaal te betalen bedrag is {saldo.ToString("# EURO")}");
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