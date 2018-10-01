using System;

using Microsoft.Extensions.DependencyInjection;

namespace Invest.Common.Module
{
    public interface IModule
    {
        IServiceProvider Provider { get; }
        void RegisterServices(IServiceCollection serviceCollection);
        void ResolveProvider(IServiceProvider provider);
    }
}