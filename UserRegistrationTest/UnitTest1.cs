using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using UserRegistration;
namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void ValidateFirstName_Should_Return_FirstNameIsValid()
        {
            Validate validate = new Validate();
            string firstName = "Abcdef";

           string result = validate.ValidateFirstName(firstName);

            Assert.AreEqual("First Name Is Valid", result);
        }

        [TestMethod]
        [DataRow("abcdef")]
        [DataRow("ab")]
        [DataRow("")]
        public void ValidateFirstName_Should_Return_FirstNameIsInvalid(string firstName)
        {
            Validate validate = new Validate();
            try
            {
                validate.ValidateFirstName(firstName);
            }
            catch(UserRegistrationCustomException e)
            {
                Assert.AreEqual("First Name Is Invalid", e.Message);
            }
        }

        [TestMethod]
        [DataRow("abc@gmail.com")]
        [DataRow("abc@gmail.co.in")]
        [DataRow("abc.xyz@gmail.com")]
        [DataRow("abc.xyz.pqr@gmail.com")]
        public void ValidateEmail_Should_Return_EmailIdIsValid(string email)
        {
            Validate validate = new Validate();

            string result = validate.ValidateEmail(email);

            Assert.AreEqual("Email Id Is Valid", result);
        }

        [TestMethod]
        [DataRow("abc@gmail.co.in.au")]
        [DataRow("abc@.com")]
        [DataRow("abcgmail.com")]
        [DataRow(".abc@gmail.com")]
        public void ValidateEmail_Should_Return_EmailIdIsInvalid(string eMail)
        {
            try
            {
                Validate validate = new Validate();

                string result = validate.ValidateEmail(eMail);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Email Id Is Invalid", e.Message);
            }
        }

        [TestMethod]
        public void ValidatePhoneNo_Should_Return_PhoneNoIsValid()
        {
            Validate validate = new Validate();
            string phoneNo = "98 9823456790";
            string result = validate.ValidatePhoneNo(phoneNo);

            Assert.AreEqual("Phone No Is Valid", result);
        }

        [TestMethod]
        [DataRow("12 0876765432")]
        [DataRow("769876342135")]
        [DataRow("12 587676547")]
        public void ValidatePhoneNo_Should_Return_PhoneNoIsInvalid(string phoneNo)
        {
            try
            {
                Validate validate = new Validate();

                string result = validate.ValidatePhoneNo(phoneNo);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Phone No Is Invalid", e.Message);
            }
        }
        [TestMethod]
        public void ValidatePassword_Should_Return_PasswordIsValid()
        {
            Validate validate = new Validate();
            string password = "abcAB12@ab";

            string result = validate.ValidatePassword(password);

            Assert.AreEqual("Password Is Valid", result);
        }

        [TestMethod]
        [DataRow("abc")]
        [DataRow("abcdefgh")]
        [DataRow("ABCab@abc")]
        [DataRow("abc123ABC")]
        [DataRow("abc@ABC12#")]
        public void ValidatePassword_Should_Return_expectedResult(string password)
        {
            try
            {
                Validate validate = new Validate();

                string result = validate.ValidatePassword(password);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Password Is Invalid",e.Message);
            }
        }
    }
}
