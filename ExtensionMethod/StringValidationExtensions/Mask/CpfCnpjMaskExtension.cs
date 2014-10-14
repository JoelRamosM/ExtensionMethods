using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using StringValidationExtensions.Validations;

namespace StringValidationExtensions.Mask
{
    public static class CpfCnpjMaskExtension
    {
        public static string CnpjMask(this string cnpj)
        {
            if (cnpj.Length == 14 && cnpj.CpfCnpjIsValid())
            {
                cnpj = string.Format(@"{0:00\.000\.000\/0000\-00}", long.Parse(cnpj));
            }
            return cnpj;
        }
        public static string CpfMask(this string cpf)
        {
            if (cpf.Length == 11 && cpf.CpfCnpjIsValid())
            {
                cpf = string.Format(@"{0:000\.000\.000\-00}", long.Parse(cpf));
            }
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
