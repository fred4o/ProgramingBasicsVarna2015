using System;


namespace _16.BitExchangeAdvanced
{
    class BitExchanageAdvanced
    {
        static void Main()
        {
            Console.WriteLine("Enter a number?");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a first bite for exchange");
            int firstBite = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second bite for exchange");
            int secondBite = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a # of bites to exchange");
            int operationNum = int.Parse(Console.ReadLine());

            // exchange bits 
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
            for (int littleBits = firstBite; littleBits <= firstBite + (operationNum - 1); littleBits++)
            {
                int largeBits = littleBits + (secondBite - firstBite);

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
