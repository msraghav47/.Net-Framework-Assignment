using System;
namespace Lab22
{
    public class BankAccount
    {
        string name;
        double accountno;
        double balance;
        public BankAccount(string name, double accountno, double balance)
        {
            this.name = name;
            this.accountno = accountno;
            this.balance = balance;
        }
        public void deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("You have deposited rs : "+amount);
        }
        public void withdraw(double amount)
        {
            if (balance < amount)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("you have withdrawled rs : " + amount);
            }

        }
        public void accountdetail()
        {
            Console.WriteLine("Account Holder Name : " + name);
            Console.WriteLine("Balance : " + balance);
            Console.WriteLine("Account No : " + accountno);
        }
        public static void Main(string[] args)
        {
            BankAccount ba = new BankAccount("Raghav", 36898421566, 12000);
            ba.accountdetail();
            ba.deposit(10000);
            ba.accountdetail();
            ba.withdraw(5000);
            ba.accountdetail();
        }
    }
}