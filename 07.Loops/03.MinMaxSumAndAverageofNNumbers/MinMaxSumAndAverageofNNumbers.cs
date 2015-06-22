using System;


namespace _03.MinMaxSumAndAverageofNNumbers
{
    class MinMaxSumAndAverageofNNumbers
    {

        //Problem 3. Min, Max, Sum and Average of N Numbers

        //Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number,
        //the sum and the average of all numbers (displayed with 2 digits after the decimal point).
        //The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
        //The output is like in the examples below.


        static void Main()
        {
            Console.WriteLine("Enter N numbers");
            int nums,min,max,sum;
            int.TryParse(Console.ReadLine(),out nums);
            Console.WriteLine("Enter {0} numbers each on Line",nums);
            min = int.MaxValue;
            max = int.MinValue;
            sum = 0;
            for (int i = 0; i < nums; i++)
            {
                int number;
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number < min)
                    {
                        min = number;
                    }
                    if (number > max)
                    {
                        max = number;
                    }
                    sum += number;
                }
                else
                {
                    Console.WriteLine("Ivalid Number!!! Try Again!");
                    i--;
                }
            }
            double avg = (double)sum / (double)nums;
            
            Console.WriteLine("min = {0} \nmax = {1} \nsum = {2} \navg = {3:F2} ",min,max,sum,avg);
           

        }

    }
}
