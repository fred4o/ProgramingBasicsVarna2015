using System;


namespace _02.BonusScore
{
    class BonusScore
    {

        //Problem 2. Bonus Score

        //Write a program that applies bonus score to given score in the range [1…9] by the following rules:
        //If the score is between 1 and 3, the program multiplies it by 10.
        //If the score is between 4 and 6, the program multiplies it by 100.
        //If the score is between 7 and 9, the program multiplies it by 1000.
        //If the score is 0 or more than 9, the program prints “invalid score”.

        static void Main()
        {
            Console.WriteLine("Bonus Score");
            Console.WriteLine("------------");
            int score, multiplayer;
            Console.WriteLine("enter score number between (1-9)");
            int.TryParse(Console.ReadLine(),out score);
            switch (score)
            {
                case 1:
                case 2:
                case 3:
                    multiplayer = 10;
                    score = score * multiplayer;
                    Console.WriteLine(score);
                    break;
                case 4:
                case 5:
                case 6:
                    multiplayer = 100;
                    score = score * multiplayer;
                    Console.WriteLine(score);
                    break;
                case 7:
                case 8:
                case 9:
                    multiplayer = 1000;
                    score = score * multiplayer;
                    Console.WriteLine(score);
                    break;

                default:
                    Console.WriteLine("Invalid Score");
                    break;
            }

        }
    }
}
