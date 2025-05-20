using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloBank
{
    public record Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction(decimal amount, DateTime date, string notes)
        {
            Amount = amount;
            Date = date;
            Notes = notes;
        }
        public string Kind => Amount switch
        {
            > 0 => "Deposit",
            < 0 => "Withdrawal",
            _ => "Unknown"
        };

    }
    //h
}
