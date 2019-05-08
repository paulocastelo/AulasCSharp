using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;

            Console.WriteLine("A conta da Gabriel é igual a conta da Gabriela Costa:");
            Console.WriteLine("Igualdade de referência:" + (contaDaGabriela == contaDaGabrielaCosta));
            int idade = 27;
            int outraIdade = 27;
            Console.WriteLine("Igualdade de valores:" + (idade == outraIdade));

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
