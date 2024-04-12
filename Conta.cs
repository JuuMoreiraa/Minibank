public class Conta
{
    //Construtor da classe permite que sejam definidos valores padrão de início da instanciação da classe
    public Conta()
    {
        Saldo = 2000;
        Limite = 100;
    }

    //Propriedades
    public double Saldo { get; set; }
    public double Limite { get; set; }

    //Procedimentos (ação)
    public double Sacar(double valorS)
    {
        Tarifar();
        Saldo -= valorS;
        return Saldo;
    }

    public double Depositar(double valorD)
    {
        Tarifar();
        Saldo += valorD;
        return Saldo;
    }

    private double Tarifar()
    {
        return Saldo -= 0.5;
    }
}