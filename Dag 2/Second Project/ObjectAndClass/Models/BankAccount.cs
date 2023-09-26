namespace ObjectAndClass.Models
{
    //--- Exercise 5 ---
    //Class: BankAccount
    //- Consider which fields/variables a bank account might need.
    //- Consider what behaviour it needs to implement.
    //- Now write the class! Both Constructor and a few required methods.
    //Create an object to test the behaviour of your new class!

    public class BankAccount
    {
        // latest account created in the bank
        private static int _accountNumber = 1;
        private List<BankAccount> _accounts = new List<BankAccount>();
        
        // Name of the person holding the account
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public decimal Balance {  get; set; } = 0;

        // Registration number (of the bank)
        public int RegNumber { get; set; } = 400;

        // Acconut number (in the bank)
        public int AccountNumber { get; set; } = 0;

        public BankAccount OpenAccount(string FirstName, string LastName)
        {
            BankAccount account = new BankAccount();
            account.FirstName = FirstName;
            account.LastName = LastName;
            account.RegNumber = RegNumber;
            _accountNumber++;
            account.AccountNumber = _accountNumber;
            _accounts.Add(account);

            return account;
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        public void InsertAmount(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        public void WithdrawAmount(decimal amount)
        {
            decimal newBalance = Balance - amount;
            if (newBalance > 0)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew: {amount}");
                Console.WriteLine($"New balance: {newBalance}");
            }
            else
            {
                Console.WriteLine($"Can not withdraw more than: {Balance}");
            }
        }
    }
}
