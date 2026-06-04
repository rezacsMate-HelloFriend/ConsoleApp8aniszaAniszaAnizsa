using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8asdasda
{
    public class Bank
    {
        protected string Owner { get; set; }
        private int Balance { get; set; }
        public Bank(string owner, int balance)
        {
            Owner = owner;
            Balance = balance;
        }
        public void Pay(int amount)
        {
            Balance += amount;
        }
        public bool WithDraw(int amount)
        {
            if (Balance - amount < 0)
            {
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }
        public int GetBalance() { return Balance; }

    }
    public class PremiumAccount : Bank
    {
        public double BonusPrecentage { get; set; }
        public PremiumAccount(string owner, int balance, double bonusprecentage) : base(owner, balance)
        {
            BonusPrecentage = bonusprecentage;
        }
        public void BonusReturn()
        {

        }
    }
}
