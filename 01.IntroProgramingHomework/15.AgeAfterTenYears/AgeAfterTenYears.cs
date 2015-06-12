using System;

namespace _15.AgeAfterTenYears
{
    class AgeAfterTenYears
    {
        /*
        Age after 10 Years
        Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
        */
        static void Main()
        {
            Console.WriteLine("Enter your BirthDay in format /dd.mm.yyyy/:");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            int age = 0;
            if (birthday.Month==DateTime.Today.Month && birthday.Day==DateTime.Now.Day)
            {
                Console.WriteLine("Happy BirthDay. Today is your birthday!");
                Console.WriteLine("****-----*****-----*****-----*****-----*****");
                age = DateTime.Today.Year - birthday.Year;
            }
            else if (birthday > DateTime.Now)
            {
                Console.WriteLine("You will not born already.Your born will be somewere at {0} year",birthday.Year);
                age = DateTime.Today.Year - birthday.Year;

            }
            else if (birthday.Month == DateTime.Today.Month && birthday.Day > DateTime.Now.Day)
            {
                age = DateTime.Today.Year - birthday.Year-1;

            }
            else
            {
                age = DateTime.Today.Year - birthday.Year;

            }
            Console.WriteLine("Your age now is {0}, and after 10 Years Will be {1}",age,age+10);

        }
    }
}
