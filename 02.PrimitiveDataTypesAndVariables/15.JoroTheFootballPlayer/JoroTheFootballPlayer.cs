using System;


namespace _15.JoroTheFootballPlayer
{
    class JoroTheFootballPlayer
    {
        static void Main()
        {
            string isLeapYear = Console.ReadLine();

            ushort numHolidays = ushort.Parse(Console.ReadLine());

            byte hometownWekends = byte.Parse(Console.ReadLine());

            int weekednsNotInHometown = 52 - hometownWekends;
            int weekendsforPlays = weekednsNotInHometown * 2 / 3;

            int plays = hometownWekends + (weekendsforPlays + numHolidays / 2);

            if (isLeapYear == "t")
            {
                plays = plays + 3;
            }
            Console.WriteLine(plays);
        }
    }
}
