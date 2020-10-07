using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Validate validate = new Validate();

            Console.WriteLine("Welcome To User Registration Program");
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            validate.ValidateFirstName(firstName);

            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            validate.ValidateLastName(lastName);

            Console.WriteLine("Enter Email");
            string eMail = Console.ReadLine();
            validate.ValidateEmail(eMail);

            Console.WriteLine("Enter Phone No");
            string phoneNo = Console.ReadLine();
            validate.ValidatePhoneNo(phoneNo);

            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            validate.ValidatePassword(password);
        }
    }
}
