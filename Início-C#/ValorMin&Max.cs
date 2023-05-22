using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Atividade_for_while
{
    internal class Program
    {
        static void Main(string[] args)
        //Criar um programa que permita o usuário entrar com vinte números,
        //após o termino da digitação,
        //mostrar na tela qual o maior e menor numero que o usuário digitou.

        {//inicio

            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 1; i <= 5; i++)
            {
            
                Console.WriteLine("Digite o " + i + "° número: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }

                if (num < min)
                {
                    min = num;
                }

            }
            Console.WriteLine("O maior número digitado foi: " + max);
            Console.WriteLine("O menor número digitado foi: " + min);

            Console.ReadKey();
        }//fim
    }
}
