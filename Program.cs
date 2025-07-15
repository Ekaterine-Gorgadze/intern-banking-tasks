// See https://aka.ms/new-console-template for more information
using BankingApp;
using System.Globalization;

class Program
{
     static void Main(string[] args)
     {
          Console.WriteLine("Welcome to the CLI app for bank account creation!");
          Console.WriteLine("-------------------------------------------------");

          Console.Write("Enter Customer Name: ");
          string customerName = Console.ReadLine();
          Console.Write("Enter Customer Email: ");
          string customerEmail = Console.ReadLine();

          bool isValid = false;
          float initialDeposit;

          do
          {
               Console.Write("Enter Customer Initial Deposit: ");
               string depositInput = Console.ReadLine();

               if (float.TryParse(depositInput, out initialDeposit) && initialDeposit > 0)
               {
                    isValid = true;
               }
               else
               {
                    Console.WriteLine("Invalid input, the initial deposit has to be positive.");
               }
          } while (!isValid);

          bool isValidDate = false;
          DateTime customerBirthday;

          do
          {
               Console.Write("Enter Customer Date Of Birth (dd-MM-yyyy): ");
               string dateInput = Console.ReadLine();

               if (DateTime.TryParseExact(dateInput, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out customerBirthday))
               {
                    if (customerBirthday <= DateTime.Today)
                    {
                         isValidDate = true;
                    }
                    else
                    {
                         Console.WriteLine("Invalid input, date can not be in the future.");
                    }
               }
               else
               {
                    Console.WriteLine("Invalid date input format, try again.");
               }

          } while (!isValidDate);

          Customer c1 = new Customer(customerName, customerEmail, customerBirthday);
          BankAccount b1 = new BankAccount(c1, (float)initialDeposit);

          Console.Write(b1.PrintAccountSummary());
          Console.Write("\nPress any key to exit.");
          Console.ReadKey();
     }
}
