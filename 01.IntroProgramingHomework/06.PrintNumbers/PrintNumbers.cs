using System;

namespace _06.PrintNumbers
{
    class PrintNumbers
    {
        /*
        Problem 6.	Print Numbers
        Write a program to print the numbers 1, 101 and 1001, each at a separate line. Name the program correctly.
        You should submit in your homework the Visual Studio project holding the source code of the PrintNumbers program.
        */

        static void Main()
        {
            int num = 1;
    
            Console.WriteLine("{0}\n{1}\n{2}", num, num + 100, num + 1000);

        }
    }
}
