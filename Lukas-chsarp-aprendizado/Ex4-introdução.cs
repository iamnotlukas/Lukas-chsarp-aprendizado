using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lukas_chsarp_aprendizado
{
    internal class Program
    {
        static void Main(string[] args)
        //5) Escreva um código para ler um valor (do teclado) e escrever (na tela) o seu antecessor.
        {//inicio
        inicio:
            Console.Clear();
            double n1, n1_n;
            Console.WriteLine("Digite seu número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            n1_n = n1 - 1;
            Console.WriteLine("O antecessor do seu número é: " + n1_n);



            Console.ReadKey();
            goto inicio;
        }//fim
    }
}
