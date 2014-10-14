using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using StringValidationExtensions;
using StringValidationExtensions.Mask;
using StringValidationExtensions.Validations;

namespace HowToUse
{
    class Program
    {
        static void Main(string[] args)
        {
            var cpfCnpjValid = "999.999.999.99";

            var cpfCnpjNotValid = "086+733/478*88";

            Console.WriteLine("========== Validation Example ===========");
            ShowValidationCpfCnpj(cpfCnpjValid);
            ShowValidationCpfCnpj(cpfCnpjNotValid);
            Console.WriteLine("=========================================");

            Console.WriteLine("\n\n==========    Mask Example    ===========\n\n");
            ShowRemoveMask(cpfCnpjValid);
          
            var cpf = "00000000000";
            Console.WriteLine("\nPut mask on this:{0}", cpf);
            Console.WriteLine("\nWith Mask: {0}", cpf.CpfMask());

            var cnpj = "00000000000000";
            Console.WriteLine("\nPut mask on this:{0}", cnpj);
            Console.WriteLine("\nWith Mask: {0}", cnpj.CnpjMask());
            Console.WriteLine("=========================================");



            Console.ReadKey();
        }

        public static void ShowValidationCpfCnpj(string cpfCnpj)
        {
            Console.WriteLine(cpfCnpj.CpfCnpjIsValid() ? "Is valid: {0}" : "Isn't valid: {0}", cpfCnpj);
        }

        public static void ShowRemoveMask(string cpfCnpj)
        {
            Console.WriteLine("Without Mask: {0}", cpfCnpj.CpfCnpjRemoveMask());
        }
    }
}
