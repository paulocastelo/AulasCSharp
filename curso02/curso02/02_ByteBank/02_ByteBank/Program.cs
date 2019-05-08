using System;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("O titular é " + contaDaGabriela.titular);
            Console.WriteLine("A agência é " + contaDaGabriela.agencia);
            Console.WriteLine("O número da conta é " + contaDaGabriela.numero);
            Console.WriteLine("O saldo é " + contaDaGabriela.saldo);
            contaDaGabriela.saldo += 200.0;
            Console.WriteLine("O novo saldo é " + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
