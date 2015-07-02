using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortingNumbers
{
    class SortingNumbers
    {
        //Problem 5.	Sorting Numbers
        //Write a program that reads a number n and a sequence of n integers, sorts them and prints them

        static void Main()
        {
            int counter = 0;
            int.TryParse( Console.ReadLine() ,out counter );
            int[] numbers = new int [counter];
            for (int i = 0; i < numbers.Length; i++)
            {
                int.TryParse( Console.ReadLine() ,out numbers[i] );
            }
            Array.Sort(numbers);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
