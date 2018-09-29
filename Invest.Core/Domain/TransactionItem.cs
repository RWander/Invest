using System;

namespace Invest.Core.Domain
{
    public abstract class TransactionItem
    {
        public bool Type { get; set; } // true - Purchase, false - Sale
        public DateTime When { get; set; }
        public ushort Amount { get; set; }
        public float Cost { get; set; }
        public float TotalCost { get; set; }
        public float Commission { get; set; }
    }
}