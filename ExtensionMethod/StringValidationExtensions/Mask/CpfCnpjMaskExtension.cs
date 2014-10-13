using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringValidationExtensions.Mask
{
    public static class CpfCnpjMaskExtension
    {
        public static void CnpjMask(this string cnpj)
        {

        }
        public static string CpfMask(this string cpf)
        {
            cpf = cpf.Insert(3, ".");
            cpf = cpf.Insert(7, ".");
            cpf = cpf.Insert(11, "-");

            return cpf;
        }

        public static string CpfCnpjRemoveMask(this string cpfCnpj)
        {
            const string regEx = @"[?.| / | -]";
            cpfCnpj = Regex.Replace(cpfCnpj, regEx, "");
            return cpfCnpj;

        }
    }
}
