using System;

namespace _05.ThirdDigitIs7
{
    class ThirdDigithIs7
    {
//        Problem 5.	Third Digit is 7?
//Write an expression that checks for given integer if its third digit from right-to-left is 7

        static void Main()
        {
            int number;
            bool isThirdSeven;
            Console.WriteLine("Enter a integer N = ");
            if (int.TryParse(Console.ReadLine(),out number))
            {
                if (number/100%10==7)
                {
                    isThirdSeven = true;
                }
                else
                {
                    isThirdSeven = false;
                }
                Console.WriteLine(isThirdSeven);
            }
            else
            {
                Console.WriteLine("Invalid Number!!!");
            }
        }
    }
}
