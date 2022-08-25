using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19UserRegistration
{
    class UC5_PasswordRule1
    {
        // A password should have minimum 8 characters 
        public static string Regex_Password = "^[a-zA-z0-9]{8,16}$";

        public bool validatePassword(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }
    }
}
