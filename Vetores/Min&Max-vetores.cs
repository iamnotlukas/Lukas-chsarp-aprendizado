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

        //  Ler um vetor Q de 20 posições(aceitar somente números positivos).
        //  Escrever a seguir o valor do maior elemento de Q e a
        //  respectiva posição que ele ocupa no vetor.

        {//inicio
            int[] q = new int[20];
            int max = q[0];
            int maiorValor = int.MinValue;
            int posicaoMaiorValor = -1;

            for (int i = 0; i < q.Length; i++)
            {
                do  //não sabia nem usar do-while, aprendi na marra
                {
                    Console.Write("Digite um número positivo para a posição {0}: ", i + 1);
                    q[i] = Convert.ToInt32(Console.ReadLine());
                } while (q[i] <= 0);

                if (q[i] > maiorValor)
                {
                    maiorValor = q[i];
                    posicaoMaiorValor = i;
                }
            }

            Console.WriteLine("O maior elemento do vetor é: " + maiorValor);
            Console.WriteLine("posição: " + posicaoMaiorValor);


            Console.ReadKey();

        }//fim

    }
    }
}
