using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CountOfLetters
{
    class CountOfLetters
    {
        //Problem 11.	Count of Letters
        //Write a program that reads a list of letters and prints for each letter how many times it appears in the list.The letters should be listed in 
        //alphabetical order. Use the input and output format from the examples below. 
        static void Main()
        {
            string input = Console.ReadLine(); 
            string[] letter = input.Split();
           
            SortedDictionary<string,int> sortedLetter = new SortedDictionary<string,int>();
            foreach (var item in letter)
            {
                if (sortedLetter.ContainsKey(item))
                {
                    sortedLetter[item]++;
                }
                else
                {
                    sortedLetter.Add(item, 1);
                }
            }
            foreach (var item in sortedLetter)
            {
                Console.WriteLine("{0} -> {1}",item.Key,item.Value);
            }
            
        }
    }
}
