namespace AutomationPractice.RegistrationUserModel
{
    public class RegistrationUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

      
        public string Email { get; set; }

        public string Password { get; set; }

       public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostCode { get; set; }

        public string ErrorMessage { get; set; }

        public string Phone { get; set; }

   


        public void SkipFirstName()
        {
            FirstName = string.Empty;
            ErrorMessage = "firstname is required.";
        }


        public void SkipLastName()
        {
            LastName = string.Empty;
            ErrorMessage = "lastname is required.";
        }

        public void SkipPassword()
        {
            Password = string.Empty;
            ErrorMessage = "passwd is required.";
        }

       

        public void SkipAddress()
        {
            Address = string.Empty;
            ErrorMessage = "address1 is required";
        }

        public void SkipCity()
        {
            City = string.Empty;
            ErrorMessage = "city is required.";
        }

    }
}
