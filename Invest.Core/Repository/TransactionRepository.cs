using System.Collections.Generic;
using System.Configuration;
using System.Data;

using Microsoft.Data.Sqlite;

using Invest.Core.Domain;

namespace Invest.Core.Repository
{
    public interface ITransactionRepository
    {
        IReadOnlyCollection<TransactionItem> GetOpenTransactions();
    }

    public sealed class TransactionRepository: ITransactionRepository
    {
        private readonly string _connString = 
            ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        public IReadOnlyCollection<TransactionItem> GetOpenTransactions()
        {
            //using (var conn = new SQLiteConnection)
            return null;
        }
    }
}