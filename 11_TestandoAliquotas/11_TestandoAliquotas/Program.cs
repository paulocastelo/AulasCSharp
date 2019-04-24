using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_TestandoAliquotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do salário: ");
            string entrada = Console.ReadLine();
            double salario = Convert.ToDouble(entrada);

            if (salario < 1900.0)
            {
                Console.WriteLine("Você não precisa fazer declaração de IR.");
            }
            else if(salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("Sua alíquota é de 7.5% e pode deduzir na declaração o valor de R$ 142.");
            }
            else if(salario >= 2800.1 && salario <= 3751.0)
            {
                Console.WriteLine("IR é de 15 % e pode deduzir R$ 350.");
            }
            else
            {
                Console.WriteLine("IR é de 22.5 % e pode deduzir R$ 636.");
            }
            Console.WriteLine("O programa acabou sua execução... Pressione ENTER.");
            Console.Read();
        }
    }
}
