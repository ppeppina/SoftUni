using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyCheck
{
    class CurrencyCheck
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("rubles:");
            double r = double.Parse(Console.ReadLine());
            //Console.WriteLine("dollars:");
            double d = double.Parse(Console.ReadLine());
            //Console.WriteLine("euro:");
            double e = double.Parse(Console.ReadLine());
            //Console.WriteLine("Special offer at B leva:");
            double l = double.Parse(Console.ReadLine());
            //Console.WriteLine("Special offer at M site leva:");
            double m = double.Parse(Console.ReadLine());


            //The price 
            double priceR = (r / 100) * (3.5);
            //Console.WriteLine("rubles {0:0.00}",priceR);
            double  priceD = (d*1.5);
            //Console.WriteLine("dollars{0:0.00}",priceD);
            double priceE = (e * 1.95);
            //Console.WriteLine("euro {0:0.00}",priceE);
            double priceL = (l / 2);
            //Console.WriteLine("offer {0:0.00}",priceL);
            double priceM = m;
            //Console.WriteLine("offer m {0:0.00}",priceM);

            if ((priceR<priceD)&&(priceR<priceE)&&(priceR<priceL)&&(priceR<priceM))
            {
                Console.WriteLine("{0:0.00}",priceR);
            }
            if ((priceD<priceE)&&(priceD<priceL)&&(priceD<priceM)&&(priceD<priceR))
            {
                Console.WriteLine("{0:0.00}",priceD);
            }
            if ((priceE < priceD) && (priceE < priceL) && (priceE < priceM) && (priceE < priceR))
            {
                Console.WriteLine("{0:0.00}",priceE);
            }
            if ((priceL < priceE) && (priceL < priceD) && (priceL < priceM) && (priceL < priceR))
            {
                Console.WriteLine("{0:0.00}", priceL);
            }
            if ((priceM < priceE) && (priceM < priceL) && (priceM < priceD) && (priceD < priceR))
            {
                Console.WriteLine("{0:0.00}", priceM);
            }
        }
    }
}
