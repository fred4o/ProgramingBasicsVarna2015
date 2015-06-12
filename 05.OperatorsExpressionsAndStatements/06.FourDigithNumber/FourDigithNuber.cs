using System;

namespace _06.FourDigithNumber
{
    class FourDigithNuber
    {
        //        Problem 6.	Four-Digit Number
        //Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
        //•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
        //•	Prints on the console the number in reversed order: dcba (in our example 1102).
        //•	Puts the last digit in the first position: dabc (in our example 1201).
        //•	Exchanges the second and the third digits: acbd (in our example 2101).
        //The number has always exactly 4 digits and cannot start with 0

        static void Main()
        {
            Console.WriteLine("Enter a four digith number in format (0000)");
            int num;
            if (int.TryParse(Console.ReadLine(), out num))
            {

                if (num < 1000 || num > 9999)
                {
                    Console.WriteLine("Invalid Unmber");

                }
                else
                {
                    Console.WriteLine("Sum of digits in your number is : {0}", SumOfDigithCalc(num));
                    Console.WriteLine("Your number in reserved view {0}", ReverseNumber(num));
                    Console.WriteLine("Last digit from your number on first place: {0}", LastDigitAtFirst(num));
                    Console.WriteLine("The number after exchanging second and third digit is: {0}" + "{1}" + "{2}" + "{3}", ExchangeSeondAndThirdDigit(num));
                }
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
        }

        private static string ExchangeSeondAndThirdDigit(int num)
        {
            int firstDigith = num / 1000;
            int firstDigithNum = firstDigith % 10;
            int secondDigith = num / 100;
            int secondDigithNum = secondDigith % 10;
            int thirdDigith = num / 10;
            int thirdDigithNum = thirdDigith % 10;
            int fourthDigithNum = num % 10;
            string exChanged = firstDigithNum.ToString() + secondDigithNum.ToString() + thirdDigithNum.ToString() + fourthDigithNum.ToString();
            return exChanged;
        }

        private static string LastDigitAtFirst(int num)
        {
            int secondHalf = 0;
            secondHalf = secondHalf * 10 + num % 10; ;
            int firstHalf = num / 10;
            string lastDigFirst = secondHalf.ToString() + firstHalf.ToString();
            return lastDigFirst;
        }

        private static int ReverseNumber(int input)
        {
            int left = input;
            int reverse = 0;

            while (left > 0)
            {
                reverse = reverse * 10 + left % 10;
                left = left / 10;
            }
            return reverse;
        }

        private static int SumOfDigithCalc(int input)
        {
            int number = input;
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
           
        }

    }
}
