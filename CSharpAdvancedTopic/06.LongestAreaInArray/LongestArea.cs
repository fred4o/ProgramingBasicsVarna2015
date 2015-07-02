using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.LongestAreaInArray
{
    class LongestArea
    {
        //Problem 6.	Longest Area in Array
        //Write a program to find the longest area of equal elements in array of strings. 
        //You first should read an integer n and n strings (each at a separate line), 
        //then find and print the longest sequence of equal elements (first its length, then its elements).
        //If multiple sequences have the same maximal length, print the leftmost of them. 

        static void Main()
        {
            int num;
            int.TryParse( Console.ReadLine() ,out num );
            string[] arr = new string[num];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }

            foreach (var item in arr)
            {
                string 
            }
        }
    }
}
