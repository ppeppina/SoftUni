using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelonsAndWatermelons
{
    class MelonsAndWatermelons
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int melons = 0;
            int watermelons = 0;

            for (int i = s; i <s+d; i++)
            {
                switch (i%7)
                {
                    case 1:
                        watermelons = watermelons + 1;
                        break;
                    case 2:
                        melons = melons + 2;
                        break;
                    case 3:
                        watermelons = watermelons + 1;
                        melons = melons + 1;
                        break;
                    case 4:
                        watermelons = watermelons + 2;
                        break;
                    case 5:
                        watermelons = watermelons + 2;
                        melons = melons + 2;
                        break;
                    case 6:
                        watermelons = watermelons + 1;
                        melons = melons + 2;
                        break;
                    default:
                        break;
                }
            }
            int more = Math.Abs(melons - watermelons);
            if (melons>watermelons)
            {
                Console.WriteLine("{0} more melons",more);   
            }
            else
            {
                if (melons < watermelons)
                {
                    Console.WriteLine("{0} more watermelons", more);
                }
                else
                {
                    Console.WriteLine("Equal amount: {0}",melons);
                }
            }
        }
    }
}
