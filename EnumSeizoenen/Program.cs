using System;

namespace EnumSeizoenen
{
    internal class Program
    {
        private enum Seizonsgroepen
        { None, Koude, Warme };

        private enum Seizoenen
        { None, Winter, Lente, Zomer, Herfst };

        private enum Maanden
        {
            None, Januari, Februari, Maart, April, Mei, Juni, Juli,
            Augustus, September, Oktober, November, December
        };

        private const string inputError = "Invoer bevat de fout. Probeer het opnieuw...";

        private static void Main(string[] args)
        {
            string[] seizoenengroenen = { "none", "koude", "warme" };
            string[] maanden = { "none", "januari", "februari", "maart", "april",
                "mei", "juni", "juli", "augustus", "september", "oktober",
                "november", "december"};
            string[] seizoenen = { "none", "winter", "lente", "zomer", "herfst" };
            bool inputExit = false;
            Console.WriteLine("Tik 0 om te kunnen stoppen");
            while (!inputExit)
                try
                {
                    Console.Write("Voer in maandnummer aub (1 tot 12)?");
                    int maand = int.Parse(Console.ReadLine());
                    Seizonsgroepen huidigSeizoenGroep = Seizonsgroepen.None;
                    Seizoenen huidigSeizoen = Seizoenen.None;

                    switch (maand)
                    {
                        case 0:
                            {
                                inputExit = true;
                                Console.WriteLine("Bye");
                                break;
                            }
                        case 12:
                        case 1:
                        case 2:
                            {
                                huidigSeizoenGroep = Seizonsgroepen.Koude;
                                huidigSeizoen = Seizoenen.Winter;
                                break;
                            }
                        case 3:
                            {
                                huidigSeizoenGroep = Seizonsgroepen.Koude;
                                huidigSeizoen = Seizoenen.Lente;
                                break;
                            }
                        case 4:
                        case 5:
                            {
                                huidigSeizoenGroep = Seizonsgroepen.Warme;
                                huidigSeizoen = Seizoenen.Lente;
                                break;
                            }
                        case 6:
                        case 7:
                        case 8:
                            {
                                huidigSeizoenGroep = Seizonsgroepen.Warme;
                                huidigSeizoen = Seizoenen.Zomer;
                                break;
                            }
                        case 9:
                            {
                                huidigSeizoenGroep = Seizonsgroepen.Warme;
                                huidigSeizoen = Seizoenen.Herfst;
                                break;
                            }
                        case 10:
                        case 11:
                            {
                                huidigSeizoenGroep = Seizonsgroepen.Koude;
                                huidigSeizoen = Seizoenen.Herfst;
                                break;
                            }
                        default:
                            {
                                inputExit = false;
                                huidigSeizoenGroep = Seizonsgroepen.None;
                                huidigSeizoen = Seizoenen.None;
                                Console.WriteLine(inputError);
                                break;
                            }
                    }
                    if (!inputExit)
                        Console.WriteLine($"Maand {maanden[maand]} " +
                            $"is een {seizoenengroenen[(int)huidigSeizoenGroep]} maand " +
                            $"van {seizoenen[(int)huidigSeizoen]} seizoen ");
                }
                catch (Exception e)
                {
                    inputExit = false;
                    Console.WriteLine(inputError);
                }
        }
    }
}