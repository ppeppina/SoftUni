using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());

            long result = 0;
            int positionX = x + 1;
            if (y==1)
            {
                positionX = x + 4;
            }
            if (y==2)
            {
                positionX = x + 7;
            }
            v = v + positionX - 1;
            result = (long)Math.Pow(v, positionX);
            Console.WriteLine(result);
        }
    }
}
