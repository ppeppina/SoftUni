
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabaTinche
{
    class BabaTinche
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split();
            string[] business = Console.ReadLine().Split();
            string[] economy = Console.ReadLine().Split();

            //first
            int firstIncome = (Convert.ToInt32(first[0]) - Convert.ToInt32(first[1])) * 7000;
            firstIncome = firstIncome + (int)(Convert.ToInt32(first[1]) * (7000 * 0.3));
            firstIncome = firstIncome + (int)(Convert.ToInt32(first[2]) * (7000*0.005));

            //business
            int businessIncome = (Convert.ToInt32(business[0]) - Convert.ToInt32(business[1])) * 3500;
            businessIncome = businessIncome + (int)(Convert.ToInt32(business[1]) * (3500 * 0.3));
            businessIncome = businessIncome + (int)(Convert.ToInt32(business[2]) * (3500 * 0.005));

            //economy
            int economyIncome = (Convert.ToInt32(economy[0]) - Convert.ToInt32(economy[1])) * 1000;
            economyIncome = economyIncome + (int)(Convert.ToInt32(economy[1]) * (1000 * 0.3));
            economyIncome = economyIncome + (int)(Convert.ToInt32(economy[2]) * (1000 * 0.005));

            int incomeReal = firstIncome + businessIncome + economyIncome;
            int incomeMax = (int)(12 * 7000 + 12 * (0.005 * 7000)) + (int)(28 * 3500 + 28 * (0.005 * 3500)) + (int)(50 * 1000 + 50 * (0.005 * 1000));

            Console.WriteLine(incomeReal);
            Console.WriteLine(incomeMax-incomeReal);

        }

    }
}
