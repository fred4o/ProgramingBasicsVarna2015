using System;


namespace _15.BitExChange
{
    class BitExchange
    {
        //Problem 15. Bits Exchange
        //Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. 

        static void Main()
        {

            Console.WriteLine("Please enter a number between 0 ~ {0}:", int.MaxValue);

            int num = int.Parse(Console.ReadLine());

            // exchange bits 
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
            for (int littleBits = 3; littleBits <= 5; littleBits++)
            {
                int largeBits = littleBits + 21;

                int bitAtright = num >> littleBits;
                int smallBit = bitAtright & 1;
                //Console.WriteLine(smallBit);

                int bitAtleft = num >> largeBits;
                int bigBit = bitAtleft & 1;
                //Console.WriteLine(bigBit);

                if (smallBit == 1)
                {

                    num = num | (1 << largeBits);
                }
                else
                {
                    num = num & (~(1 << largeBits));
                }
                if (bigBit == 1)
                {
                    num = num | (1 << littleBits);
                }
                else
                {
                    num = num & (~(1 << littleBits));
                }

            }
            Console.WriteLine("Binary representation after exchange is \n{0}", Convert.ToString(num, 2).PadLeft(32, '0'));
            Console.WriteLine("Your number after exchanging bites 3,4,5 <> 24,25,26 is: {0}", num);
        }
    }
}
