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

            Console.WriteLine("========== Usando Validações do Extension Method na Classe String ===========");

            Console.WriteLine("\n\n======= Validação de CPF/CNPJ =========");
            MostrarValidacaoCPFCNPJ(cpfCnpjValid);
            MostrarValidacaoCPFCNPJ(cpfCnpjNotValid);
            Console.WriteLine("=========================================");

            Console.WriteLine("\n\n======= Validação de Email =========");
            var email = "joel@gmail.com";
            MostrarEmailVal(email);
            MostrarEmailVal("joel#gmail.com");
            Console.WriteLine("=========================================");

            Console.WriteLine("\n\n========== Usando Mascaras do Extension Method na Classe String ===========\n\n");
            ShowRemoveMask(cpfCnpjValid);

            var cpf = "00000000000";
            Console.WriteLine("\nCPF Sem Mascara: {0}", cpf);
            Console.WriteLine("\nCPF Com Mascara: {0}", cpf.CpfMask());

            var cnpj = "00000000000000";
            Console.WriteLine("\nCNPJ Sem Mascara: {0}", cnpj);
            Console.WriteLine("\nCNPJ Com Mascara: {0}", cnpj.CnpjMask());
            Console.WriteLine("\n===========================================================================");

            Console.ReadKey();
        }

        private static void MostrarEmailVal(string email)
        {
            Console.WriteLine(email.EmailIsValid() ? "Email Valido: {0}" : "Email Invalido: {0}", email);
        }

        public static void MostrarValidacaoCPFCNPJ(string cpfCnpj)
        {
            Console.WriteLine(cpfCnpj.CpfCnpjIsValid() ? "CPF/CNPJ Valido: {0}" : "CPF/CNPJ Invalido: {0}", cpfCnpj);
        }

        public static void ShowRemoveMask(string cpfCnpj)
        {
            Console.WriteLine("Sem Mascara: {0}", cpfCnpj.CpfCnpjRemoveMask());
        }
    }
}
