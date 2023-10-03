namespace AbstractClassesInterfacesEnums.Models
{
    //--- Exercise 1: Abstract Class ---
    // c.Create a derived class called SavingsAccount that implements the Withdraw and Deposit methods.
    // When you use the deposit method, the amount is automatically increased by .1%
    // before the amount is added to your balance.
    // Withdraw just subtracts from your balance.
    
    internal class SavingsAccount : BankAccount
    {
        public override decimal Deposit(decimal amount)
        {
            Balance *= (decimal)1.01;
            Balance += amount;

            return Balance;
        }

        public override decimal WithDraw(decimal amount)
        {
            Balance -= amount;

            return Balance;
        }
    }
}
