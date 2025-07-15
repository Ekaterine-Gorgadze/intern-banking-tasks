namespace BankingApp
{
     public class Customer
     {
          public Guid CustomerId { get; private set; } = Guid.NewGuid();
          public string FullName { get; private set; }
          public string EmailAddress { get; private set; }
          public DateTime DateOfBirth { get; private set; }

          public Customer(Guid id, string name, string email, DateTime birthday)
          {
               CustomerId = id;
               FullName = name;
               EmailAddress = email;
               DateOfBirth = birthday;
          }

          public string getCustomerSummary()
          {
               return $"Customer Information Summary: \n" +
                      $"Customer Id - {CustomerId}\n" + $"Customer Name - {FullName}\n" +
                      $"Customer Email - {EmailAddress}\n" + $"Customer Birthdate - {DateOfBirth:dd-mm-yyyy}";
          }

     }
}