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
        //3 - Faça um programa para ler: a descrição do produto(nome), a quantidade adquirida e o preço unitário.Calcular e escrever o total(total = quantidade adquirida* preço unitário), o desconto e o total a pagar(total a pagar = total - desconto), sabendo-se que:
        //- Se quantidade <= 5 o desconto será de 2%
        //- Se quantidade > 5 e quantidade <=10 o desconto será de 3%
        //- Se quantidade > 10 o desconto será de 5%
        {//inicio
        inicio:
            string nome;
            double qnt, des, preço, total, total_d;
            Console.Write("Digite o nome do produto: ");
            nome = Console.ReadLine();
            Console.Write("Digite o preço do produto: ");
            preço = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a quantidade adquirida: ");
            qnt = Convert.ToDouble(Console.ReadLine());

            if (qnt <= 5)
            {
               
                Console.WriteLine("Seu desconto é de 2%");
                total = preço * qnt;
                Console.WriteLine("Total a pagar sem desconto: " + total);
                total_d = total * 0.02;

                Console.WriteLine("total do valor do " + nome + " com desconto: " + total_d);
            }

            else if (qnt > 5 && qnt <=10)
            {
                Console.WriteLine("Seu desconto é de 3%");
                total = preço * qnt;
                Console.WriteLine("Total a pagar sem desconto: " + total);
                total_d = total * 0.03;
                Console.WriteLine("total do valor do "+ nome+" com desconto: " + total_d);

            }
            else if (qnt > 10)
            {
                Console.WriteLine("Seu desconto é de 5%");
                total = preço * qnt;
                Console.WriteLine("Total a pagar sem desconto: " + total);
                total_d = total * 0.05;
                Console.WriteLine("total do valor do " + nome + " com desconto: " + total_d);
            }

            Console.ReadKey();
            goto inicio;
        }//fim
    }
}
