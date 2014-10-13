using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringValidationExtensions
{
    public static class CpfCnpjValidation
    {

        public static bool CpfCnpjIsValid(this string cpfCnpj)
        {
            if (!string.IsNullOrWhiteSpace(cpfCnpj) && Regex.IsMatch(cpfCnpj, @"^[0-9\.\-\/]+$"))
            {
                var strWithOutMask = Regex.Replace(cpfCnpj, @"[\.\-\/]", "");
                return strWithOutMask.Length == 11 || strWithOutMask.Length == 14;
            }
            return false;
        }
    }
}
