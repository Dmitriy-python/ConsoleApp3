namespace ConsoleApp3;



public class Checkout
{
    public static void Payment(IpaymentMethod paymentMethod, decimal amount)
    {
        paymentMethod.Pay(amount);
        
    }
}