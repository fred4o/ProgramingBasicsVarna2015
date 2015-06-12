using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BirWieseExact3Bit
{
    class Exact3Bit
    {
        //Problem 11.	Bitwise: Extract Bit #3
        //Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
        //The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0
        static void Main()
        {
            int num;
            Console.WriteLine("Please enter a number:");
            if (int.TryParse(Console.ReadLine(), out num))
            {

                int bitAtright = num >> 3;
                int bit = bitAtright & 1;
                Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
                Console.WriteLine("the Third Bit from right is {0}", bit);
            }
            else
            {
                Console.WriteLine("Invalid NUmber");
            }
        }
    }
}
