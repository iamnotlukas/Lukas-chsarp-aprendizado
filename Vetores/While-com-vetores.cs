using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_Prática
{
    internal class Program
    {
        static void Main(string[] args)
        //Escreva um algoritmo que permita a leitura dos nomes de 10 pessoa
        //e armazene os nomes lidos em um vetor. Após isto, o algoritmo
        //deve permitir a leitura de mais 1 nome qualquer de pessoa e depois
        //escrever a mensagem ACHEI, se o nome estiver entre os 10 nomes
        //lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário. 

        {//inicio
            string[] nomes = new string[10];
            Console.Write("Digite os 10 nomes: ");
            for (int i = 0; i < nomes.Length; i++)
            {
                nomes[i] = Console.ReadLine();
                Console.WriteLine("Nome: " + nomes[i] + " guardado.");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nomes guardados com sucesso!");
            Console.WriteLine("----------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("BUSCADOR DE NOMES");
            Console.Write("Informe um nome: ");
            string digitado = Console.ReadLine();
            while (digitado != nomes[0])
            {
                Console.WriteLine("Errou! Não é esse nome");
                digitado = Console.ReadLine();

            }

            Console.WriteLine("Parabéns! Você acertou um nome do vetor");
            Console.ReadKey();


        }//fim



    }
}
}
