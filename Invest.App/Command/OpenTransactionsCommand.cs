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
        private readonly IPackageService _packageSrvc;

        public OpenTransactionsCommand()
        {
            _packageSrvc = Program.Provider.GetService<IPackageService>();
        }

        [Command]
        public IList<string> GetOpenTransaction()
        {
            return _packageSrvc.GetOpenTransactions()
                .Select(t => t.Amount.ToString())
                .ToList();
        }
    }
}