using System.Data.SqlClient;

namespace MiniORMLive
{
    class ConnectionStringBuilder
    {
        private SqlConnectionStringBuilder connectionString;

        public ConnectionStringBuilder(string databaseName)
        {
            connectionString = new SqlConnectionStringBuilder();
            connectionString["Server"] = ".";
            connectionString["Integrated Security"] = true;
            connectionString["Trusted_Connection"] = true;
            connectionString["Connect Timeout"] = 1000;
            connectionString["Database"] = databaseName;
        }

        public string ConnectionString => connectionString.ToString();
    }
}
