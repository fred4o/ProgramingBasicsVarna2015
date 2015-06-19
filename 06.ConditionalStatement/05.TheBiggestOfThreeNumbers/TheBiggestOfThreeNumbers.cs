using System;


namespace _05.TheBiggestOfThreeNumbers
{
    class TheBiggestOfThreeNumbers
    {
        //Problem 5. The Biggest of 3 Numbers

        //Write a program that finds the biggest of three numbers.

        static void Main()
        {
            Console.WriteLine("the Biggest of 3 numbers ");
            Console.WriteLine("-------------------");
            double firsNum, secondNum, thirdNum = 0;
            Console.WriteLine("Enter 3 real numbers");
            Console.Write("a = ");
            double.TryParse(Console.ReadLine(),out firsNum);
            Console.Write("b = ");
            double.TryParse(Console.ReadLine(),out secondNum);
            Console.Write("c = ");
            double.TryParse(Console.ReadLine(),out thirdNum);

            if (firsNum > secondNum && firsNum > thirdNum)
            {
               Console.WriteLine(firsNum);
            }
            else if (secondNum > firsNum && secondNum > thirdNum)
            {
                Console.WriteLine(secondNum);
            }
            else if (firsNum == secondNum && secondNum == thirdNum)
            {
                Console.WriteLine("Three numbers are equal ");
            }
            else
            {
                Console.WriteLine(thirdNum);
            }
           
            
        }
    }
}
