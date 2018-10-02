using System.Data;

namespace Invest.Common.Data
{
    public interface IConnectionFactory
    {
        IDbConnection Create();
    }
}