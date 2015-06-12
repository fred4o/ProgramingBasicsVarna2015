using System;


namespace _08.NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        //Problem 8.	Numbers from 1 to n
        //Write a program that reads an integer number n from the console and prints all the numbers
        //in the interval [1..n], each on a single line. Note that you may need to use a for-loop. 

        static void Main()
        {
            Console.WriteLine("Numbers From One To N");
            Console.WriteLine("---------------------");
            Console.Write("Enter number n =");
            int num;
            if (int.TryParse(Console.ReadLine(),out num)==false)
            {
                Console.WriteLine("Invalid Number!!!!");
            }
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
