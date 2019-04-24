using System;

namespace _05_UtilizandoCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Utilizando pontos flutuantes. Tipos numéricos Double.");

            //Utilizando a variavel do tipo double
            double salario; // atribuição separada
            salario = 1700.25;

            Console.WriteLine("Salário inicial: " + salario + ".");

            double bonificacaoMensal = 0.05;

            Console.WriteLine("Salário no 2º mês:" + (salario += salario * bonificacaoMensal));

            Console.WriteLine("Salário no 3º mês:" + (salario += salario * bonificacaoMensal));

            Console.WriteLine("Salário no 4º mês:" + (salario += salario * bonificacaoMensal));

            Console.WriteLine("Salário no 5º mês:" + (salario += salario * bonificacaoMensal));

            Console.WriteLine("Salário no 6º mês:" + (salario += salario * bonificacaoMensal));

            int salarioInteiros;

            /*Para a realização de um cast, adota-se a estrutura
             * variavel = (tipoDaVarQueRecebe) variavelOrigem;
             */
            salarioInteiros = (int)salario;

            Console.WriteLine("O valor do salário em inteiros é " + salarioInteiros + ".");

            Console.WriteLine("A execução do programa acabou... Pressione a tecla Enter.");
            Console.ReadLine();
        }
    }
}
