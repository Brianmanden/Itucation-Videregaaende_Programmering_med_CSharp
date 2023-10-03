namespace AbstractClassesInterfacesEnums.Models
{
    // --- Exercise 1: Abstract Class ---
    // b.Create a derived class called CheckingAccount that implements the Withdraw and Deposit methods.
    // When you use the withdraw method with a number higher than 3000,
    // the method should print a warning and do nothing else.
    // Deposit just adds to your balance.

    internal class CheckingAccount : BankAccount
    {
        public override decimal Deposit(decimal amount)
        {
            Balance += amount;
            return Balance;
        }

        public override decimal WithDraw(decimal amount)
        {
            if (amount > 3000) {
                Console.WriteLine("Warning. Suspiciously high amount.");
            }
            else
            {
                Balance -= amount;
            }

            return Balance;
        }
    }
}
