using System;

namespace _06_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Utilizando condicionais.");

            int idadeJoao = 16;
            int qtdePessoas = 3;
            if (idadeJoao > 18)
            {
                Console.WriteLine("O João pode entrar porque tem mais de 18 anos.");
            }
            else
            {
                Console.WriteLine("O João não pode entrar, pois é menor de idade.");
            }

            Console.WriteLine("Utilizando uma outra estrutura de IF:");

            if(idadeJoao < 18)
            {
                Console.WriteLine("Você não pode entrar, pois é menor de idade.");
            }
            else
            {
                Console.WriteLine("Você pode entrar.");
            }
            
            if(idadeJoao >= 18)
            {
                if(qtdePessoas > 1)
                {
                    Console.WriteLine("Você é maior de idade e está acompanhado. Pode entrar");
                }
                else
                {
                    Console.WriteLine("Você não está acompanhado. Não pode entrar");
                }
            }
            else
            {
                Console.WriteLine("Você é menor de idade. Não pode entrar.");
            }

            Console.WriteLine("O programa acabou de ser executado. Pressione a tecla Enter.");
            Console.ReadLine();
        }
    }
}
