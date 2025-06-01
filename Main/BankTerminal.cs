namespace Main;

public class BankTerminal
{
    Bank bank = new Bank();
    public void Start()
    {
        while (true)
        {
            DisplayMenu();
            string? option = Console.ReadLine();

            if (option == "1")
            {
                bank.CheckBalance();
            }
            else if (option == "2")
            {
                bank.Deposit();
            }
            else if (option == "3")
            {
                bank.withDraw();
            }
            else
            {
                Console.WriteLine("Operação Invalida");
            }

        }
    }
    public void DisplayMenu()
    {
        Console.WriteLine("====Bank====");
        Console.WriteLine("[1] Valor em Conta");
        Console.WriteLine("[2] Depositar");
        Console.WriteLine("[3] Sacar");
        Console.WriteLine("[4] Sair");
    }
}