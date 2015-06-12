using System;


namespace _01.DeclareVariables
{
    class DeclareVariables
    {
        /* Problem 1.	Declare Variables
             Declare five variables choosing for each of them the most appropriate of the types byte,
             sbyte, short, ushort, int, uint, long, ulong to represent the following values:
             52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to ensure
             it will fit in it. Try to compile the code. Submit the source code of your Visual Studio
             project as part of your homework submission.*/

        static void Main()
        {
            ushort usho = 52130;
            sbyte sbite = -115;
            int integer = 4825932;
            byte bite = 97;
            short shor = -10000;

            Console.WriteLine("{0} is ushort type,\n {1} is sbyte type,\n{2}is int type,\n {3} is byte type,\n {4} is short type", usho, sbite, integer, bite, shor);

        }
    }
}
