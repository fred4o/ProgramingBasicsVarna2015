using System;


namespace _07.SortThreeNumbers
{
    class SortThreeNumbers
    {
        static void Main()
        {
            
        //Problem 7. Sort 3 Numbers with Nested Ifs

        //Write a program that enters 3 real numbers and prints them sorted in descending order.
        //Use nested if statements.
        //Note: Don’t use arrays and the built-in sorting functionality.


            Console.WriteLine("Sort Three Numbers");
            Console.WriteLine("------------------");
            double firstNum, secondNum, thirdNum;

            Console.WriteLine("Enter 3 real numbers");
            Console.Write("a = ");
            double.TryParse(Console.ReadLine(),out firstNum);
            Console.Write("b = ");
            double.TryParse(Console.ReadLine(),out secondNum);
            Console.Write("c = ");
            double.TryParse(Console.ReadLine(),out thirdNum);

            if (firstNum>secondNum && firstNum>thirdNum)
            {
                
                if (secondNum> thirdNum)
                {
                    Console.WriteLine("{0} {1} {2}",firstNum,secondNum,thirdNum);
                  
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", firstNum, thirdNum, secondNum);
                    
                }
                
                
            }
            else if (secondNum>thirdNum && secondNum>firstNum)
            {
               
                if (firstNum > thirdNum)
                {

                    Console.WriteLine("{0} {1} {2}", secondNum, firstNum, thirdNum);
                }
                else
                {

                    Console.WriteLine("{0} {1} {2}",secondNum,thirdNum,firstNum);
                }
            }
            else
            {
            
                if (firstNum > secondNum)
                {

                   Console.WriteLine("{0} {1} {2}",thirdNum,firstNum,secondNum);
                }
                else
                {

                    Console.WriteLine("{0} {1} {2}",thirdNum,secondNum,firstNum);
                }
            }
          
        }
    }
}
