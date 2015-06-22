using System;


namespace _09.MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        //Problem 9. Matrix of Numbers

        //Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.
        static void Main()
        {
            Console.WriteLine("Matrix of Numbers");
            Console.WriteLine("-----------------");
            Console.Write("Enter a positive number (1 - 20) n = ");
            int num;
            int.TryParse(Console.ReadLine(),out num);
            if (1<=num && num <=20)
            {
                for (int i = 1; i <= num; i++)
                {

                    for (int j = i; j < num + i; j++)
                    {
                            Console.Write(" {0}", j);
                    }
                   
                    Console.WriteLine();
                   
                }
            }
            else
            {
                Console.WriteLine("Out of range. Try again");    
            }
            Console.WriteLine();
            
         
        }
    }
}
