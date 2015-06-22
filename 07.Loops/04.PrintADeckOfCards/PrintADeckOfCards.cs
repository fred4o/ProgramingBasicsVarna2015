using System;


namespace _04.PrintADeckOfCards
{
    class PrintADeckOfCards
    {

            //Problem 4. Print a Deck of 52 Cards

            //Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
            //The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
            //The card faces should start from 2 to A.
            //Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.


        static void Main()
        {
            string[] faces = { " 2", " 3", " 4", " 5", " 6", " 7", " 8", " 9", "10", " J", " Q"," K"," A" };
            string[] suits = {"\u2660 ","\u2665", "\u2666","\u2663" };
            for (int i = 0; i < faces.Length; i++)
            {
                for (int n = 0; n < suits.Length; n++)
                {
                    Console.Write("{0}{1:X} ",faces[i],suits[n]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
