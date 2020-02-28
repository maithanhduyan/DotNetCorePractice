namespace DatabaseConnectionPool.Logging
{
    public interface IDataConnectionPoolLogging<T>
    {
        /// <summary>
        /// Infomation
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        void LogInformation(string message, params object[] args);

        /// <summary>
        /// Warning 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        void LogWarning(string message, params object[] args);
    }
}
