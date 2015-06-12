using System;


namespace _03.DividedBy7And5
{
    class DividedBy7And5
    {
        //Problem 3.	Divide by 7 and 5
        //Write a Boolean expression that checks for given integer if it can be divided (without remainder) 
        //by 7 and 5 in the same time

        static void Main()
        {
            int number;
            bool isDivided;
            Console.Write("Enter a integer n = ");
            if (int.TryParse(Console.ReadLine(),out number))
            {
                if (number%5==0&&number%7==0)
                {
                    isDivided = true;
                }
                else
                {
                    isDivided = false;
                }
                Console.WriteLine(isDivided);
            }
            else
            {
                Console.WriteLine("Invalid Number!!!");
            }
        }
    }
}
