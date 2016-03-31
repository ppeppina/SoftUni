using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("how many packets each bundel has");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());
            //Console.WriteLine("tha amount of table tops");
            int tableTops = int.Parse(Console.ReadLine());
            //Console.WriteLine("the amount of tables to made");
            int tableToBeMade = int.Parse(Console.ReadLine());
            int bundles = (1 * first) + (2 * second) + (3 * third) + (4 * fourth);
            //Console.WriteLine("legs {0}", bundles);
            int legs = bundles / bundles;
            //Console.WriteLine("leg one {0}", legs);
            int legsForOneTbale = 4 * legs;


            if (tableToBeMade < tableTops)
            {
                int more = tableTops - tableToBeMade;
                int topsLeft = tableTops - tableToBeMade;
                int legLeft = bundles - tableToBeMade*(4 * legs);
                Console.WriteLine("more: {0}", more);
                Console.WriteLine("tops left: {0}, legs left: {1}", topsLeft, legLeft);
            }
            else
            {
                if (tableToBeMade>tableTops)
                {
                    int less = tableTops - tableToBeMade;
                    int topsNeed = tableToBeMade - tableTops;
                    Console.WriteLine("less: {0}",less);
                    Console.WriteLine("tops needed: {0}, legs needed: 0",topsNeed);
                }
                else

                    Console.WriteLine("Just enough tables made: {0}",tableToBeMade);
            }
        }
    }
}