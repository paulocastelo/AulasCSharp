using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_EncadeandoLacosFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://cursos.alura.com.br/course/csharp-parte-1-primeiros-passos/task/37986

            Console.WriteLine("Executando o testes de Laços do tipo FOR encadeados:");
            Console.WriteLine("Digite o valor que deseja investir:");
            double valorInvestido = Convert.ToDouble(Console.ReadLine());
            double novoValorInvestido = valorInvestido;
            double fatorRendimento = 1.0036;
            Console.WriteLine("Digite a quantidade de anos para a projeção dos rendimentos:");
            int qtdeAno = Convert.ToInt32(Console.ReadLine());

            double novoFatorRendimento = fatorRendimento;


            for (int contaAno = 1; contaAno <= qtdeAno; contaAno++)
            {
                //Console.WriteLine("Valor incial do contador de ano é " + contadorAno);
                for (int contadorMes = 1; contadorMes <12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }
            Console.WriteLine("Ao término do investimento, você terá R$ " + valorInvestido);

            Console.WriteLine("Procedimento utilizando a estrutura while");

            int contadorAno = 1;
            while (contadorAno <= qtdeAno)
            {
                for (int contador = 1; contador <12; contador++)
                {
                    novoValorInvestido *= novoFatorRendimento;
                }
                novoFatorRendimento += 0.0010;
                contadorAno++;
            }

            Console.WriteLine("Ao término do investimento, você terá R$ " + novoValorInvestido);

            Console.ReadLine();
        }
    }
}
