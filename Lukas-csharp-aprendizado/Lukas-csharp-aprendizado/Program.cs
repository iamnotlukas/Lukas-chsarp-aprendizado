using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lukas_csharp_aprendizado
{
    internal class Program
    {
        static void Main(string[] args)
        //Crie um gerador de e-mail que solicite o nome do usuário completo e mostre a o final o email:nome@fatec.sp.gov.br  
        {//inicio
            Console.Clear();
            inicio:
            string nome, nome_i, sobrenome_i;
            int posicao, posicao2;
            Console.WriteLine("Digite seu nome completo: ");
            nome = Console.ReadLine();
            nome = nome.ToLower();
            posicao = nome.IndexOf(" ");
            posicao2 = nome.LastIndexOf(" ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            nome_i = nome.Substring(0,posicao);
            sobrenome_i = nome.Substring(posicao2 + 1);
            Console.WriteLine("Seu email institucional é: " + nome_i + "." + sobrenome_i + "@fatec.sp.gov.br");
           
            Console.ReadKey();
            goto inicio;
        }//fim
    }
}
