using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19UserRegistration
{
    class UC6_PasswordRule2
    {
        // A password should have at least one uppercase character
        public static string Regex_Password = "(?=.*[A-Z])(?=.[0-9a-z]{7,})";

        public bool validatePassword(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }
    }
}
