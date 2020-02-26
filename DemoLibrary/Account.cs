using System;
using System.Collections.Generic;

namespace DemoLibrary
{
    public class Account
    {
        public event EventHandler<string> TransactionApprovedEvent;
        public string AccountName { get; set; }
        public decimal Balance { get; private set; }
        private List<string> _transactions = new List<string>();

        public IReadOnlyList<string> Transactions
        {
            get { return _transactions.AsReadOnly(); }
        }

        public bool AddDeposit(string depositName, decimal amount)
        {
            _transactions.Add($"Deposited { string.Format("{0:C2}", amount) } for { depositName }");
            Balance += amount;
            TransactionApprovedEvent?.Invoke(this, depositName);
            return true;
        }

        public bool MakePayment(string paymentName, decimal amount, Account backupAccount = null)
        {
            if(Balance > amount)
            {
                _transactions.Add($"Withdrew { string.Format("{0:C2}", amount) } for { paymentName}");
                Balance -= amount;
                TransactionApprovedEvent?.Invoke(this, paymentName);
                return true;
            }
            else
            {
                if(backupAccount != null)
                {
                    if((backupAccount.Balance + Balance) > amount)
                    {
                        decimal amountNeeded = amount - Balance;
                        bool overdraftSuccessed = backupAccount.MakePayment("Overdraft Protection", amountNeeded);

                        if(overdraftSuccessed == false)
                        {
                            return false;
                        }

                        AddDeposit("Overdraft Protection Deposit", amountNeeded);

                        _transactions.Add($"Withdrew { string.Format("{0:C2}", amount) } for { paymentName }");
                        Balance -= amount;
                        TransactionApprovedEvent?.Invoke(this, paymentName);


                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
        }
    }
}