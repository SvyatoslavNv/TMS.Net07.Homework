using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Exchange
{
    class Program
    {
        enum SourceToTarget
        {
            BYNtoRUB,
            BYNtoUSD,
            BYNtoEUR,
            RUBtoBYN,
            RUBtoUSD,
            RUBtoEUR,
            USDtoBYN,
            USDtoRUB,
            USDtoEUR,
            EURtoBYN,
            EURtoRUB,
            EURtoUSD
        }

        static void Main(string[] args)
        {
            double rateBYNtoRUB = 3.469 / 100;
            double rateBYNtoUSD = 2.640;
            double rateBYNtoEUR = 3.177;

            double rateRUBtoBYN = 100 / 3.463;
            double rateRUBtoUSD = 76.300;
            double rateRUBtoEUR = 91.800;

            double rateUSDtoBYN = 1 / 2.637;
            double rateUSDtoRUB = 1 / 76.000;
            double rateUSDtoEUR = 1.205;

            double rateEURtoBYN = 1 / 3.173;
            double rateEURtoRUB = 1 / 91.500;
            double rateEURtoUSD = 1 / 1.202;

            double result = 0;
            SourceToTarget sourceToTarget;
            double[] rates = new double[] { rateBYNtoRUB, rateBYNtoUSD, rateBYNtoEUR, rateRUBtoBYN, rateRUBtoUSD, rateRUBtoEUR,
                rateUSDtoBYN, rateUSDtoRUB, rateUSDtoEUR, rateEURtoBYN, rateEURtoRUB, rateEURtoUSD };

            Console.Write("Input source currency (BYN, RUB, USD or EUR): ");
            string source = Console.ReadLine().ToUpper();
            Console.Write("Input target currency (BYN, RUB, USD or EUR): ");
            string target = Console.ReadLine().ToUpper();
            Console.Write("Input required amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < 12; i++)
            {
                string converter = source + "to" + target;
                sourceToTarget = (SourceToTarget)i;
                string strSourceToTarget = sourceToTarget.ToString();

                if ((converter == strSourceToTarget) && (source != target) && (0 < amount))
                {
                    result = amount * rates[i];
                    Console.WriteLine($"{ amount} { target} is equal to { Math.Round(result, 4)} { source}");
                }
            }
            if (result == 0)
            {
                Console.WriteLine("incorrect input");
            }
            Console.ReadKey();
        }
    }
}
