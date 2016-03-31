using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorrentPirate
{
    class TorrentPirate
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Download data d:");
            int d = int.Parse(Console.ReadLine());
            // Console.WriteLine("How much money would cost Jack to go to the cinema");
            byte p = byte.Parse(Console.ReadLine());
            // Console.WriteLine("Money per hour spend by Jack`s wife");
            byte w = byte.Parse(Console.ReadLine());

            // downloadTime  = downloadData / fixSpeed / seconds /minutes
            //priceForDownload = downloadTime*wifeSpnding
            //numberMovies = doownloadData/movie size
            //cinemaPrise=numbevOfMovies*cimenaPrice

            double fixSpeed = 2;
            double moviSize = 1500;
            double seconds = 60;
            double minutes = 60;

            double downloadTime = (((d / fixSpeed) / seconds) / minutes);
            //Console.WriteLine("download time {0:0.0000}", downloadTime);
            double priceForDownload = downloadTime * w;
            //Console.WriteLine("Price for Download {0:0.000}", priceForDownload);
            double numOfMoviesDown = (d / moviSize);
            // Console.WriteLine("sum of movies download {0}",numOfMoviesDown);
            double cinemaPrise = (numOfMoviesDown * p);
            // Console.WriteLine("cinema prise {0}",cinemaPrise);
            double mallPrice = w * downloadTime;
            //Console.WriteLine("mall price {0:0.00}",mallPrice);

            //Console.WriteLine("cinema -> {0:0.00}", cinemaPrise);
            //Console.WriteLine("mall -> {0:0.00}", mallPrice);

            if (cinemaPrise < mallPrice)
            {
                Console.WriteLine("cinema -> {0:0.00}lv",cinemaPrise);
            }
            else 
            {
                Console.WriteLine("mall -> {0:0.00}lv",mallPrice);
            }
        }
    }
}
