using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterMusicProducer
{
    class heBetterMusicProducer
    {
        static void Main(string[] args)
        {
            int soldEurope = int.Parse(Console.ReadLine());
            double priceEuros = double.Parse(Console.ReadLine());

            int soldNA = int.Parse(Console.ReadLine());
            double priceDollars = double.Parse(Console.ReadLine());

            int soldSA = int.Parse(Console.ReadLine());
            double pricePesos = double.Parse(Console.ReadLine());

            int numConcert = int.Parse(Console.ReadLine());
            double incomesEuroPerConcert = double.Parse(Console.ReadLine());

            const double Euro = 1.94;
            const double Dolar = 1.72;
            const double Pesos = 332.74;

            double amountEuropeEuro = soldEurope * priceEuros;
            double amountEuropeLeva = amountEuropeEuro * Euro;

            double amountNorthAmericaDolars = soldNA * priceDollars;
            double amountNorthAmericaLeva = amountNorthAmericaDolars * Dolar;

            double amountSouthAmericaPesos = soldSA * pricePesos;
            double amountSouthAmericaLeva = amountSouthAmericaPesos / Pesos;

            //vajnoto
            double totalImcome = amountEuropeLeva + amountNorthAmericaLeva + amountSouthAmericaLeva;

            double concertProfitEuro = numConcert * incomesEuroPerConcert;
            double concertProfitLeva = concertProfitEuro * Euro;

            //fisrt 
            double afterProducer = totalImcome - (35 * totalImcome) / 100;
            double afterTaxes = afterProducer - (20 * afterProducer) / 100;

            // second 
            double second = numConcert * incomesEuroPerConcert * Euro;

            if (concertProfitLeva > 100000 && totalImcome <= concertProfitLeva)
            {
                if (afterTaxes > second)
                {
                    Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", afterTaxes);
                }
                else if (afterTaxes < second)
                {
                    Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", second - second * 0.15);
                }
            }
            else if (concertProfitLeva < 100000 && totalImcome <= concertProfitLeva)
            {
                if (afterTaxes > second)
                {
                    Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", afterTaxes);
                }
                else if (afterTaxes < second)
                {
                    Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", second);
                }
            }
            else if (concertProfitLeva > 100000 && totalImcome > concertProfitLeva)
            {
                if (afterTaxes > second)
                {
                    Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", afterTaxes);
                }
                else if (afterTaxes<second)
                {
                    Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", second-second*0.15);
                }
            }
            else if (concertProfitLeva < 100000 && totalImcome > concertProfitLeva)
            {
                if (afterTaxes > second)
                {
                    Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", afterTaxes);
                }
                else if (afterTaxes < second)
                {
                    Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", second);
                }
            }
        }
    }
}