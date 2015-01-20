using System;

    class BankAccount
    {
        static void Main()
        {
            string FirstName;
            string MiddleName;
            string LastName;
            int balance;
            string bankName="MyBank";
            object IBAN; 
            dynamic creditCard;
            balance = 2345678;
            creditCard="BG4000030081";
            creditCard="BG4000030082";
            creditCard="BG4000030083";
            IBAN="BG58RZBB91555087474816";
            FirstName = "MyFirstName";
            MiddleName ="MyMiddleName";
            LastName = "MyLastName";
            Console.WriteLine("FirstName: {0}\nMiddleName: {1}\nLastName: {2}\n\n", FirstName, MiddleName, LastName);
            Console.WriteLine("balance= {0}\n", balance);
        }
    }
