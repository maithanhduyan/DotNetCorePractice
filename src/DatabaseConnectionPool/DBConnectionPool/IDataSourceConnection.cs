using System.Data;

namespace DatabaseConnectionPool.DBConnectionPool
{
    public interface IDataSourceConnection
    {
        /// <summary>
        /// Create new IDbConnection using for open a database.
        /// </summary>
        /// <returns>System.Data.IDbConnection</returns>
        IDbConnection GetInstant();

    }
}
