using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Validate validate = new Validate();

            Console.WriteLine("Welcome To User Registration Program");
            FirstName:
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            if (validate.ValidateFirstName(firstName) == false)
            {
                goto FirstName;
            }
            LastName:
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            if(validate.ValidateLastName(lastName) == false){
                goto LastName;
            }
            EMail:
            Console.WriteLine("Enter Email");
            string eMail = Console.ReadLine();
            if (validate.ValidateEmail(eMail) == false)
            {
                goto EMail;
            }
            PhoneNo:
            Console.WriteLine("Enter Phone No");
            string phoneNo = Console.ReadLine();
            if (validate.ValidatePhoneNo(phoneNo) == false)
            {
                goto PhoneNo;
            }
            Password:
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            if (validate.ValidatePassword(password) == false)
            {
                goto Password;

            }
        }
    }
}
