using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_for_while
{
    internal class Program
    {
        static void Main(string[] args)
        //Crie um programa e fluxograma que permita o usuário digitar um numero qualquer. Imprimir na tela a tabuada deste numero.
        {//inicio
            int r, i;
             Console.WriteLine("Digite o número para ver sua tabuada: ");
             int num = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i<=10 ; i++)
            {
                r = num * i;
                Console.WriteLine(num + " x " + i +" = " + r);
          

            }
            Console.ReadKey();
        }//fim
    }
}
