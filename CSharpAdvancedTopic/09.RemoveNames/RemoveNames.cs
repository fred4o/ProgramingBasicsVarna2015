using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RemoveNames
{
    class RemoveNames
    {
        //Problem 9.	Remove Names
        //Write a program that takes as input two lists of names and removes from the first list all names given in the second list.
        //The input and output lists are given as words, separated by a space, each list at a separate line.

        static void Main()
        {
            string[] allNames = Console.ReadLine().Split();
            string[] namesForRemove = Console.ReadLine().Split();
            List<string> names = new List<string>();

            foreach (var item in allNames)
            {
                names.Add(item);
            }
            foreach (var item in namesForRemove)
            {
                names.RemoveAll(n=>n.ToLower()==item.ToLower());
            }

            foreach (var item in names)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
