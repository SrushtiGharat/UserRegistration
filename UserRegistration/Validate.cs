using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Validate
    {
        string regexFirstName = "^[A-Z][a-z]{2,}$";
        string regexLastName = "^[A-Z][a-z]{2,}$";
        string regexEmail = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        string regexPhoneNo = "^[1-9][0-9]{1,2}[ ][1-9][0-9]{9}$";
        string regexPassword = "^(?=.*[A-Z])(?=.*[0-9])(?=^[a-zA-Z0-9]*[!@#$%^&*()][a-zA-Z0-9]*$).{8,}$";
        
        public bool ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, regexFirstName) == true)
            {
                Console.WriteLine("First name is valid");
                return true;
            }
            return false;
            
        }
        public bool ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, regexLastName) == true)
            {
                Console.WriteLine("Last name is valid");
                return true;
            }
            return false;
        }
        public bool ValidateEmail(string eMail)
        {
            if (Regex.IsMatch(eMail, regexEmail) == true)
            {
                Console.WriteLine("Email is valid");
                return true;
            }
            return false;
        }
        public bool ValidatePhoneNo(string phoneNo)
        {
            if (Regex.IsMatch(phoneNo, regexPhoneNo) == true)
            {
                Console.WriteLine("Phone No is valid");
                return true;
            }
            return false;
        }
        public bool ValidatePassword(string password)
        {
            if (Regex.IsMatch(password, regexPassword) == true)
            {
                Console.WriteLine("Password is valid");
                return true;
            }
            return false;
        }
    }
}
