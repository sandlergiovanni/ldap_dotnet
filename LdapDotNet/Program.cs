using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiRfc.Security;

namespace LdapDotNet
{
    public static class Program
    {
        private static string Usuario { get; set; }
        private static string Senha { get; set; }
             
        static void Main(string[] args)
        {
            Console.WriteLine("informe o seu nome | matricula e senha utilizado no AD");

            Console.Write("Usuário: ");
            Usuario = Convert.ToString(Console.ReadLine());
            Console.Write("Senha: ");
            Senha = Convert.ToString(Console.ReadLine());

            var retorno = SystemLdap.createDirectoryEntry(Usuario, Senha);

            Console.WriteLine(retorno);

            Console.ReadKey();
        }
    }
}
