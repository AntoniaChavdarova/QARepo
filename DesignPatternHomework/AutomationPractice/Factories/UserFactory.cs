using AutoFixture;
using AutomationPractice.RegistrationUserModel;



namespace AutomationPractice.Factories
{
    public static class UserFactory
    {
        public static RegistrationUser CreateValidUser()
        {
            var fixture = new Fixture();
          
            

            return new RegistrationUser
            {
                
                FirstName = "kokoko",
                LastName = "lololo",
                Email = fixture.Create<string>() + "@gmail.com",
                State =  "Arizona",
                Password = fixture.Create<string>().Substring(5, 20),
                City = fixture.Create<string>().Substring(5, 20),
                Address = "77 Gerry Street",
                Phone = "989898",
                PostCode = "99999",
                

               
                
                

               


            };
        }

     
        }
    }

