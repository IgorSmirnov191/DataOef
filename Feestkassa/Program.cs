using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Feestkassa
{
    class Program
    {
        static double d_MosselenMetFrietjesJPrijs = 20.00;
        static double d_KoninginenhapjePrijs = 10.00;
        static double d_IjsjePrijs = 3.00;
        static double d_DrankPrijs = 2.00;
        static void Main(string[] args)
        {
            int i_MosselenMetFrietjesAantaal = 0;
            int i_KoninginenhapjesAantal = 0;
            int i_IjsjesAantal = 0;
            int i_DrankenAantal = 0;

            double d_TussenPrijsFrietjes = 0;
            double d_TussenPrijsKoninginenhapjes = 0;
            double d_TussenPrijsIjsjes = 0;
            double d_TussenPrijsDranken = 0;

            string s_TussenPrijs = "Tussenprijs = "; 

            Console.WriteLine("Frietjes?");
            i_MosselenMetFrietjesAantaal =  int.Parse(Console.ReadLine());
            d_TussenPrijsFrietjes = 
                d_MosselenMetFrietjesJPrijs * i_MosselenMetFrietjesAantaal;
            string s_TussenPrijsFrietjes = 
                d_TussenPrijsFrietjes.ToString("#.## euro", CultureInfo.InvariantCulture);
            s_TussenPrijs += s_TussenPrijsFrietjes;
            Console.WriteLine(s_TussenPrijs);

            Console.WriteLine("Koninginenhapjes?");
            i_KoninginenhapjesAantal = int.Parse(Console.ReadLine());
            d_TussenPrijsKoninginenhapjes = 
                d_KoninginenhapjePrijs * i_KoninginenhapjesAantal;
            string s_TussenPrijsKoninginenhapjes = 
                d_TussenPrijsKoninginenhapjes.ToString("#.## euro", CultureInfo.InvariantCulture);
            s_TussenPrijs += " + " + s_TussenPrijsKoninginenhapjes;
            Console.WriteLine(s_TussenPrijs);

            Console.WriteLine("Ijsjes?");
            i_IjsjesAantal = int.Parse(Console.ReadLine());
            d_TussenPrijsIjsjes = d_IjsjePrijs * i_IjsjesAantal;
            string s_TussenPrijsIjsjes = 
                d_TussenPrijsIjsjes.ToString("#.## euro", CultureInfo.InvariantCulture);
            s_TussenPrijs +=  " + " + s_TussenPrijsIjsjes;
            Console.WriteLine(s_TussenPrijs);

            Console.WriteLine("Dranken?");
            i_DrankenAantal = int.Parse(Console.ReadLine());
            d_TussenPrijsDranken = d_DrankPrijs * i_DrankenAantal;
            string s_TussenPrijsDranken = 
                d_TussenPrijsDranken.ToString("#.## euro", CultureInfo.InvariantCulture);
            s_TussenPrijs += " + " + s_TussenPrijsDranken;
            Console.WriteLine(s_TussenPrijs);

            double d_Totaal = d_TussenPrijsFrietjes
                + d_TussenPrijsKoninginenhapjes
                + d_TussenPrijsIjsjes
                + d_TussenPrijsDranken;
            Console.WriteLine($"Het totaal te betalen bedrag is" +
                $" {d_Totaal.ToString("#.## EURO", CultureInfo.InvariantCulture)}");
           

        }
    }
}
