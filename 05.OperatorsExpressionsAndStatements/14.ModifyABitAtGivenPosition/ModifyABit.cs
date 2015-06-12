using System;

namespace _14.ModifyABitAtGivenPosition
{
    class ModifyABit
    {
        //Problem 14.	Modify a Bit at Given Position
        //We are given an integer number n, a bit value v (v=0 or 1) and a position p. 
        //Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v 
        //at the position p from the binary representation of n while preserving all other bits in n.

        static void Main()
        {
            Console.WriteLine("Enter a number? n = ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a position of bite for exchange. p =");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value of bite for exchange (0 or 1) v=");
            byte value = byte.Parse(Console.ReadLine());

            // exchanging bits 
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
            for (int f = position; f <= position; f++)
            {
                int bitAtright = num >> f;
                if (value == 1)
                {
                    num = num | (1 << f);
                }
                else
                {
                    num = num & (~(1 << f));
                }
            }
            Console.WriteLine("Binary representation after modify is \n{0}", Convert.ToString(num, 2).PadLeft(32, '0'));
            Console.WriteLine("Your number after modify bites is: {0}", num);
        }
    }
}
