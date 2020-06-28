

using NUnit.Framework;


namespace AutomationPractice.Page
{
   public partial class RegistrationForm
    {


        public void AssertPageTitle(string expectedTitle)
        {
            Assert.AreEqual(expectedTitle, PageTitle.Text.ToLower());
        }

        
        public void AssertFirstNameIsRequired()
        {

           string text =  ActualMessenger.Text;

            string expectedMsg = "There is 1 error\r\nfirstname is required.";

            Assert.AreEqual(text, expectedMsg);
        }

        public void AssertLastNameIsRequired()
        {

            string text = ActualMessenger.Text;

            string expectedMsg = "There is 1 error\r\nlastname is required.";

            Assert.AreEqual(text, expectedMsg);
        }

        public void AssertPasswordIsRequired()
        {

            string text = ActualMessenger.Text;

            string expectedMsg = "There is 1 error\r\npasswd is required.";

            Assert.AreEqual(text, expectedMsg);
        }
        public void AssertCityIsRequired()
        {

            string text = ActualMessenger.Text;

            string expectedMsg = "There is 1 error\r\ncity is required.";

            Assert.AreEqual(text, expectedMsg);
        }

        public void AssertAddressIsRequired()
        {

            string text = ActualMessenger.Text;

            string expectedMsg = "There is 1 error\r\naddress1 is required.";

            Assert.AreEqual(text, expectedMsg);
        }
    }
}
