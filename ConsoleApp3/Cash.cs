namespace ConsoleApp3;

public class Cash:IpaymentMethod
{
    public decimal balance;

    
    public Cash(decimal balance)
    {
        this.balance = balance;
    }

    public void Pay(decimal amount)
    {
        try
        {
            if (amount > balance)
            {
                throw new Exception("Insufficient balance");
            } 
            balance -= amount;
            Console.WriteLine("Successfully paid");
    
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("End of payment");
        }
    }
}