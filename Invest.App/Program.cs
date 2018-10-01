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

            var d = new Core.Module();

            // Init modules
            Core.Module.Instance.RegisterServices(services);
            // ..

            // Build provider
            Provider = services.BuildServiceProvider();

            // Pass Service Provider to modules
            Core.Module.Instance.ResolveProvider(Provider);
            // ..
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
