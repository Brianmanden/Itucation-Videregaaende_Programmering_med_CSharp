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

            //---Exercise 2: Interface---

            //b.Create a class called DeathStar that implements the ILaser interface.
            //You decide what the FireLaser method does.If you can't think of anything, just make it write/return "Pew pew".
            DeathStar deathStar = new DeathStar();

            //c.Fire your lasers!
            deathStar.FireLaser();

            #endregion

            Console.WriteLine(Environment.NewLine);

            #region Exercise 3
            //---Exercise 3: Enum---

            //b.Use an object of the Random class to select two suitable random numbers(use the Next method) :
            //- Use one random number to get the face value of a card.
            //- Use the other random number to get the suit value of a card.

            //c.Print the card (face and suit)!

            Random random = new Random();
            Console.WriteLine($"Random card drawn: { (Face)random.NextInt64(13)} of { (Suit)random.NextInt64(4)}");

            #endregion

            Console.ReadKey();
        }
    }
}