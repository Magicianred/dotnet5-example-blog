using System.Data;

namespace Example.Blog.Domain.Interfaces.Repositories
{
    public interface IDatabaseConnectionFactory
    {
        IDbConnection GetConnection();
    }
}
