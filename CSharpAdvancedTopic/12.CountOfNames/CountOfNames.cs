using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CountOfNames
{
    class CountOfNames
    {
        //Problem 12.	Count of Names
        //Write a program that reads a list of names and prints for each name how many times it appears in the list.The names should be listed 
        //in alphabetical order. Use the input and output format from the examples below.
        static void Main()
        {
            string[] names = Console.ReadLine().Split();
            SortedDictionary<string, int> sortedNames= new SortedDictionary<string, int>();
            foreach (var item in names)
            {
                if (sortedNames.ContainsKey(item))
                {
                    sortedNames[item]++;
                }
                else
                {
                    sortedNames.Add(item, 1);
                }
            }
            foreach (var item in sortedNames)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
        
    }
}
