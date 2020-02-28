using Microsoft.Extensions.Logging;

namespace DatabaseConnectionPool.Logging
{
    public class DataConnectionPoolLogging<T> : IDataConnectionPoolLogging<T>
    {
        /// <summary>
        /// ILogger
        /// </summary>
        private readonly ILogger<T> _logger;

        public DataConnectionPoolLogging(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<T>();
        }
        /// <summary>
        /// LogInformation
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public void LogInformation(string message, params object[] args)
        {
            _logger.LogInformation(message, args);
        }

        /// <summary>
        /// LogWarning
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public void LogWarning(string message, params object[] args)
        {
            _logger.LogWarning(message, args);
        }
    }
}
