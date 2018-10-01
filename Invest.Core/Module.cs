using Microsoft.Extensions.DependencyInjection;

using Invest.Common.Module;
using Invest.Core.Repository;

namespace Invest.Core
{
    public sealed class Module: ModuleBase<Module>
    {
        protected override void RegisterImp(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<ITransactionRepository, TransactionRepository>();
        }
    }
}