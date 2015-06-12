using System;


namespace _12.ExactBitFromInteger
{
    class ExactBitFromInt
    {
        static void Main()
        {
            int num, position, bitAtright, bit;

            Console.WriteLine("Please enter a number:");

            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a Position of bit:");
            position = int.Parse(Console.ReadLine());

            bitAtright = num >> position;
            bit = bitAtright & 1;

            Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
            Console.WriteLine("the {0} Bit from right is = {1}", position, bit);
        }
    }
}
