// See https://aka.ms/new-console-template for more information
using BankingApp;

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

           
     }
}
