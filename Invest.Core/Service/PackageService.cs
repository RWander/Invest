using System.Collections.Generic;

using Invest.Core.Domain;
using Invest.Core.Repository;

namespace Invest.Core.Service
{
    public interface IPackageService
    {
        IReadOnlyCollection<TransactionItem> GetOpenTransactions();
    }

    internal sealed class PackageService : IPackageService
    {
        private readonly ITransactionRepository _transactionRepo;

        public PackageService(ITransactionRepository transactionRepo)
        {
            _transactionRepo = transactionRepo;
        }

        public IReadOnlyCollection<TransactionItem> GetOpenTransactions()
        {
            return _transactionRepo.GetOpenTransactions();
        }
    }
}