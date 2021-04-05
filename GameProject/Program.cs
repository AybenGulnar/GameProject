using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { id = 1, BirthdayYear = 1985, FirstName = "ayben", LastName = "gulnar", IdentityNumber = 12345 });



            
        }
    }
}
