namespace AbstractClassesInterfacesEnums.Models
{
    // --- Exercise 1: Abstract Class ---
    // a.Create an abstract class named BankAccount.The class has an attribute called balance.
    // You decide whether a bank account has an initial balance of 0 or uses a number parameter in its constructor.
    // A bank account has two required abstract methods: Deposit and Withdraw.Both can be either void methods or return balance.
    // For testing purposes, you might want a way to check your balance between Deposit/Withdraw calls as well.
    
    internal abstract class BankAccount
    {
        public decimal Balance { get; set; } = 0;

        public abstract decimal Deposit(decimal amount);
        public abstract decimal WithDraw(decimal amount);
    }
}
