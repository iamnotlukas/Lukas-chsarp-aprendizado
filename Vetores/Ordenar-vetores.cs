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

        //Faça um algoritmo para ler 15 números e armazenar
        //em um vetor VET, colocar o vetor em ordem crescente e decrescente.

        {//inicio
            int[] numeros = new int[15];
            for (int i = 0; i < numeros.Length; i++)
            {

                Console.Write("Digite os {0} número: ", i + 1);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(numeros);
            Console.WriteLine("Números em ordem crescente:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("----------------------- \n Números em ordem decrescente:");
            for (int c = numeros.Length - 1; c >= 0; c--)
            {
                Console.WriteLine(numeros[c]);
            }

            Console.ReadKey();
        }//fim


    }
}
}
