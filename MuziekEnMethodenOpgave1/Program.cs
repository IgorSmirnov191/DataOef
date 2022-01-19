using System;

namespace MuziekEnMethodenOpgave1
{
    internal class Program
    {
        private static void PrintNoot(string noot, int octaaf)
        {
            string octaafnumber = octaaf > 1 ? octaaf.ToString() : "";
            Console.WriteLine($"{noot}{octaafnumber}");
        }

        private static void Do(int duur = 1000, int octaaf = 1, bool nootpresent = false)
        {
            if (nootpresent) PrintNoot("Do", octaaf);
            Console.Beep(264 * octaaf, 1000);
        }

        private static void Re(int duur = 1000, int octaaf = 1, bool nootpresent = false)
        {
            if (nootpresent) PrintNoot("Re", octaaf);
            Console.Beep(297 * octaaf, 1000);
        }

        private static void Mi(int duur = 1000, int octaaf = 1, bool nootpresent = false)
        {
            if (nootpresent) PrintNoot("Mi", octaaf);
            Console.Beep(330 * octaaf, 1000);
        }

        private static void Fa(int duur = 1000, int octaaf = 1, bool nootpresent = false)
        {
            if (nootpresent) PrintNoot("Fa", octaaf);
            Console.Beep(352 * octaaf, 1000);
        }

        private static void Sol(int duur = 1000, int octaaf = 1, bool nootpresent = false)
        {
            if (nootpresent) PrintNoot("Sol", octaaf);
            Console.Beep(396 * octaaf, 1000);
        }

        private static void La(int duur = 1000, int octaaf = 1, bool nootpresent = false)
        {
            if (nootpresent) PrintNoot("La", octaaf);
            Console.Beep(440 * octaaf, 1000);
        }

        private static void Si(int duur = 1000, int octaaf = 1, bool nootpresent = false)
        {
            if (nootpresent) PrintNoot("Si", octaaf);
            Console.Beep(495 * octaaf, 1000);
        }

        private static void SpeelYouAreMySunshine()
        {
            Re(); Sol(); La(); Si(); Si(); Si(); La(); Si(); Sol(); Sol();
            Sol(); La(); Si(); Do(); Mi(); Mi(); Re(); Do(); Si();
        }

        private static void Main(string[] args)
        {
            Console.Write("Opgave n.1 Start.");
            Do(); Console.Write(".");
            Re(); Console.Write(".");
            Mi(); Console.Write(".");
            Fa(); Console.Write(".");
            Sol(); Console.Write(".");
            La(); Console.Write(".");
            Si(); Console.Write(".");
            Do(octaaf: 2); Console.Write(".");
            Console.WriteLine("\nOpgave n.1 Stop\n");

            Console.WriteLine("Opgave n.2 Start");
            Do(nootpresent: true);
            Re(nootpresent: true);
            Mi(nootpresent: true);
            Fa(nootpresent: true);
            Sol(nootpresent: true);
            La(nootpresent: true);
            Si(nootpresent: true);
            Do(nootpresent: true);
            Console.WriteLine("Opgave n.2 Stop\n");

            Console.WriteLine("Opgave n.3 Start");
            Do(duur: 500, octaaf: 2, nootpresent: true);
            Re(duur: 500, octaaf: 2, nootpresent: true);
            Mi(duur: 500, octaaf: 2, nootpresent: true);
            Fa(duur: 500, octaaf: 2, nootpresent: true);
            Sol(duur: 500, octaaf: 2, nootpresent: true);
            La(duur: 500, octaaf: 2, nootpresent: true);
            Si(duur: 500, octaaf: 2, nootpresent: true);
            Do(duur: 500, octaaf: 2, nootpresent: true);
            Console.WriteLine("Opgave n.3 Stop \n");

            Console.WriteLine("Opgave n.4 Start...");
            SpeelYouAreMySunshine();
            Console.WriteLine("Opgave n.4 Stop");
        }
    }
}