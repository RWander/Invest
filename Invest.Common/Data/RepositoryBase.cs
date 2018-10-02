namespace Invest.Common.Data
{
    public abstract class RepositoryBase
    {
        protected IConnectionFactory ConnectionFactory { get; }

        protected RepositoryBase(IConnectionFactory connectionFactory)
        {
            ConnectionFactory = connectionFactory;
        }
    }
}