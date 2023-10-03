using AbstractClassesInterfacesEnums.Enums;
using AbstractClassesInterfacesEnums.Models;

namespace AbstractClassesInterfacesEnums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1

            // Savings Account

            SavingsAccount savingsAccount = new SavingsAccount();
            decimal savingsAccountFirstBalance = savingsAccount.Deposit(3000);
            Console.WriteLine($"Savings Account First balance: { savingsAccountFirstBalance }");

            decimal savingsAccountSecondBalance = savingsAccount.WithDraw(3001);
            Console.WriteLine($"Savings Account Second balance: {savingsAccountSecondBalance}");



            // Checkings Account

            CheckingAccount checkingAccount = new CheckingAccount();
            decimal checkingAccountFirstBalance = checkingAccount.Deposit(3000);
            Console.WriteLine($"Checking Account First balance: { checkingAccountFirstBalance }");
            
            decimal checkingAccountSecondBalance = checkingAccount.WithDraw(3001);
            Console.WriteLine($"Checking Account Second balance: { checkingAccountSecondBalance }");

            #endregion

            Console.WriteLine(Environment.NewLine);

            #region Exercise 2

            DeathStar deathStar = new DeathStar();
            deathStar.FireLaser();

            #endregion

            Console.WriteLine(Environment.NewLine);

            #region Exercise 3
            Random random = new Random();

            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine($"[{i}] - Random card drawn: { (Face)random.NextInt64(13)} of { (Suit)random.NextInt64(4)}");
            //}
            
            Console.WriteLine($"Random card drawn: { (Face)random.NextInt64(13)} of { (Suit)random.NextInt64(4)}");

            #endregion

            Console.ReadKey();
        }
    }
}