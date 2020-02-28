using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

namespace DatabaseConnectionPool.DBConnectionPool
{
    public class DataSourceConnectionPool
    {
        #region Properties

        /// <summary>
        /// Connection Timeout
        /// </summary>
        public const int Timeout = 3600;

        /// <summary>
        /// 
        /// </summary>
        public const int PoolSize = 10;
        string connectionString { get; set; }

        /// <summary>
        /// Create Connection Pool
        /// </summary>
        static List<IDbConnection> ConnectionPool;
        #endregion

        #region Constructor

        public DataSourceConnectionPool(IConfiguration configuration)
        {
            connectionString = configuration.GetValue<string>("DatabaseInfo:ConnectionString");
            Initialize();
        }
        #endregion

        #region Initial Connection Pool
        private void Initialize()
        {
            ConnectionPool = new List<IDbConnection>();
            for (int i = 0; i < PoolSize; i++)
            {
                IDbConnection dbConnection = new NpgsqlConnection(connectionString);
                Console.WriteLine("Create new Connection");
                dbConnection.Open();
                ConnectionPool.Add(dbConnection);
                Console.WriteLine("Add Connection into Pool[" + ConnectionPool.Count + "]");
            }
        }
        #endregion
        /// <summary>
        /// Find a ready Connection in pool
        /// </summary>
        /// <returns>IDbConnection</returns>
        public static IDbConnection GetDbConnect()
        {
            IDbConnection dbConnection = null;
            for (int i = 0; i < PoolSize; i++)
            {
                if (ConnectionPool[i].State == ConnectionState.Open)
                {
                    dbConnection = ConnectionPool[i];
                    Console.WriteLine("Connecting Pool[" + i + "]" + ".......[" + dbConnection.State + "]");
                    break;
                }
                else
                {
                    Console.WriteLine("All Connection are busy.");
                }
            }
            return dbConnection;
        }
    }
}
