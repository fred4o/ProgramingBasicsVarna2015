using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _15.ExtractUrlsFromText
{
    class ExtrractURL
    {
        //Problem 15.	Extract URLs from Text
        //Write a program that extracts and prints all URLs from given text.URL can be in only two formats:
        //•	http://something, e.g. http://softuni.bg, http://forums.softuni.bg, http://www.nakov.com 
        //•	www.something.domain, e.g.www.nakov.com, www.softuni.bg, www.google.com

        static void Main()

        {
            string input = "The site nakov.com can be access from http://nakov.com or www.nakov.com. It has subdomains like mail.nakov.com and svetlin.nakov.com. Please check http://blog.nakov.com for more information.";
            string[] words = input.Split();
            List<string> urls = new List<string>();
            foreach (var item in words)
            {
                if (CheckForURL(item))
                {
                    urls.Add(item);
                }
            }

            foreach (var item in urls)
            {
                Console.WriteLine(item);
            }
        }
        private static bool CheckForURL(string input)
        {
            Regex reg = new Regex(@"^www.|http(s)?://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$");
            if (reg.IsMatch(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }
    }
}
