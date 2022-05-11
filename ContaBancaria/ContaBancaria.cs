public class ContaBancaria
{
    public string Nome { get; set; }
    public string TipoConta { get; set; }

    public double SaldoConta { get; set; }
    public ContaBancaria(string name, string tipoconta,double saldoconta )
    {
        Nome = name;
        TipoConta = tipoconta;
        SaldoConta = saldoconta;
    }
}

class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria("Cauã","Conta-Corrente",125.25);
        Console.WriteLine("ContaBancaria Nome = {0} TipoConta = {1} SaldoConta = {3}", conta.Nome,conta.TipoConta,conta.SaldoConta);
   
    }
}
