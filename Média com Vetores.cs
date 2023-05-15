using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_15._05___Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {//inicio
            
            string[] nomealuno = new string[5];
            double[] nota1 = new double[5];
            double[] nota2 = new double[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite seu nome: ");
                nomealuno[0] = Console.ReadLine();
                Console.Write("Digite sua primeira nota: ");
                nota1[0] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite sua segunda nota: ");
                nota2[0] = Convert.ToDouble(Console.ReadLine());
            double media = (nota1[0] + nota2[0]) / 2;
            Console.WriteLine("Senhor(a) " + nomealuno[0] + " sua nota é " + media);

            }

            Console.ReadKey();
        }//fim

    }
}
