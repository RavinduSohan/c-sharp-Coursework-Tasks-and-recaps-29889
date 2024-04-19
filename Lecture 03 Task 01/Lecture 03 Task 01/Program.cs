using System;

public class BankAccount
{
    
    private decimal balance;

    
    public BankAccount(decimal initialBalance)
    {
        if (initialBalance < 0)
        {
            throw new ArgumentException("Initial balance cannot be negative.");
        }

        this.balance = initialBalance;
    }

   
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive.");
        }

        this.balance += amount;
        Console.WriteLine($"Deposited {amount:C}. New balance: {balance:C}");
    }

    
    public void CheckBalance()
    {
        Console.WriteLine($"Current balance: {balance:C}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            
            BankAccount myAccount = new BankAccount(1000m);

            
            myAccount.CheckBalance();

            
            myAccount.Deposit(500m);

           
            myAccount.CheckBalance();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
