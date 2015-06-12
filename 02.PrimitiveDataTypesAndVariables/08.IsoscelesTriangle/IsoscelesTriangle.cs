using System;
using System.Text;


namespace _08.IsoscelesTriangle
{
    class IsoscelesTriangle
    {
       /* Problem 8.	Isosceles Triangle
        Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
                 ©
                © ©
               ©   ©
              © © © ©
       Note that the © symbol may be displayed incorrectly at the console so you may need to change
       the console character encoding to UTF-8 and assign a Unicode-friendly font in the console. 
       Note also, that under old versions of Windows the © symbol may still be displayed incorrectly, 
       regardless of how much effort you put to fix it.
        */

        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            char copyWright = '\xA9';
            char space = ' ';
            int num = 4;
            for (int i = 0 ; i < num; i++)
            {
                for (int j = num - i; j > 0; j--)
                {
                    Console.Write("{0}",space);
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("{0}{1}", copyWright,space);
                }
                Console.WriteLine();

            }
         
        }
    }
}
