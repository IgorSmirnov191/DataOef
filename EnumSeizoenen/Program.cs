using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSeizoenen
{
    internal class Program
    {
        enum Seizonsgroepen { koude, warme};
        enum Seizoenen { winter, lente, zomer, herfst };
        enum Maanden {januari = 1, februari, maart, april, mei, juni, juli, augustus, september, oktober, november, december};
        const string inputError = "Invoer bevat de fout. Probeer het opnieuw...";
        static void Main(string[] args)
        {
            string[] seisonsgroenen = { "koude", "varme"};
            string[] maanden = { "none", "januari", "februari", "maart", "april", "mei", "juni", "juli", "augustus", "september", "oktober", "november", "december"};
            string[] seizoenen = { "winter"," lente","zomer","herfst"};
            bool inputExit = false;
            Console.WriteLine("Tik 0 om te kunnen stoppen");
            while (!inputExit)
                try
                {
                    Console.Write("Voer in maandnummer aub ?");
                    int maand = int.Parse(Console.ReadLine());
                    switch(maand)
                    {

                        case 0 :
                        { 
                                inputExit = true;
                                Console.WriteLine("Bye");
                                break;
                        }
                        case 12:
                        case 1 :
                        case 2:
                        {
                                Console.WriteLine($"Maand {maanden[maand]} is een {seisonsgroenen[0]} maand van {seizoenen[0]} seizoen ");
                                break;
                        }
                        case 3:
                        case 4:
                        case 5:
                        {
                                Console.WriteLine($"Maand {maanden[maand]} is een {seisonsgroenen[1]} maand van {seizoenen[1]} seizoen ");
                                break;
                        }
                        case 6:
                        case 7:
                        case 8:
                        {
                                Console.WriteLine($"Maand {maanden[maand]} is een {seisonsgroenen[1]} maand van {seizoenen[2]} seizoen ");
                                break;
                        }
                        case 9:
                        case 10:
                        case 11:
                        {
                                Console.WriteLine($"Maand {maanden[maand]} is een {seisonsgroenen[0]} maand van {seizoenen[3]} seizoen ");
                                break;

                        }
                        default:
                        {
                                inputExit = false;
                                Console.WriteLine(inputError);
                                break;

                        }
                    }
            
                }
                catch (Exception e)
                {
                    inputExit = false;
                    Console.WriteLine(inputError);

                }

        }
    }
}
