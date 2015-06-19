using System;
using System.Globalization;
using System.Threading;



namespace _10.BeerTime
{
    class BeerTime
    {
        static void Main()
        {
        //    Problem 10.* Beer Time

        //A beer time is after 1:00 PM and before 3:00 AM.
        //Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12],
        //a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time 
        //according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Beer Time");
            Console.WriteLine("---------");
            Console.WriteLine("Enter a time in format (hh:mm AM/PM)");
            string userInput = Console.ReadLine();
            string startValue = "1:00 PM";
            string endValue = "3:00 AM";
            DateTime datevalue;
            if (DateTime.TryParse(userInput, out datevalue))
            {
                DateTime starTime = DateTime.Parse(startValue);
                DateTime endTime = DateTime.Parse(endValue);
                endTime = endTime.AddDays(1);
                DateTime time = DateTime.Parse(userInput);
                if (time >= starTime && time <= endTime )
                {
                    Console.WriteLine("Its a Beer Time");
                }
                else
                {
                    Console.WriteLine("Its non-beer Time");
                }
                
              
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }
    
        }
    }
}
