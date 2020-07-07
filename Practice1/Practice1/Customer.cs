using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Customer
    {
        private string accName;
        private int accNum;
        private double accBalance;

        public Customer()
        {
            
        }
        public Customer(int Num, string Name, double Balance)
        {
            Num = accNum;
            Name = accName;
            Balance = accBalance;
        }
        public double Balance
        {
            get 
            {
                return accBalance;
            }
            set
            {
                accBalance = value;
            }

        }
        public int Account
        {
            get
            {
                return accNum;
            }
            set
            {
                accNum = value;
            }
        }
        public string Name
        {
            get
            {
                return accName;
            }
            set
            {
                accName = value;
            }
        }

        public override string ToString()
        {
            return "\nName on Account:" + Name +
                    "\nAccount Number:" + Account.ToString() +
                    "\nBalance on Account:" + Balance.ToString() + "$";
        }
        
    }
}
