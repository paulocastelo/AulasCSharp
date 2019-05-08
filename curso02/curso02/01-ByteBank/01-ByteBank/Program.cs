using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100.0;

            Console.WriteLine("O titular é " + contaDaGabriela.titular);
            Console.WriteLine("A agência é " + contaDaGabriela.agencia);
            Console.WriteLine("O número da conta é " + contaDaGabriela.numero);
            Console.WriteLine("O saldo é " + contaDaGabriela.saldo);
            contaDaGabriela.saldo += 200.0;
            Console.WriteLine("O novo aldo é " + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
