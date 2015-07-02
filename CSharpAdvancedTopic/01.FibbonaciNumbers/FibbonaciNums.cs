using System;


namespace _01.FibbonaciNumbers
{
    class FibbonaciNums
    {
        //Problem 1.	Fibonacci Numbers
        //Define a method Fib(n) that calculates the nth Fibonacci number

        static void Main()
        {
            int num;
            int.TryParse( Console.ReadLine() ,out num);
            int fibNum = FibonaciNthNumber(num);
            Console.WriteLine(fibNum);
        }
        static int FibonaciNthNumber(int input)
        {
            int firsNum =0;
            int secondNum = 1;
            for (int i = 0; i < input; i++)
            {
                int temp = firsNum;
                firsNum = secondNum;
                secondNum = temp+secondNum;
            }
            return secondNum;
        
        }
    }
}
