using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://cursos.alura.com.br/course/csharp-parte-2-introducao-orientacao-objetos/task/38812
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("O titular é " + contaDaGabriela.titular);
            Console.WriteLine("A agência é " + contaDaGabriela.agencia);
            Console.WriteLine("O número da conta é " + contaDaGabriela.numero);
            Console.WriteLine("O saldo é " + contaDaGabriela.saldo);
            contaDaGabriela.saldo += 200.0;
            Console.WriteLine("O novo saldo é " + contaDaGabriela.saldo);

            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";
            Console.WriteLine("Sr(a). " + contaDoBruno.titular + ", informe o valor que deseja depositar:");
            double valorDepositado = Convert.ToDouble(Console.ReadLine());
            contaDoBruno.saldo += valorDepositado;
            Console.WriteLine("Novo saldo do Bruno é: " + contaDoBruno.saldo);
            Console.WriteLine("Sr(a). " + contaDoBruno.titular + ", informe o valor que deseja sacar:");
            double valorSaque = Convert.ToDouble(Console.ReadLine());
            if(contaDoBruno.sacar(valorSaque) == false)
            {
                Console.WriteLine("Operação não permitida!");
            }
            else
            {
                Console.WriteLine("Saque realizado com sucesso!");
                Console.WriteLine("Seu saldo é: " + contaDoBruno.saldo + ".");
            }
            Console.ReadLine();
        }
    }
}
