using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellerBob
{
    class TravellerBob
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            double c = int.Parse(Console.ReadLine());
            double f = int.Parse(Console.ReadLine());
            bool leap;

            if (leap = (yearType == "leap"))
            {
                double contractTravel = (c * 4 * 3);
                double family = f * 2 * 2;
                double otherMonths = 12 - (c + f);
                double otherMonthTravel = otherMonths * 12;
                double normalTraverPerYear = (otherMonthTravel * 3) / 5;
                double normalYear = normalTraverPerYear + family + contractTravel;
                double leapYear = normalYear + ((normalYear * 5) / 100);
                double result = (double)Math.Floor(leapYear);
                Console.WriteLine(result);
                return;
            }
            else
            {
                double contractTravel = (c * 4 * 3);
                double family = f * 2 * 2;
                double otherMonths = 12 - (c + f);
                double otherMonthTravel = otherMonths * 12;
                double normalTraverPerYear = (otherMonthTravel * 3) / 5;
                double normalYear = normalTraverPerYear + family + contractTravel;
                double result = (double)Math.Floor(normalYear);
                Console.WriteLine(result);
            }
        }
    }
}
