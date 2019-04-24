using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_TestandoMaisCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando mais condicionais.");
            Console.WriteLine("https://cursos.alura.com.br/course/csharp-parte-1-primeiros-passos/task/38071");

            int idade = 16;
            int qtdePessoas = 3;
            bool acompanhado = qtdePessoas >= 2;

            Console.WriteLine("Situação 01: Utilizando ||");
            if (idade >= 18 || qtdePessoas >= 2)
            {
                Console.WriteLine("Seja bem-vindo!");
            }
            else
            {
                Console.WriteLine("Você não pode entrar!");
            }

            Console.WriteLine("Situação 02: Utilizando &&");

            if(idade >= 18 && qtdePessoas >= 2)
            {
                Console.WriteLine("Seja bem-vindo!");
            }
            else
            {
                Console.WriteLine("Você não pode entrar.");
            }

            Console.WriteLine("Situação 03: Utilizando variável booleana");
            if(idade >= 18 && acompanhado == true)
            {
                Console.WriteLine("Seja bem-vindo");
            }
            else
            {
                Console.WriteLine("Você não pode entrar.");
            }

            Console.WriteLine("O programa acabou a execução... Pressione a tecla ENTER.");
            Console.ReadLine();
        }
    }
}
