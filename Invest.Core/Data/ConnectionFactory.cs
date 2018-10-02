using System.Configuration;
using System.Data;

using Microsoft.Data.Sqlite;

using Invest.Common.Data;

namespace Invest.Core.Data
{
    internal sealed class ConnectionFactory: IConnectionFactory
    {
        private readonly string _connString =
            ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        public IDbConnection Create()
        {
            return new SqliteConnection(_connString);
        }
    }
}