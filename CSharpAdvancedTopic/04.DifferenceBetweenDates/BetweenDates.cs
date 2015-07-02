using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DifferenceBetweenDates
{
    class BetweenDates
    {
        //Problem 4.	Difference between Dates
        //Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them. 
        static void Main()
        {
            DateTime firsDate, secondDate;
            DateTime.TryParse(Console.ReadLine(),out firsDate);
            DateTime.TryParse(Console.ReadLine(),out secondDate);
            int numsOfDays=0;

            numsOfDays = CountDays(firsDate, secondDate);
            Console.WriteLine(numsOfDays);
        }

        private static int CountDays(DateTime firsDate, DateTime secondDate)
        {
            int numsOfDays = 0;
            if (firsDate < secondDate)
            {
                for (var i = firsDate; i < secondDate; i = i.AddDays(1))
                {
                    numsOfDays++;
                }
            }
            else
            {
                for (var i = secondDate; i < firsDate; i = i.AddDays(1))
                {
                    numsOfDays--;
                }
            }
            return numsOfDays;
        }
    }
}
