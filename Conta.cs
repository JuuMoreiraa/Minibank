public class Conta
{
    //Construtor da classe permite que sejam definidos valores padrão de início da instanciação da classe
    public Conta()
    {

    }

    //Propriedades
    public double Saldo { get; set; }
    public double Limite { get; set; }

    //Procedimentos (ação)
    public double Sacar(double valorS)
    {
        return Saldo -= valorS;
    }

    public double Depositar(double valorD)
    {
        return Saldo += valorD;
    }

}