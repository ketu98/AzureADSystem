
namespace AzureADSystem.Services
{
    public class AuthenticationService
    {
        public bool AuthenticateUser(string username, string password)
        {
            // Simplified authentication logic
            return username == "username" && password == "password";
        }
    }
}
