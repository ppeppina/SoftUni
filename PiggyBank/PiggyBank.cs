using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class PiggyBank
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("the price of the tank");
            double price = double.Parse(Console.ReadLine());
           // Console.WriteLine("numbers of party in a mount");
            double party = double.Parse(Console.ReadLine());
           
            if (party > 8)
            {
                Console.WriteLine("never");
            }

            else
            {
                double normalDays = 30 - party;
                double saveNormalDay = 2 * normalDays;
                double partyDay = party * 5;
                double saving = saveNormalDay - partyDay;

                //??????????????????????????????????????????????????
                double needMonth =price /saving;
                int result = (int)Math.Ceiling(needMonth);

                double year = result / 12;
                double month = result%12;

                Console.WriteLine("{0} years, {1} months",year,month);

            }
        }
    }
}