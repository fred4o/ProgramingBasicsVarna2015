using System;


namespace _03.CheckForPlaycard
{
    class checkForPlaycard
    {

        //Problem 3. Check for a Play Card

        //Classical play cards use the following signs to designate the card face:
        //2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.
        static void Main()
        {
            Console.WriteLine("Check For PlayCard");
            Console.WriteLine("------------------");
            string card = Console.ReadLine();
            string[] cardStack = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            bool isPartofDeck =false;

            foreach (var item in cardStack)
            {
                if (item==card)
                {
                    isPartofDeck = true;
                    break;
                }
              
            }

            if (isPartofDeck)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
