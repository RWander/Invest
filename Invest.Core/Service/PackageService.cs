using System.Collections.Generic;

using Microsoft.Extensions.DependencyInjection;

using Invest.Core.Domain;
using Invest.Core.Repository;

namespace Invest.Core.Service
{
    public sealed class PackageService
    {
        private readonly ITransactionRepository _transactionRepo;

        public PackageService()
        {
            var provider = Module.Instance.Provider;

            _transactionRepo = provider.GetService<ITransactionRepository>();
        }

        public IReadOnlyCollection<TransactionItem> GetOpenTransactions()
        {
            return _transactionRepo.GetOpenTransactions();
        }
    }
}