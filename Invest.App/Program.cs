using System;
using Invest.Core.Service;
using Microsoft.Extensions.DependencyInjection;
using Tectil.NCommand;
using Tectil.NCommand.Contract;

namespace Invest.App
{
    public static class Program
    {
        internal static readonly IServiceProvider Provider;

        static Program()
        {
            var services = new ServiceCollection();
            services.AddSingleton<PackageService, PackageService>();

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
            //Console.WriteLine("Hello World!");

            var commands = new NCommands();
            commands.Context.AutodetectCommandAssemblies(); // Loads all assemblies in bin folder and checks for CommandAttribute
            commands.Context.Configuration.DisplayExceptionDetails = false;
            // commands.Context.Configuration.Notation = ParserNotation.Unix;
            commands.RunConsole(args);
        }
    }
}
