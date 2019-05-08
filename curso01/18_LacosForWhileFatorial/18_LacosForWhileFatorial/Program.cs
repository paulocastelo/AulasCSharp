using System;

namespace _18_LacosForWhileFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://cursos.alura.com.br/course/csharp-parte-1-primeiros-passos/task/38065
            Console.WriteLine("Digite o fatorial que deseja:");
            int limite = Convert.ToInt32(Console.ReadLine()); //Este é o fatorial
            int novoLimite = limite;
            int fatorial = 1; //Este é o contador
            int novoFatorial = 1;

            Console.WriteLine("Execução do laço do fatorial utilizando FOR:");
            for (int contador = 1; contador <= limite; contador++)
            {
                //fatorial = fatorial * contador;
                fatorial *= contador; // Forma simples
                Console.WriteLine(contador + " fatorial = " + fatorial);

            }

            Console.WriteLine("Execução do laço do fatorial utilizando WHILE:");
            int novoContador = 1;
            while (novoContador <= novoLimite)
            {
                novoFatorial *= novoContador;
                Console.WriteLine(novoContador + " fatorial = " + novoFatorial);
                novoContador++;
            }

        }
    }
}
