namespace ConsoleApp3;

public delegate void AccountHandler(string message);
public class Account
{
     int sum;
     
     AccountHandler taken;


     public void Register(AccountHandler del)
     {
          taken += del;
     }

     public void Unregister(AccountHandler del)
     {
          taken -= del;
     }

     
     public Account(int sum)
     {
          this.sum = sum;
     }
     
     public void Add(int amount)=>sum += amount;

     
     
     public void Subtract(int amount)
     {
          if (sum >= amount)
          {
               sum -= amount;
               taken?.Invoke($"Subtracted from balance {amount}");
          }
          else
          {
               taken?.Invoke($"Insufficent balance {sum}");
          }
     }
}