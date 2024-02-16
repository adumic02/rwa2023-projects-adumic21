using DBLayer;
using RWA_Projekt.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWA_Projekt.Repositories
{
    public class UserRepository
    {
        public static User GetUser(string userName)
        {
            string sql = $"SELECT * FROM [User] WHERE UserName = '{userName}'";
            return FetchUser(sql);
        }
        private static User FetchUser(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            User user = null;

            if (reader.HasRows)
            {
                reader.Read();
                user = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return user;
        }
        private static User CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            string userName = reader["UserName"].ToString();
            string password = reader["Password"].ToString();

            var user = new User
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                UserName = userName,
                Password = password
            };
            return user;
        }
    }
}
