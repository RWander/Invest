using System.Collections.Generic;
using System.Linq;

using Dapper;

using Invest.Common.Data;
using Invest.Core.Domain;

namespace Invest.Core.Repository
{
    public interface ITransactionRepository
    {
        IReadOnlyCollection<TransactionItem> GetOpenTransactions();
    }

    internal sealed class TransactionRepository: RepositoryBase, ITransactionRepository
    {
        public TransactionRepository(IConnectionFactory connFactory)
            : base(connFactory)
        { }

        public IReadOnlyCollection<TransactionItem> GetOpenTransactions()
        {
            using (var conn = ConnectionFactory.Create())
            {
                var items = conn.Query<TransactionItem>(
                    "SELECT Id FROM TRANSACTION WHERE IsCompleted = 0"
                ).ToList();

                return items;
            }
        }
    }
}