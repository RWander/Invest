using Microsoft.Extensions.DependencyInjection;

using Invest.Common.Data;
using Invest.Common.Module;
using Invest.Core.Data;
using Invest.Core.Repository;
using Invest.Core.Service;

namespace Invest.Core
{
    public sealed class Module: ModuleBase<Module>
    {
        protected override void RegisterImp(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IConnectionFactory, ConnectionFactory>();
            serviceCollection.AddSingleton<ITransactionRepository, TransactionRepository>();
            serviceCollection.AddSingleton<IPackageService, PackageService>();
        }
    }
}