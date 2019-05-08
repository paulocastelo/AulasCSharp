using System;

namespace _03_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando projetos com a utilização de variáveis!");

            //Definindo Variáveis
            int idade;
            idade = 23;

            Console.WriteLine("Sua idade é " + idade + ".");

            idade = idade + 25;

            Console.WriteLine("Sua idade daqui a 25 anos será " + idade + ".");

            Console.WriteLine("Utilizando símbolos aritméticos:");

            idade = 10 + 5 * 3;
            Console.WriteLine("idade = 10 + 5 * 3 --> " + idade + ".");

            idade = 10 + (5 * 3);
            Console.WriteLine("idade = 10 + (5 * 3) --> " + idade + ".");

            idade = (10 + 5) * 3;
            Console.WriteLine("idade = (10 + 5) * 3 --> " + idade + ".");

            Console.WriteLine("A execução do programa acabou... Pressione Enter.");
            Console.ReadLine();
        }
    }
}
