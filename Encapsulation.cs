using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICEPROBLEMSDAY1
{
    public class Bank
    {
        private double balance;
        private string name;
        public double GetBalance()
        {
            return balance;
        }
        
        public string GetName()
        {
            return name; 
        }
        

        public void SetBalance(double balance)
        {
            this.balance = balance;
        }
        public void SetName(string name )
        {
            this.name = name;
        }

    }
}
