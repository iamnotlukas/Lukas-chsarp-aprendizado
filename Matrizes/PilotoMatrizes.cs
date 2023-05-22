using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lukas_e_Daniel_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {//inicio
            string[,] matriz = new string[5, 2];
            for(int l=0;l < 5; l++)
            {
                Console.Write("Digite o nome do piloto: ");
                matriz[l,0] = Console.ReadLine();
                Console.Write("Digite a posição do piloto " +matriz[l,0]+ ": ");
                matriz[l,1] = Console.ReadLine();

            }
            Console.WriteLine("Mostrar os valore...");
            Console.ReadKey();

            for(int l = 0; l < 5; l++)
            {
                Console.WriteLine("Piloto, "+  matriz[l,0]+", vai largar em "+ matriz[l,1]);

            }

            Console.ReadKey();
        }//fim

    }
}
