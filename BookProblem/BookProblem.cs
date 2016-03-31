using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProblem
{
    class BookProblem
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Book page:");
            int bookPage = int.Parse(Console.ReadLine());
            //Console.WriteLine("Compaining days");
            int campingDays = int.Parse(Console.ReadLine());
            //Console.WriteLine("Page reads every normal day");
            int pageNormalDay = int.Parse(Console.ReadLine());
            int normalDays = 30 - campingDays;
            //
            //Console.WriteLine("read page in 25 normal days");
            int readPageNormal = (normalDays * pageNormalDay);
            //Console.Write(readPageNormal);
            //Console.WriteLine("on a copmaining day ");
            int campingPage = campingDays * 0;
            //onsole.WriteLine(compainingPage);

            //Console.WriteLine("months");

            if (campingDays == 30 || pageNormalDay == 0)
            {
                Console.WriteLine("never");
            }
            else
            {
                //kolko dni ot meseca cheta 
                int daysReading = 30 - campingDays;

                //kolko str.chete na mesec
                double pagesPerMonth = daysReading * pageNormalDay;

                //kolko obshto meseca 
                double neededMonths = bookPage / pagesPerMonth;
                int resultNeededMonth = (int)(Math.Ceiling(neededMonths));

                //rezultat god.i  meseci
                int resultYear = resultNeededMonth / 12;
                int resulMonths = resultNeededMonth % 12;

                Console.WriteLine("{0} years {1} months", resultYear, resulMonths);
            }

        }
    }
}