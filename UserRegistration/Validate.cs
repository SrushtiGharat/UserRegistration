using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Validate
    {
        string regexFirstName = "^[A-Z][a-z]{2,}$";
        string regexLastName = "^[A-Z][a-z]{2,}$";

        public void ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, regexFirstName) == true)
            {
                Console.WriteLine("First name is valid");
                return;
            }
            Console.WriteLine("First name is invalid");
            Console.WriteLine("Enter first name again");
            firstName = Console.ReadLine();
            ValidateFirstName(firstName);
        }
        public void ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, regexLastName) == true)
            {
                Console.WriteLine("Last name is valid");
                return;
            }
            Console.WriteLine("Last name is invalid");
            Console.WriteLine("Enter last name again");
            lastName = Console.ReadLine();
            ValidateLastName(lastName);
        }
    }
}
