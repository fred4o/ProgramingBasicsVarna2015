using System;

namespace _15.HowOldAfterTenYears
{
    class HowOldAfterTenYears
    {
        static void Main()
        {
            Console.WriteLine("Please enter birth Date in format /dd.mm.yyyy/ ?");
            DateTime birthDate = new DateTime();
            birthDate = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Now;
            int age = today.Year-birthDate.Year;

            if (age >0 &&(today.Month < birthDate.Month || ((today.Month == birthDate.Month) && (today.Day < birthDate.Day))))
            {
                age--;
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Your Age now is {0}", age);
                Console.WriteLine("Your Age after ten Years at this will be {0}", age + 10);
                             
            }

            else if ((today.Month == birthDate.Month) && (today.Day == birthDate.Day))
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Today is your birthday. Happy BirthDay!!!");
                Console.WriteLine("Your Age now is {0}", age);
                Console.WriteLine("Your Age after ten Years at this day will be {0}", age + 10);
            }
            if (age <= 0 && (today.Month < birthDate.Month || ((today.Month == birthDate.Month) && (today.Day < birthDate.Day))))
            {
                age--;
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("You will not alredy been born! You will born at {0:dd.MM.yyyy}",birthDate);
                Console.WriteLine("Your Age after ten Years at this day will be {0}", age + 10);

            }
            
               
           
        }
    }
}
