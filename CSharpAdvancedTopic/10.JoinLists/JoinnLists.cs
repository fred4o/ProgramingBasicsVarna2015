using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.JoinLists
{
    class JoinnLists
    {
        //Problem 10.	Join Lists
        //Write a program that takes as input two lists of integers and joins them.The result should hold all numbers from the first list,
        //and all numbers from the second list, without repeating numbers, and arranged in increasing order. The input and output lists are
        //given as integers, separated by a space, each list at a separate line

        static void Main()
        {
            string[] firstNumms = Console.ReadLine().Split();
            string[] secondNumms = Console.ReadLine().Split();
            SortedSet<int> numbers = new SortedSet<int>();
            foreach (var item in firstNumms)
            {
                numbers.Add(int.Parse(item));
            }
            foreach (var item in secondNumms)
            {
                numbers.Add(int.Parse(item));
            }

            foreach (var item in numbers)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();
        }
    }
}
