using System;

namespace _09.PlayWithIntDoubleAndString
{
    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
        //    Problem 9. Play with Int, Double and String

        //Write a program that, depending on the user’s choice, inputs an int, double or string variable.
        //If the variable is int or double, the program increases it by one.
        //If the variable is a string, the program appends * at the end.
        //Print the result at the console. Use switch statement.

            Console.WriteLine("Play With Int Double And String");
            Console.WriteLine("-------------------------------");
            byte chosing = 0;
            int num = 0;
            double dbl = 0;
            int index = 1;
            string str = "";
            Console.WriteLine("Please choose type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            chosing = byte.Parse(Console.ReadLine());
            switch (chosing)
            {
                case 1:
                    Console.WriteLine("Please enter a integer number:");
                    num = int.Parse(Console.ReadLine());
                    num = num + index;
                    Console.WriteLine(num);
                    break;
                case 2:
                    Console.WriteLine("Please enter a double number ");
                    dbl = double.Parse(Console.ReadLine());
                    dbl = dbl + index;
                    Console.WriteLine(dbl);
                    break;
                case 3:
                    Console.WriteLine("Please enter a string");
                    str= Console.ReadLine();
                    str = str + "*";
                    Console.WriteLine(str);
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }
        }
    }
}
