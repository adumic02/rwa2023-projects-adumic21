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
    public class ExpenseTypeRepository
    {
        public static ExpenseType GetExpenseType(int id)
        {
            ExpenseType expenseType = null;
            string sql = $"SELECT * FROM ExpenseType WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                expenseType = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return expenseType;
        }
        public static List<ExpenseType> GetExpenseTypes()
        {
            List<ExpenseType> expenseTypes = new List<ExpenseType>();
            string sql = "SELECT * FROM ExpenseType";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                ExpenseType expenseType = CreateObject(reader);
                expenseTypes.Add(expenseType);
            }
            reader.Close();
            DB.CloseConnection();
            return expenseTypes;
        }
        private static ExpenseType CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string type = reader["Type"].ToString();

            var expenseType = new ExpenseType
            {
                Id = id,
                Type = type
            };
            return expenseType;
        }
    }
}