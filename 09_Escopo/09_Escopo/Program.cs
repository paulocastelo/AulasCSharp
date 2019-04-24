using System;

namespace _09_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escopo das variáveis.");
            //https://cursos.alura.com.br/course/csharp-parte-1-primeiros-passos/task/37982

            int idadePessoa = 18;
            bool acompanhado = false;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "Você está acompanhado";
            }
            else
            {
                mensagemAdicional = "Você não está acompanhado";
            }

            if (idadePessoa >= 18 && acompanhado == true)
            {
                Console.WriteLine(mensagemAdicional);
                Console.WriteLine("Você pode entrar.");
            }
            else
            {
                Console.WriteLine(mensagemAdicional);
                Console.WriteLine("Você não pode entrar.");
            }


            Console.WriteLine("O programa acabou a execução... Pressione a tecla ENTER.");
            Console.ReadLine();
        }
    }
}
