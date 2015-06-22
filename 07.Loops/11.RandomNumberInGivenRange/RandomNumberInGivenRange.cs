using System;


namespace _11.RandomNumberInGivenRange
{
    class RandomNumberInGivenRange
    {
        //Problem 11. Random Numbers in Given Range

        //Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
        static void Main()
        {
            Console.WriteLine("Random Number In Given Range");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter 3 numbers");
            int nums, min, max;
            Console.Write("numbers n = ");
            int.TryParse(Console.ReadLine(),out nums);
            Console.Write("min of range = ");
            int.TryParse(Console.ReadLine(),out min);
            Console.Write("max of range = ");
            int.TryParse(Console.ReadLine(),out max);
            if (min >= max)
            {
                Console.WriteLine("invalid Period");
            }
            else
            {
                Random randomGenerator = new Random();
                for (int i = 0; i < nums; i++)
                {
                    Console.Write("{0} ", randomGenerator.Next(min, max));
                }
                Console.WriteLine();
            }


        }
    }
}
