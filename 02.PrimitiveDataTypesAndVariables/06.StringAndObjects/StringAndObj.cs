using System;


namespace _06.StringAndObjects
{
    class StringAndObj
    {
        /*
        Problem 6.	Strings and Objects
        Declare two string variables and assign them with “Hello” and “World”.
        Declare an object variable and assign it with the concatenation of the first two variables 
        (mind adding an interval between). Declare a third string variable and initialize it with the value
         of the object variable (you should perform type casting).
         */

        static void Main()
        {
            string firsWord, secondWord;
            firsWord = "Hello";
            secondWord = "World";
            object HelloWorld = firsWord +" "+ secondWord;
            string twoWords = (string)HelloWorld;
            Console.WriteLine(twoWords);
        }
    }
}
