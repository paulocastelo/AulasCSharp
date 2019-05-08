using System;

namespace _07_ConcidionaisNoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Utilizando condicionais no salário.");

            double salario = 3300.0;

            if(salario > 0 && salario <= 2600.0)
            {
                Console.WriteLine("Sua alíquota de imposto de renda é 15%");
                Console.WriteLine("Você pode deduzir até R$ 350,00");
            }
            
            if(salario > 2600 && salario < 3750.0)
            {
                Console.WriteLine("A sua aliquota é de 22,5%");
                Console.WriteLine("Você pode deduzir até R$ 636,00");
            }
        }
    }
}
