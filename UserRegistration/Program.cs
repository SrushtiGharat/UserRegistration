using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Validate validate = new Validate();
            string result;
            Console.WriteLine("Welcome To User Registration Program");
        FirstName:
            try
            {
                Console.WriteLine("Enter First Name");
                string firstName = Console.ReadLine();
                result = validate.ValidateFirstName(firstName);
            }
            catch (UserRegistrationCustomException e)
            {
                Console.WriteLine(e.Message);
                goto FirstName;
            }
        LastName:
            try
            {
                Console.WriteLine("Enter Last Name");
                string lastName = Console.ReadLine();
                result = validate.ValidateLastName(lastName);
            }
            catch (UserRegistrationCustomException e)
            {
                Console.WriteLine(e.Message);
                goto LastName;
            }

        EMail:
            try
            {
                Console.WriteLine("Enter Email");
                string eMail = Console.ReadLine();
                result = validate.ValidateEmail(eMail);
            }
            catch (UserRegistrationCustomException e)
            {
                Console.WriteLine(e.Message);
                goto EMail;
            }

        PhoneNo:
            try
            {
                Console.WriteLine("Enter Phone No");
                string phoneNo = Console.ReadLine();
                result = validate.ValidatePhoneNo(phoneNo);
            }
            catch(UserRegistrationCustomException e)
            {
                Console.WriteLine(e.Message);
                goto PhoneNo;
            }
        Password:
            try
            {
                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();
                result = validate.ValidatePassword(password);
            }
            catch(UserRegistrationCustomException e)
            {
                Console.WriteLine(e.Message);
                goto Password;

            }
        }
    }
}
