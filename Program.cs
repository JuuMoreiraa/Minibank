// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

Conta conta = new Conta();
conta.Saldo = 2000.00;
conta.Limite = 100.00;

double saldoLimite = conta.Saldo+conta.Limite;

Console.WriteLine("Bem vindo ao Minibank SA");

tryagain:
Console.WriteLine("");
Console.WriteLine("Qual transação deseja efetuar na sua conta? \n[D]Depósito \n[S] Saque \n[V] Visualizar saldo da conta \n[X] Sair");
string opcao = Console.ReadLine();

  //--------------------------------------------------------------------------------------------------------------------------//
 //Equals("s",StringComparison.OrdinalIgnoreCase) => usado no caso de letras maiúsculas/minúsculas nas opções do tipo string.//
//--------------------------------------------------------------------------------------------------------------------------//

switch (opcao.ToUpper())
{
    case "D":
        Console.WriteLine("Qual valor você deseja depositar?");
        double dp = double.Parse(Console.ReadLine());
        Console.WriteLine($"O saldo atualizado na sua conta é de {conta.Depositar(dp):c}");
        Thread.Sleep(2500);
        goto tryagain;

    case "S":
        Console.WriteLine("Qual valor você deseja sacar?");
        double scr = double.Parse(Console.ReadLine());
        if(scr > saldoLimite){
            Console.WriteLine($"Transação não realizada. \nCod Motivo: C0045 - Saldo insuficiente para efetuar saque");
        } else { 
            if(scr > conta.Saldo){
                conta.Sacar(scr);
                Console.WriteLine($"Saque realizado com sucesso utilizando o LIMITE da conta. O saldo atualizado na sua conta é de {scr-saldoLimite:c}");
            } else {
                conta.Sacar(scr);
                Console.WriteLine($"Saque realizado com sucesso. O saldo restante na sua conta é de {conta.Saldo:c}");
            }
        }
        Thread.Sleep(2500);
        goto tryagain;

    case "V":
        Console.WriteLine($"O saldo da sua conta é de {conta.Saldo}\nE o limite liberado pelo banco é de {conta.Limite}");
        Thread.Sleep(2500);
        goto tryagain;

    case "X":
        Console.Clear();
        Console.WriteLine($"Volte sempre!");
        break;

    default:
        Console.Clear();
        Console.WriteLine("Opção inválida! Tente novamente.");
        goto tryagain;
}
