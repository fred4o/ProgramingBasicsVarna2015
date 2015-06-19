using System;


namespace _11.NumbersAsWords
{
    class NumberAsWords
    {
        static void Main()
        {

            //Problem 11.* Number as Words

            //Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

            Console.WriteLine("Numbers As Words");
            Console.WriteLine("----------------");
            Console.WriteLine("Enter a number in range (0 - 999)");
            int num = 0;
            num = int.Parse(Console.ReadLine());
            
            
            string[] nums = {"Zero","One","Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten",
                            "Eleven","Twelve","Thirteen","Fourteen","Fifteen","Sixteen","Seventeen", "Eighteen","Nineteen"};
            string[] tens = { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            int tenNum, firstNum, hundredNums;

            if (num > 999)
            {
                Console.WriteLine("Invalid Number. Not in Range");
            }
            else
            {


                if (num < 20)
                {
                    Console.WriteLine(nums.GetValue(num));
                }
                else if (num > 19 && num < 100)
                {
                    tenNum = num / 10 - 2;
                    firstNum = num % 10;

                    if (firstNum == 0)
                    {
                        Console.WriteLine(tens.GetValue(tenNum));
                    }
                    else
                    {
                        Console.WriteLine("{0} {1}", tens.GetValue(tenNum), nums.GetValue(firstNum));
                    }
                }
                else if (num > 99 && num < 1000)
                {

                    hundredNums = num / 100;
                    tenNum = num / 10 % 10;
                    firstNum = num % 10;

                    if (firstNum == 0)
                    {
                        if (tenNum == 0)
                        {
                            Console.WriteLine("{0} hundred ", nums.GetValue(hundredNums));
                        }
                        else if (tenNum == 1)
                        {
                            tenNum = tenNum + 9;
                            Console.WriteLine("{0} hundred and {1} ", nums.GetValue(hundredNums), nums.GetValue(tenNum));

                        }
                        else
                        {
                            tenNum = tenNum - 2;
                            Console.WriteLine("{0} hundred and {1} ", nums.GetValue(hundredNums), tens.GetValue(tenNum));
                        }

                    }
                    else if (tenNum == 0)
                    {
                        Console.WriteLine("{0} hundred and {1} ", nums.GetValue(hundredNums), nums.GetValue(firstNum));
                    }
                    else
                    {
                        tenNum = tenNum % 10 - 2;
                        if (tenNum < 0)
                        {
                            tenNum = tenNum * tenNum;
                            tenNum = tenNum + firstNum + 9;
                            Console.WriteLine("{0} hundred and {1} ", nums.GetValue(hundredNums), nums.GetValue(tenNum));

                        }
                        else
                        {
                            Console.WriteLine("{0} hundred and {1} {2} ", nums.GetValue(hundredNums), tens.GetValue(tenNum), nums.GetValue(firstNum));
                        }
                    }
                }
            }
      
        }
    }
}

