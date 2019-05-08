using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_LacosDeRepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://cursos.alura.com.br/course/csharp-parte-1-primeiros-passos/task/38063
            Console.WriteLine("Até que número da tabuada deseja imprimir?");
            int limite = Convert.ToInt32(Console.ReadLine());
            for (int multiplicador = 1; multiplicador <= limite; multiplicador++)
            {
                for (int contador = 1; contador <= 10; contador++)
                {
                    Console.WriteLine(multiplicador + " * " + contador + " = " + multiplicador * contador);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
