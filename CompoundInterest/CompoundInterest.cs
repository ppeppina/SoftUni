using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundInterest
{
    class CompoundInterest
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("price of the tv");
            double p = double.Parse(Console.ReadLine());
            //Console.WriteLine("years you have to pay the bank");
            int n = int.Parse(Console.ReadLine());
            //onsole.WriteLine("rate for the bank loan");
            double l = double.Parse(Console.ReadLine());
            //Console.WriteLine("friend loan");
            double f = double.Parse(Console.ReadLine());

            //
            //ЧИСЛО НА СТЕПЕН 
            double bankLoan = Math.Pow((1 + l), n) * p;
            //Console.WriteLine("bank {0}",bankLoan);
            double frientLoan = ((1 + f)) * p;
            //Console.WriteLine("friend {0}",frientLoan);

            if (bankLoan < frientLoan)
            {
                Console.WriteLine("{0:F2} Bank",bankLoan);
            }
            else
            { 
                Console.WriteLine("{0:F2} Friend",frientLoan);
            }

        }
    }
}
