using System;

namespace Euler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int som = 0;
            for (int i = 0; i <= 10000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    if (i != 0) Console.Write($"{i} ");
                    som += i;
                    if (som >= 234168) // som  heeft de limiet van 234168 bereikt
                    {
                        Console.WriteLine($"\nDe loop was force " +
                            $"gestopt bij getaal {i} en som {som}");
                        break;
                    }
                }
            }
        }
    }
}