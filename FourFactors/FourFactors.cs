using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourFactors
{
    class FourFactors
    {
        static void Main(string[] args)
        {
            double FG = double.Parse(Console.ReadLine());
            double FGA = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());
            double TOV = double.Parse(Console.ReadLine());
            double ORB = double.Parse(Console.ReadLine());
            double OppDRB = double.Parse(Console.ReadLine());
            double FT = double.Parse(Console.ReadLine());
            double FTA = double.Parse(Console.ReadLine());

            double eFGper = (FG + (0.5 * P)) / FGA;
            double TOVper = ((TOV) / ((FGA + 0.44 * FTA) + TOV));
            double ORBper = (ORB) / (ORB + OppDRB);
            double FTper = (FT) / (FGA);

            Console.WriteLine("eFG% {0:F3}",eFGper);
            Console.WriteLine("TOV% {0:F3}",TOVper);
            Console.WriteLine("ORB% {0:F3}",ORBper);
            Console.WriteLine("FT% {0:F3}",FTper);
        }
    }
}