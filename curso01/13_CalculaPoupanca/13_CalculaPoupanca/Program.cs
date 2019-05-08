using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        //https://cursos.alura.com.br/course/csharp-parte-1-primeiros-passos/task/37984
        {
            Console.WriteLine("Executando o calculo de poupanca sem laço:");
            Console.WriteLine("Digite o valor investido:");
            int mes = 0;
            double valorInvestido = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O valor investido foi: " + valorInvestido + ".");

            mes++;
            valorInvestido = valorInvestido + valorInvestido * 0.0036;
            Console.WriteLine("O valor ao final do mês "+ mes +" é " + valorInvestido + ".");

            mes++;
            valorInvestido = valorInvestido + valorInvestido * 0.0036;
            Console.WriteLine("O valor ao final do mês " + mes + " é " + valorInvestido + ".");

            mes++;
            valorInvestido = valorInvestido + valorInvestido * 0.0036;
            Console.WriteLine("O valor ao final do mês " + mes + " é " + valorInvestido + ".");

            Console.WriteLine("Executando o cálculo da poupança utilizando o WHILE:");
            Console.WriteLine("Digite um novo valor investido: ");
            valorInvestido = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de meses na poupança:");
            mes = Convert.ToInt32(Console.ReadLine());

            int contadorMes = 1;
            while (contadorMes <= mes)
            {
                //valorInvestido = valorInvestido + valorInvestido * 0.036;
                //Forma mais simples
                valorInvestido *= 1.0036;
                Console.WriteLine("O valor ao final do mês " + contadorMes + " é " + valorInvestido + ".");
                contadorMes++;
            }

            Console.WriteLine("Executando o cálculo da poupança utilizando o FOR:");
            Console.WriteLine("Digite um novo valor investido: ");
            valorInvestido = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de meses na poupança:");
            mes = Convert.ToInt32(Console.ReadLine());

            for (int Contador = 1; Contador <= mes; Contador++)
            {
                //valorInvestido = valorInvestido + valorInvestido * 0.036;
                //Forma mais simples
                valorInvestido *= 1.0036;
                Console.WriteLine("O valor ao final do mês " + Contador + " é " + valorInvestido + ".");
            }

            Console.WriteLine("O programa concluiu sua execução... Pressione a tecla ENTER");
            Console.ReadLine();
        }
    }
}
