using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class DailyCalorieIntake
    {
        static void Main(string[] args)
        {
            int weight = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int workoutsPerWeek = int.Parse(Console.ReadLine());
            bool m;

            //константи
            const double cm = 2.54;
            const double kg = 2.2;

            //ако е ж
            if (m = (gender == "f"))
            {
                var heightCM = height * cm;
                var weightKg = weight / kg;
                var BMR = (655 + (9.563 * weightKg) + (1.850 * heightCM) - (4.676 * age));
                if (workoutsPerWeek >= 1 && workoutsPerWeek <= 3)
                {
                    var Dci = Math.Floor(BMR * 1.375);
                    Console.WriteLine((Dci));
                }
                if (workoutsPerWeek >= 4 && workoutsPerWeek <= 6)
                {
                    var Dci = Math.Floor(BMR * 1.55);
                    Console.WriteLine((Dci));
                }
                if (workoutsPerWeek >= 7 && workoutsPerWeek <= 9)
                {
                    var Dci = Math.Floor(BMR * 1.725);
                    Console.WriteLine((Dci));
                }
                if (workoutsPerWeek > 9)
                {
                    var Dci = Math.Floor(BMR * 1.9);
                    Console.WriteLine((Dci));
                }
                if (workoutsPerWeek < 1)
                {
                    var Dci = Math.Floor(BMR * 1.2);
                    Console.WriteLine((Dci));
                }
            }

                //ако е м
            else if (m = (gender == "m"))
            {
                var heightCM = height * cm;
                var weightKg = weight / kg;
                var BMR = (66.5 + (13.75 * weightKg) + (5.003 * heightCM) - (6.755 * age));
                if (workoutsPerWeek >= 1 && workoutsPerWeek <= 3)
                {
                    var Dci = Math.Floor(BMR * 1.375);
                    Console.WriteLine(Dci);
                }
                if (workoutsPerWeek >= 4 && workoutsPerWeek <= 6)
                {
                    var Dci = Math.Floor(BMR * 1.55);
                    Console.WriteLine(Dci);
                }
                if (workoutsPerWeek >= 7 && workoutsPerWeek <= 9)
                {
                    var Dci = Math.Floor(BMR * 1.725);
                    Console.WriteLine(Dci);
                }
                if (workoutsPerWeek > 9)
                {
                    var Dci = Math.Floor(BMR * 1.9);
                    Console.WriteLine(Dci);
                }
                if (workoutsPerWeek < 1)
                {
                    var Dci = Math.Floor(BMR * 1.2);
                    Console.WriteLine(Dci);
                }
            }
        }
    }
}