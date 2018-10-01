using System.Collections.Generic;
using System.Linq;

namespace Invest.Core.Domain
{
    public sealed class Transaction
    {
        public int Id { get; set; }

        public string What { get; set; }

        public bool IsCompleted => Purchases.Sum(p => p.Amount) - Sales.Sum(s => s.Amount) == 0;

        public IList<TransactionItem> Purchases { get; }

        public IList<TransactionItem> Sales { get; }

        public ushort Profit { get; set; }
        public ushort Tax { get; set; }
        public ushort NetProfit { get; set; } // = Profit - Tax

        public Transaction()                                                                                                                                      
        {
            Purchases = new List<TransactionItem>();
            Sales = new List<TransactionItem>();
        }
    }
}