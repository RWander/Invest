using System;
using Microsoft.Extensions.DependencyInjection;

namespace Invest.Common.Module
{
    public abstract class ModuleBase<T>: IModule
        where T: IModule, new()
    {
        private static readonly Lazy<T> _instance = new Lazy<T>(() => new T(), true);
        public static T Instance => _instance.Value;

        protected ModuleBase()
        {
            if (_instance.IsValueCreated)
            {
                throw new NotSupportedException($"An instance of {typeof(T)} is already created.");
            }
        }

        public IServiceProvider Provider
        {
            get;
            private set;
        }

        public void RegisterServices(IServiceCollection serviceCollection)
        {
            if (serviceCollection == null) throw new ArgumentNullException(nameof(serviceCollection));

            RegisterImp(serviceCollection);
        }

        protected abstract void RegisterImp(IServiceCollection serviceCollection);

        public void ResolveProvider(IServiceProvider provider)
        {
            Provider = provider ?? throw new ArgumentNullException(nameof(provider));
        }
    }
}