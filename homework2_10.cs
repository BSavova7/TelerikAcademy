using System;

    class Companymarketing
    {
        static void Main(string[] args)
        {
            String FirstName;
            String LastName;
            Byte Age;
            Char Gender; // m or f
            long PersonalIDNumber; // 8306112507
            uint UniqueEmployeeNumber; // 27560000…27569999
            FirstName = "FirstNameEmployee";
            LastName = "LastNameEmployee";
            Age = 35;
            Gender = 'm';
            PersonalIDNumber = 8406222507;
            UniqueEmployeeNumber = 27567777;
            Console.WriteLine("FirstName: {0}\nLastName: {1}\nAge: {2}\nGender (m or f): {3}\n", FirstName, LastName,Age,Gender);
            Console.WriteLine("PersonalIDNumber: {0}\nUniqueEmployeeNumber: {1}\n\n", PersonalIDNumber, UniqueEmployeeNumber);

        }
    }
