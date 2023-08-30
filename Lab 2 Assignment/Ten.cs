using System;
namespace Lab210
{
    public class BankAccount
    {
        public double AccountNumber;
        public double Balance;
        public BankAccount(double accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }
        public void show()
        {
            Console.WriteLine("Acconut No : " + AccountNumber);
            Console.WriteLine("Balance : " + Balance);
        }
    }
    sealed class SavingsAccount : BankAccount
    {
        SavingsAccount(double AccountNumber, double Balance) : base(AccountNumber, Balance)
        {

        }
        public void CalculateInterest(int Time, double Rate)
        {
            double Interest = (Balance * Time * Rate) / 100;
            Balance  = Balance+ Interest;
        }
        public static void Main(string[] args)
        {
            SavingsAccount sa = new SavingsAccount(36898421566,20000);
            sa.show();
            sa.CalculateInterest(5, 33.33);
            sa.show();
        }
    }
}
