using System;
using System.Collections.Generic;
using System.Linq;
using Tectil.NCommand.Contract;

using Invest.Core;
using Invest.Core.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Invest.App.Command
{
    public class OpenTransactionsCommand
    {
        private readonly IServiceProvider _provider = Program.Provider;

        [Command]
        public IList<string> GetOpenTransaction()
        {
            var packageSrvc = _provider.GetService<PackageService>();

            return packageSrvc.GetOpenTransactions()
                .Select(t => t.Amount.ToString())
                .ToList();
        }
    }
}