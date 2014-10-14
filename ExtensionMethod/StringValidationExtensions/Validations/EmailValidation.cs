using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringValidationExtensions.Validations
{
    public static class EmailValidation
    {

        public static bool EmailIsValid(this string email)
        {
            return Regex.IsMatch(email, @"[\w\.-]+(\+[\w-]*)?@([\w-]+\.)+[\w-]+");
        }
    }
}
