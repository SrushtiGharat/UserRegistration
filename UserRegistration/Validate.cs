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

        public string ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, regexFirstName))
            {
                return "First Name Is Valid";
            }
            else
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_FIRST_NAME, "First Name Is Invalid");
            }

        }
        public string ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, regexLastName))
            {
                return "Last Name Is Valid";
            }
            else
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_LAST_NAME, "Last Name Is Invalid");
            }
        }
        public string ValidateEmail(string eMail)
        {
            if (Regex.IsMatch(eMail, regexEmail))
            {
                return "Email Id Is Valid";
            }
            else
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_EMAIL, "Email Id Is Invalid");
            }

        }
        public string ValidatePhoneNo(string phoneNo)
        {
            if (Regex.IsMatch(phoneNo, regexPhoneNo))
            {
                return "Phone No Is Valid";
            }
            else
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_PHONENO, "Phone No Is Invalid");
            }

        }
        public string ValidatePassword(string password)
        {
            if (Regex.IsMatch(password, regexPassword))
            {
                return "Password Is Valid";
            }
            else
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_PASSWORD, "Password Is Invalid");
            }

        }
    }
}
