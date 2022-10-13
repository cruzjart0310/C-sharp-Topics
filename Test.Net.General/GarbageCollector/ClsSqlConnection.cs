using System;
using System.Data.SqlClient;
using Test.Net.Helper;

namespace Test.Net.General.GarbageCollector
{
    public class ClsSqlConnection : IDisposable
    {
        private SqlConnection _connection;

        public string GetDate()
        {
            if (_connection == null)
            {
                _connection = new SqlConnection(Propierties.connectionString);  
                _connection.Open();
            }

            using (SqlCommand cmd = new SqlCommand("SELECT GETDATE()", _connection))
            {
                return cmd.ExecuteScalar().ToString();
            }
        }
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                _connection.Close();
                _connection.Dispose();
            }
        }

        ~ClsSqlConnection()
        {
            Dispose(false);
        }
    }
}
