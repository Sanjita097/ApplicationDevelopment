// BankAccount class
class BankAccount
{
    // Private fields
    private string accountNumber;
    private double balance;

    // Constructor to set accountNumber and initial balance
    public BankAccount(string accNumber, double initialBalance)
    {
        accountNumber = accNumber;

        // Ensure initial balance is positive
        if (initialBalance > 0)
            balance = initialBalance;
        else
            balance = 0;
    }

    // Public property: AccountNumber (read-only)
    public string AccountNumber
    {
        get { return accountNumber; }
    }

    // Public property: Balance (read-only outside, private set)
    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value > 0)
                balance = value;
        }
    }

    // Deposit method
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Successfully deposited {amount:C}. Current balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be greater than 0.");
        }
    }

    // Withdraw method
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Successfully withdrew {amount:C}. Current balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount. Check your balance.");
        }
    }
}