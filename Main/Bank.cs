using System.Security.Cryptography.X509Certificates;

namespace Main;

public class Bank
{
    decimal balance = 10000;
    public void CheckBalance()
    {
        Console.WriteLine($"O Saldo em Conta é: {balance}");
    }

    public void Deposit()
    {
        Console.Write("Informe o Valor a ser Depositado? ");

        if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
        {
            balance += amount;
        }
        else
        {
            Console.WriteLine("Valor Invalido. Tente Novamente");
        }

    }

    public void withDraw()
    {
        Console.WriteLine("Informe o valor a ser retirado? ");

        if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"O valor de {amount} foi descontado de sua Conta.");
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente ou Invalido");
            }
        }
        else
        {
            Console.WriteLine("Valor Invalido. Tente Novamente");
        }

    }


}