using System;


namespace _05.FormatingNumbers
{
    class FormatingNumbers
    {
        //Problem 5.	Formatting Numbers
        //Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point
        //c and prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. 
        //The number a should be printed in hexadecimal, left aligned; then the number a should be printed in 
        //binary form, padded with zeroes, then the number b should be printed with 2 digits after the decimal 
        //point, right aligned; the number c should be printed with 3 digits after the decimal point, left aligned.

        static void Main()
        {
            Console.WriteLine("Formating Numbers");
            Console.WriteLine("Enter 3 numbers.");
            Console.Write("first number (0 ~ 500) = ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("second number (e.g. 2.53) = ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.Write("third number (e.g. 5.44) = ");
            double thirdNum = double.Parse(Console.ReadLine());

            string bitwiseFirstNum = Convert.ToString(firstNum, 2).PadLeft(10, '0');

            Console.WriteLine("|{0,-10:X}|{1}|{2,10:0.##}|{3,-10:0.###}|", firstNum, bitwiseFirstNum, secondNum, thirdNum);
        }
    }
}
