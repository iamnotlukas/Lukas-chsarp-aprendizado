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

        //Elabore um programa que permita a digitação de 3 vetores
        //com 5 posições, um contendo o nome, o segundo contendo
        //a primeira nota e o terceiro contendo a segunda nota.
        //Logo após as entradas mostrar na tela o nome, as notas
        //e a média aritmética destas duas notas.


        {//inicio

            string[] nome = new string[5];
            int[] nota1 = new int[5];
            int[] nota2 = new int[5];
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("INFORME DOS DADOS");
            Console.ForegroundColor= ConsoleColor.White;
            for (int i = 0; i < nome.Length; i++)
            {
                Console.Write("Digite o nome do aluno {0}: ", i + 1);
                nome[i] = Console.ReadLine();
                Console.WriteLine("Informe a primeira nota do aluno {0}: ", i + 1);
                nota1[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe a segunda nota do aluno {0}: ", i + 1);
                nota2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Calculando a média...");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 5; i++)
            {
                double media = (nota1[i] + nota2[i]) / 2;
                Console.WriteLine("Aluno: {0} \nmédia: {1}", nome[i], media);
            }
                Console.ReadKey();

        }//fim
        
        
    }
}
