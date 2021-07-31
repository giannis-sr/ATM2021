using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM2021
{
    class ATM
    {
        private static double balance = 0;

        //Καταθεση ποσου
        public static void Deposit(double amount)
        {
            balance += amount;
        }


        //Αναληψη ποσου
        public static bool withdraw( double amount)
        {
            bool result;
            if (amount > balance)
                result = false;
            else
            {
                balance -= amount;
                result = true;
            }

            return result;
        }

        public static double getBalance()
        {
            return balance;
        }

        public static void setBalance(double balance)
        {
            ATM.balance = balance;
        }
    }
}
