namespace BankingApp
{
     public class BankAccount
     {
          public string AccountNumber { get; private set; }
          public float Balance { get; private set; }
          public Customer customer { get; private set; }

          public BankAccount(Customer cs, float balance)
          {
               customer = cs;
               Balance = balance;
               AccountNumber = RandomAccountNumberGenerator();
          }

          public string RandomAccountNumberGenerator()
          {
               var rand = new Random();
               return rand.Next(1000000000, int.MaxValue).ToString();
          }

          public string PrintAccountSummary()
          {
               return "Account Summary: \n" + $"Customer - {customer.FullName}\n" +
                       $"Account Number - {AccountNumber}\n" + $"Balance - {(float)Balance}";
          }
     }
}