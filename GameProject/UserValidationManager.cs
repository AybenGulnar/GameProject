using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthdayYear == 1985 && gamer.FirstName == "ayben" && gamer.LastName == "gulnar" && gamer.IdentityNumber == 12345)
            {
                return true;
            }
            else
                return false;
            
        }
    }
}
