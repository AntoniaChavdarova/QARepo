

using NUnit.Framework;


namespace AutomationPractice.Page
{
   public partial class RegistrationForm
    {


        public void AssertPageTitle(string expectedTitle)
        {
            Assert.AreEqual(expectedTitle, PageTitle.Text.ToLower());
        }

        public void MessageWithMissingValue(string Message)
        {

            Assert.IsTrue(this.ActualMessage.Text.Contains(Message), "The results DIV doesn't contains the specified text.");
        }

       
    }
}
