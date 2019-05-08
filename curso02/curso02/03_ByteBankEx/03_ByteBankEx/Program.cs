using System;

namespace _03_ByteBankEx
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente primeiraContaCorrente = new ContaCorrente();
            Console.WriteLine("Saldo inicial da 1ª conta: " + primeiraContaCorrente.saldo + ".");
            primeiraContaCorrente.saldo += 200;
            Console.WriteLine("Novo saldo da 1ª conta é: " + primeiraContaCorrente.saldo);

            ContaCorrente segundaContaCorrente = new ContaCorrente();
            Console.WriteLine("Saldo inicial da 2ª conta: " + segundaContaCorrente.saldo + ".");
            segundaContaCorrente.saldo += 50;
            Console.WriteLine("Novo saldo da 2ª conta é : " + segundaContaCorrente.saldo +  ".");
            Console.ReadLine();
        }
    }
}
