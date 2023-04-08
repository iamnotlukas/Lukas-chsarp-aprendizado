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
            string nome, nome_i;
            int posicao;
            inicio:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Digite seu nome completo: ");
            nome = Console.ReadLine();
            nome = nome.ToLower();
            posicao = nome.LastIndexOf(" ");
            nome_i = nome.Substring(posicao + 1);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("O Seu email institucional é: " + nome_i + "@fatec.sp.gov.br");

            

            Console.ReadKey();
            goto inicio;
        }//fim
    }
}
