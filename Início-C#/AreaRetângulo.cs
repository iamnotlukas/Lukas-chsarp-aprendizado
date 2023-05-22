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
        //6)Escreva um programa para ler as dimensões de um retângulo (base e altura), calcular e escrever a área do retângulo.
        {//inicio
        inicio:
            Console.Clear();
            double altura, bas, area;
            Console.Write("Digite a altura do retângulo: ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a base do retângulo: ");
            bas =  Convert.ToDouble(Console.ReadLine());
            area = bas * altura;
            Console.WriteLine("A área do seu retângulo é: " + Math.Round(area,3));




            Console.ReadKey();
            goto inicio;
        }//fim
    }
}
