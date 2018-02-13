public class BankAccount
{
    int id;
    decimal balance;
    
    public int Id
    {
        get
        {
            return this.id;
        }
        set
        {
            this.id = value;
        }
    }

    public decimal Balance
    {
        get { return this.balance; }
        set { this.balance = value; }
    }

    public void Deposit(decimal amount)
    {
        this.Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (balance < amount)
        {
            System.Console.WriteLine("Insufficient balance");
        }
        else
        {
            this.Balance -= amount;
        }
    }

    public override string ToString()
    {
        return $"Account ID{this.Id}, balance {this.Balance:F2}";
    }
    private int myVar;

    public int MyProperty
    {
        get { return myVar; }
        set { myVar = value; }
    }

}