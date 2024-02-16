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
    public class IncomeRepository
    {
        public static List<Income> GetIncomes()
        {
            List<Income> incomes = new List<Income>();
            string sql = $"SELECT * FROM Income";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Income income = CreateObject(reader);
                incomes.Add(income);
            }
            reader.Close();
            DB.CloseConnection();
            return incomes;
        }
        public static void InsertIncome(decimal amount)
        {
            string sql = $"INSERT INTO Income (Amount) VALUES ('{amount}')";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        private static Income CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            decimal amount = decimal.Parse(reader["Amount"].ToString());

            var income = new Income
            {
                Id = id,
                Amount = amount
            };
            return income;
        }
    }
}
