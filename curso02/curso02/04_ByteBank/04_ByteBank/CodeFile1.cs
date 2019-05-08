public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100.0;

    public bool sacar (double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }
}