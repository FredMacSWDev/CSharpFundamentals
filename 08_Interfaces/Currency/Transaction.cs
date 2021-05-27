using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Currency
{
    public class Transaction
    {
        // Making it private readonly allows only it's information inside the class, but we can only set it at the time of construction
        private readonly ICurrency _currency;

        public Transaction(ICurrency currency)
        {
            _currency = currency;

            DateOfTransaction = DateTimeOffset.Now;
        }

        public DateTimeOffset DateOfTransaction { get; private set; }

        public decimal GetTransactionAmount()
        {
            return _currency.Value;
        }

        public string GetTransactionType()
        {
            return _currency.Name;
        }

    }
}
