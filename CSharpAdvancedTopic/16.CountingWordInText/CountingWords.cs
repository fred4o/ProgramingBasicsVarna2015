using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _16.CountingWordInText
{
    class CountingWords
    {
        //Problem 16.Counting a Word in a Text   
        //Write a program that counts how many times a given word occurs in given text. 
        //The first line in the input holds the word. The second line of the input holds the text.
        //The output should be a single integer number – the number of word occurrences. Matching should be
        //case-insensitive. Note that not all matching substrings are words and should be counted.
        //A word is a sequence of letters separated by punctuation or start / end of text.

        static void Main()
        {

            string wordInput =Console.ReadLine();
            string textInput = Console.ReadLine();

            textInput = Regex.Replace(textInput, "[^0-9a-zA-Z]+", " ");
            string[] words = textInput.Split();
            Array.Sort(words);

            List<string> wordsTocount = new List<string>();
            foreach (var item in words)
            {
                if (item.ToLower()==wordInput.ToLower())
                {
                    wordsTocount.Add(item);
                }
            }
            Console.WriteLine(wordsTocount.Count());
        }
    }
}
