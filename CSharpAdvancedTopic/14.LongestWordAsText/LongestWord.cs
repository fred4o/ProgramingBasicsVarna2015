using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.LongestWordAsText
{
    class LongestWord
    {
//        Problem 14.	Longest Word in a Text
//Write a program to find the longest word in a text

        static void Main()
        {
            string input = Console.ReadLine();
            string[] words = input.Split();
            string longestWord = "";
            int counter = 0;

            foreach (var item in words)
            {
                int wordCharCounter = 0;
                for (int i = 0; i < item.Length; i++)
                {
                    wordCharCounter++;
                }
                if (wordCharCounter>counter)
                {
                    counter = wordCharCounter;
                    longestWord = item;
                }
            }
            Console.WriteLine(longestWord);
        }
    }
}
