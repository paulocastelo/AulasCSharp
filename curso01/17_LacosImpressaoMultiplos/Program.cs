using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_LacosImpressaoMultiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://cursos.alura.com.br/course/csharp-parte-1-primeiros-passos/task/38064
            Console.WriteLine("Execução de impressão de múltiplos de um número:");
            Console.WriteLine("Os números estarão entre 1 e ");
            int limite = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Os números são múltiplos de ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            for (int contador = 0; contador <= limite; contador++)
            {
                if (contador % divisor == 0)
                {
                    Console.WriteLine("O número " + contador + " é divisível por " + divisor + ".");
                }
            }
            Console.WriteLine("O sistema finalizou a execução. Pressione uma tecla. . .");
            Console.ReadLine();
        }
    }
}
