using System;


namespace _04MultiplicationSign
{
    class MultiplicationSign
    {
        //Problem 4. Multiplication Sign

        //Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
        //Use a sequence of if operators.

        static void Main()
        {
            Console.WriteLine("Multiplication Sign");
            Console.WriteLine("-------------------");
            double firsNum ,secondNum, thirdNum;
            Console.WriteLine("Enter 3 real numbers");
            Console.Write("a = ");
            double.TryParse(Console.ReadLine(),out firsNum);
            Console.Write("b = ");
            double.TryParse(Console.ReadLine(), out secondNum);
            Console.Write("c = ");
            double.TryParse(Console.ReadLine(),out thirdNum);
            if (firsNum*secondNum*thirdNum > 0)
            {
                Console.WriteLine("+");
            }
            else if (firsNum*secondNum*thirdNum < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("0");
            }
          

        }
    }
}
