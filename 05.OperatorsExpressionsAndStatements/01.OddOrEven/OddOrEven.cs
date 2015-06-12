using System;


namespace _01.OddOrEven
{
    class OddOrEven
    {
//        Problem 1.	Odd or Even Integers
//Write an expression that checks if given integer is odd or even. 

        static void Main()
        {
            int num;
            bool isOdd;
            Console.Write("Enter a integer number n= ");
            if (int.TryParse(Console.ReadLine(),out num))
            {
                if (num%2!=0)
                {
                    isOdd = true;
                }
                else
                {
                    isOdd = false;
                }
                Console.WriteLine(isOdd);
            }
            else
            {
                Console.WriteLine("Invalid Number!!!");
            }


        }
    }
}
