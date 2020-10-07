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
        }
    }
}
