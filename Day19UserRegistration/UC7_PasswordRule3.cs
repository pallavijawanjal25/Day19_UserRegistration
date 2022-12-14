using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19UserRegistration
{
    class UC7_PasswordRule3
    {
        // A password should have at least one numeric character
        public static string Regex_Password = "(?=.*[0-9])(?=.[A-Za-z]{7,})";

        public bool validatePassword(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }
    }
}