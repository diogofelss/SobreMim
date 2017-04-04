using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace musimet.data.repository.Dapper.Commons
{
    public class ConnectionManager : IDbConnection
    {
        private readonly IDbConnection _connection;

        public void Dispose()
        {
            _connection.Close();

            GC.SuppressFinalize(this);
        }

        public ConnectionManager()
        {
            _connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["musimet"].ConnectionString);
        }

        public IDbConnection Connection
        {
            get { return _connection; }
        }

        public IDbTransaction BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public IDbTransaction BeginTransaction(IsolationLevel il)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void ChangeDatabase(string databaseName)
        {
            throw new NotImplementedException();
        }

        public IDbCommand CreateCommand()
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            throw new NotImplementedException();
        }

        public string ConnectionString
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public int ConnectionTimeout
        {
            get { throw new NotImplementedException(); }
        }

        public string Database
        {
            get { throw new NotImplementedException(); }
        }

        public ConnectionState State
        {
            get { throw new NotImplementedException(); }
        }
    }
}
