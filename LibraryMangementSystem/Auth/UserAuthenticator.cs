using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementSystem.Auth
{
    public class UserAuthenticator
    {

        private UserAuthenticator() { }

        public static bool IsAdmin(string token)
        {
            return true;
        }

        public static bool IsMember(string token)
        {
            return true;
        }
    }
}
