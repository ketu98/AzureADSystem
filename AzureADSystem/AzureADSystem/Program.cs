
using System;

namespace AzureADSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            AuthenticationService authService = new AuthenticationService();
            bool isAuthenticated = authService.AuthenticateUser("username", "password");

            Console.WriteLine(isAuthenticated ? "User authenticated" : "Authentication failed");
        }
    }
}
