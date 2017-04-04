using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace musimet.data.repository.Dapper.Commons
{
    public class Repository : IDisposable
    {
        public IDbConnection MusiMetConnection
        {
            get { return new ConnectionManager().Connection; }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
