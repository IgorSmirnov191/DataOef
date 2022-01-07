using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrakelVanDelphi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd_Orakel = new Random();
            Console.WriteLine ($"Je zal nog {rd_Orakel.Next(5,125)} jaar leven.");
        }
    }
}
