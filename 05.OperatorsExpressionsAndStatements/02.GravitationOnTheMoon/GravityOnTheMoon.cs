using System;


namespace _02.GravitationOnTheMoon
{
    class GravityOnTheMoon
    {
    //    Problem 2.	Gravitation on the Moon
    //The gravitational field of the Moon is approximately 17% of that on the Earth. 
    //Write a program that calculates the weight of a man on the moon by a given weight on the Earth

        static void Main()
        {
            double weight;
            double weightOnTheMoon;
            Console.Write("Enter your weight?");
            if (double.TryParse(Console.ReadLine(),out weight))
            {
                weightOnTheMoon = weight * 17 / 100;
                Console.WriteLine("Your Weight on the moon will be {0}",weightOnTheMoon);
            }
            else
            {
                Console.WriteLine("Invalid weight number!!!");
            }
        }
    }
}
