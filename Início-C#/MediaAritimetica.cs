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
            Console.WriteLine("Digite o numero 1: ");
            n1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segudo número: ");
            n2=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            n3=Convert.ToDouble(Console.ReadLine());
            media = (n1 + n2 + n3) / 3;
            Console.Write("A média dos seus número é: "+ media);
            Console.ReadKey();
            goto inicio;
        }//fim
    }
}
