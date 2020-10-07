using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Validate
    {
        string regexFirstName = "^[A-Z][a-z]{2,}$";
        string regexLastName = "^[A-Z][a-z]{2,}$";
        string regexEmail = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)?[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        string regexPhoneNo = "^[1-9][0-9]{1,2}[ ][1-9][0-9]{9}$";
        string regexPassword = "^(?=.*[A-Z])(?=.*[0-9])[!@#$%^&*()]{1}[a-zA-Z0-9!@#$%^&*()]{8,}$";
        
        //"^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()]{1})[a-zA-Z0-9!@#$%^&*()]{8,}$";
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
        public void ValidateEmail(string eMail)
        {
            if (Regex.IsMatch(eMail, regexEmail) == true)
            {
                Console.WriteLine("Email is valid");
                return;
            }
            Console.WriteLine("Email is invalid");
            Console.WriteLine("Enter Email again");
            eMail = Console.ReadLine();
            ValidateEmail(eMail);
        }
        public void ValidatePhoneNo(string phoneNo)
        {
            if (Regex.IsMatch(phoneNo, regexPhoneNo) == true)
            {
                Console.WriteLine("Phone No is valid");
                return;
            }
            Console.WriteLine("Phone No is invalid");
            Console.WriteLine("Enter Phone No again");
            phoneNo = Console.ReadLine();
            ValidatePhoneNo(phoneNo);
        }
        public void ValidatePassword(string password)
        {
            if (Regex.IsMatch(password, regexPassword) == true)
            {
                Console.WriteLine("Password is valid");
                return;
            }
            Console.WriteLine("Password is invalid");
            Console.WriteLine("Enter Password again");
            password = Console.ReadLine();
            ValidatePassword(password);
        }
    }
}
