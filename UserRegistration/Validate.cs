using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Validate
    {
        const string REGEX_FIRST_NAME = "^[A-Z][a-z]{2,}$";
        const string REGEX_LAST_NAME = "^[A-Z][a-z]{2,}$";
        const string REGEX_EMAIL = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        const string REGEX_PHONE_NO = "^[1-9][0-9]{1,2}[ ][1-9][0-9]{9}$";
        const string REGEX_PASSWORD = "^(?=.*[A-Z])(?=.*[0-9])(?=^[a-zA-Z0-9]*[!@#$%^&*()][a-zA-Z0-9]*$).{8,}$";
      
        public Func<string,string> ValidateFirstName = x => Regex.IsMatch(x, REGEX_FIRST_NAME) ? "First Name Is Valid" : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_FIRST_NAME, "First Name Is Invalid");
        public Func<string,string> ValidateLastName = x => Regex.IsMatch(x, REGEX_LAST_NAME) ? "Last Name Is Valid": throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_LAST_NAME, "Last Name Is Invalid");
        public Func<string, string> ValidateEmail = x => Regex.IsMatch(x, REGEX_EMAIL) ? "Email Id Is Valid": throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_EMAIL, "Email Id Is Invalid");
        public Func<string, string> ValidatePhoneNo = x => Regex.IsMatch(x, REGEX_PHONE_NO) ? "Phone No Is Valid" : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_PHONENO, "Phone No Is Invalid");
        public Func<string, string> ValidatePassword = x => Regex.IsMatch(x, REGEX_PASSWORD) ? "Password Is Valid" : throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.INVALID_PASSWORD, "Password Is Invalid");
    }
}
