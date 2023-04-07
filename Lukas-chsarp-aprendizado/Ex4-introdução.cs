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
        //4.  Elaborar um programa e fluxograma para calcular a média aritmética de três  números digitados pelo usuário.
        {//inicio
            inicio:
            Console.Clear();
            double n1, n2, n3, media;
            Console.ForegroundColor = ConsoleColor.Green;   
            Console.WriteLine("Digite o numero 1: ");
            Console.ForegroundColor= ConsoleColor.Blue;
            n1=Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite o segudo número: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            n2=Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite o terceiro número: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            n3 =Convert.ToDouble(Console.ReadLine());
            media = (n1 + n2 + n3) / 3;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("A média dos seus número é: "+ media);
            Console.ReadKey();
            goto inicio;
        }//fim
    }
}
