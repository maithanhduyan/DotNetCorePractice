using Npgsql;
using System.Data;

namespace DatabaseConnectionPool.DBConnectionPool
{
    public class DataSourceConnection : IDataSourceConnection
    {
        #region Connection Status 
        /// <summary>
        /// Enum Status
        /// </summary>
        public enum Status
        {
            Ready = 0,
            InProcess = 1
        }

        /// <summary>
        /// Connection Timeout
        /// </summary>
        public int Timeout { get; set; }

        /// <summary>
        /// Connection Status
        /// </summary>
        public int ConnectionStatus { get; set; }

        /// <summary>
        /// Local Connnection String
        /// </summary>
        private string _connectionString;
        #endregion

        #region Constructor
        /// <summary>
        /// Create new DataSourceConnection with Connection String
        /// </summary>
        /// <param name="ConnectionString"></param>
        public DataSourceConnection(string ConnectionString)
        {
            _connectionString = ConnectionString;
        }
        #endregion

        #region Method


        /// <summary>
        /// IDbConnection using Postgresl
        /// </summary>
        internal IDbConnection Connection
        {
            get
            {
                return new NpgsqlConnection(_connectionString);
            }
        }
        /// <summary>
        /// Initializes a new instance of Npgsql.NpgsqlConnection with the given connection string.
        /// The connection used to open the PostgreSQL database.
        /// </summary>
        /// <returns>IDbConnection</returns>
        public IDbConnection GetInstant()
        {
            // Initial Connection Status
            ConnectionStatus = (int)Status.Ready;
            return Connection;

        }
        #endregion
    }
}
