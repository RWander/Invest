using System;

using Microsoft.Extensions.DependencyInjection;

namespace Invest.App
{
    public static class Program
    {
        private static readonly IServiceProvider Provider;

        static Program()
        {
            var services = new ServiceCollection();

            // Init modules
            var core = Core.Module.Instance;
            core.RegisterServices(services);
            // ..

            // Build provider
            Provider = services.BuildServiceProvider();

            // Pass Service Provider to modules
            core.ResolveProvider(Provider);
            // ..
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
