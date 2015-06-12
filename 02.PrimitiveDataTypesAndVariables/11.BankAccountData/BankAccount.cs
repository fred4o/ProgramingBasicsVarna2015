using System;


namespace _11.BankAccountData
{
    class BankAccount
    {
        /*
        Problem 11. Bank Account Data

        A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
        bank name, IBAN, 3 credit card numbers associated with the account.
        Declare the variables needed to keep the information for a single bank account using the appropriate data types
        and descriptive names.
        */
        static void Main()
        {
            //names Input
            Console.WriteLine("Please enter Your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your Surname:");
            string surName = Console.ReadLine();
            Console.WriteLine("Please enter your Familly");
            string lastName = Console.ReadLine();

            if (name == "Milen" || surName == "Ivanov" || lastName == "Pavlov")
            {


                //account
                BankAcccountDetails accDetails = new BankAcccountDetails()
                {

                    balance = 25566452.52M,
                    bankName = "First Investment Bank",
                    iban = "BG80 FIBG 9661 1020 3456 78",
                    bic = "FIBG",
                };
                accDetails.creditCards = new long[3];
                accDetails.creditCards[0] = 5555456668489995622;
                accDetails.creditCards[1] = 8899987785695655566;
                accDetails.creditCards[2] = 8755455664548545554;


                //information of account
                Console.WriteLine();
                Console.WriteLine("Good Day Mr. or Mrs. \n{0} {1} {2}", name, surName, lastName);
                Console.WriteLine("Your Bank is:\n{0}", accDetails.bankName);
                Console.WriteLine("Your bank acount IBAN is \n{0},\n with BIC code \n{1} ", accDetails.iban, accDetails.bic);
                Console.WriteLine("You have in your account: \nEU{0}\n", accDetails.balance);
                Console.WriteLine("in this number of cars:\n");

                foreach (long item in accDetails.creditCards)
                {
                    Console.WriteLine(item);
                }

            }
            else
            {
                Console.WriteLine("Access Denied. You are not autorised to account.");
            }
        }
        public class BankAcccountDetails
        {
            public decimal balance { get; set; }
            public string bankName { get; set; }
            public string iban { get; set; }
            public string bic { get; set; }
            public long[] creditCards { get; set; }
            
        }

    }
}
