using System;


namespace _02.PrintCompanyInfo
{
    class PrintCompanyInfo
    {
        //Problem 2.	Print Company Information
        //A company has name, address, phone number, fax number, web site and manager. 
        //The manager has first name, last name, age and a phone number. Write a program 
        //that reads the information about a company and its manager and prints it back on the console.

        static void Main()
        {
            Company newCompany = new Company();
            Console.WriteLine("Enter Company Name:");
            newCompany.name = Console.ReadLine();
            Console.WriteLine("Address:");
            newCompany.address = Console.ReadLine();
            Console.WriteLine("Phone Number:");
            newCompany.phoneNum = long.Parse(Console.ReadLine());
            Console.WriteLine("Fax Number:");
            newCompany.faxNum = long.Parse(Console.ReadLine());
            Console.WriteLine("Website:");
            newCompany.webSite = Console.ReadLine();

            Console.WriteLine("Enter company CEO first name:");
            newCompany.boss.firstName = Console.ReadLine();
            Console.WriteLine("Enter CEO last name:");
            newCompany.boss.lastName = Console.ReadLine();
            Console.WriteLine("age:");
            newCompany.boss.age = byte.Parse(Console.ReadLine());
            Console.WriteLine("phone number");
            newCompany.boss.phoneNum = long.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------\n");

            Console.WriteLine("Your Company INFO:\n{0}\n{1}\n{2}\n{3}\n{4}", newCompany.name, newCompany.address, newCompany.phoneNum, newCompany.faxNum, newCompany.webSite);
            Console.WriteLine("Your Company CEO INFO:\n{0}\n{1}\n{2}\n{3}", newCompany.boss.firstName, newCompany.boss.lastName, newCompany.boss.age, newCompany.boss.phoneNum);
            Console.Read();
        }
        public class Company
        {
            public string name { get; set; }
            public string address { get; set; }
            public long phoneNum { get; set; }
            public long faxNum { get; set; }
            public string webSite { get; set; }

            public Manager boss = new Manager();
        }
        public class Manager
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public byte age { get; set; }
            public long phoneNum { get; set; }
        }
    }
}
