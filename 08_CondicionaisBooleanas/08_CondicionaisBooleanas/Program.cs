using System;

namespace _08_CondicionaisBooleanas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Utilizando variaveis Booleanas em condicionais.");

            int idadePessoa = 18;
            int qtdePessoas = 3;
            bool acompanhado = qtdePessoas >= 2;

            if(idadePessoa >= 18 && acompanhado == true)
            {
                Console.WriteLine("Poder entrar.");
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
            }

            Console.WriteLine("O programa acabou a execução... Pressione a tecla ENTER.");
            Console.ReadLine();
        }
    }
}
