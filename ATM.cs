using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class ATM
    {
        private double balance;
        public ATM(double balance)
        {
            this.balance = balance;
        }
        public static int displayMenu()
        {
            Console.WriteLine("---Menu---");
            Console.WriteLine("Please select an option.");
            Console.WriteLine("1. check balance\n2. withdraw\n3. deposit\n4. exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;

        }
        public void withdraw()
        {
            Console.WriteLine("How much to withdraw?");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount <= balance){
                this.balance -= amount;
                Console.WriteLine("Withdrawal successful");
            }
            else
                Console.WriteLine("Balance not enough for withdrawal.");

        }
        public void deposit()
        {
            Console.WriteLine("How much to deposit?");
            this.balance += Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Deposit successful");
        }
        public void checkBalance()
        {
            Console.WriteLine("Current balance: {0:C}" , this.balance);
        }
        
    }
}
