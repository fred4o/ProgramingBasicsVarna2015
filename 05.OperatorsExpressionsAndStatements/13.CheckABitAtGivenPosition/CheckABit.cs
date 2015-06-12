using System;


namespace _13.CheckABitAtGivenPosition
{
    class CheckABit
    {
//        Problem 13.	Check a Bit at Given Position
//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right)
//        in given integer number n has value of 1

        static void Main()
        {
            Console.WriteLine("Please enter a number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a Position of bit:");
            int position = int.Parse(Console.ReadLine());

            int bitAtright = num >> position;
            int bit = bitAtright & 1;
            bool isOne = bit == 1 ? true : false;
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
            Console.WriteLine("the {0} Bit from right is it = 1? \n{1}", position, isOne);
        }
    }
}
