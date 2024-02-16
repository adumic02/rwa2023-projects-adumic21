using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLayer
{
    public static class DB
    {
        private static string _connectionString = @"Data Source=31.147.204.119\PISERVER,1433; Initial Catalog=RWA23_adumic21_DB; User=adumic21; Password=NH78mSvv";

        private static SqlConnection _connection;

        public static void OpenConnection()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        public static void CloseConnection()
        {
            if (_connection.State != 0)
            {
                _connection.Close();
            }
        }

        public static SqlDataReader GetDataReader(string query)
        {
            SqlCommand sqlCommand = new SqlCommand(query, _connection);
            return sqlCommand.ExecuteReader();
        }

        public static object GetScalar(string query)
        {
            SqlCommand sqlCommand = new SqlCommand(query, _connection);
            return sqlCommand.ExecuteScalar();
        }

        public static int ExecuteCommand(string sqlCommand)
        {
            SqlCommand sqlCommand2 = new SqlCommand(sqlCommand, _connection);
            return sqlCommand2.ExecuteNonQuery();
        }
    }
}
