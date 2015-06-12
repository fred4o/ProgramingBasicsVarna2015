using System;


namespace _10.EnployeeData
{
    class EmployeeData
    {
        /*
        Problem 10. Employee Data

        A marketing company wants to keep record of its employees. Each record would have the following characteristics:

        First name
        Last name
        Age (0...100)
        Gender (m or f)
        Personal ID number (e.g. 8306112507)
        Unique employee number (27560000…27569999)
        Declare the variables needed to keep the information for a single employee using appropriate
        primitive data types. Use descriptive names. Print the data at the console.
         */
        static void Main()
        {
            Employee emp = new Employee()
            {
                name = "Milen",
                lastName = "Pavlov",
                age = 29,
                gender = 'm',
                id = 8306112507,
                uniqueEN = 275600000,
            };

            Console.WriteLine("Employee detailed info\n");
            Console.WriteLine("ID number {0}", emp.id);
            Console.WriteLine("First name: {0}", emp.name);
            Console.WriteLine("Last name: {0}", emp.lastName);
            Console.WriteLine("Ages: {0}", emp.age);
            Console.WriteLine("Gender (male or female): {0}", emp.gender);
            Console.WriteLine("Unique Employee Number: {0}", emp.uniqueEN);

           
        }
        public class Employee
        {
            public string name { get; set; }
            public string lastName { get; set; }
            public byte age { get; set; }
            public char gender { get; set; }
            public long id { get; set; }
            public int uniqueEN { get; set; }
        }
    }
}
