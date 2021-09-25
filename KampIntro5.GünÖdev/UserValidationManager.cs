using System;
using System.Collections.Generic;
using System.Text;

namespace KampIntro5.GünÖdev
{
    class UserValidationManager : IUserValidationService
    {
        public bool validate(Gamer gamer)
        {
            if (gamer.BirthYear==1985 && gamer.FirstName=="engin" && gamer.Lastname=="demiroğ"&&
                gamer.IdentityNumber==12345 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
