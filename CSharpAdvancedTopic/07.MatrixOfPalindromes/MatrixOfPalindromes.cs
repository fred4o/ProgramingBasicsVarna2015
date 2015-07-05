using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        //Problem 7.	Matrix of Palindromes
        //Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns:

        static void Main()
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            byte firstLeter, secondLetter,thirdLetter;
            firstLeter = secondLetter = thirdLetter = 97;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {

                    Console.Write("{0}", (char)firstLeter);
                    Console.Write("{0}", (char)secondLetter);
                    Console.Write("{0}", (char)thirdLetter);
                    Console.Write(" ");
                    secondLetter++;

                }
                Console.WriteLine();
                firstLeter++;
                secondLetter = firstLeter;
                thirdLetter = firstLeter;
            }
        }
    }
}
