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
    public class ExpenseRepository
    {
        public static List<Expense> GetExpenses()
        {
            List<Expense> expenses = new List<Expense>();
            string sql = $"SELECT * FROM Expense";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Expense expense = CreateObject(reader);
                expenses.Add(expense);
            }
            reader.Close();
            DB.CloseConnection();
            return expenses;
        }
        public static List<Expense> GetExpensesFromMonth(int month)
        {
            List<Expense> expenses = new List<Expense>();
            string sql = $"SELECT * FROM Expense WHERE MONTH(Date) = '{month}'";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Expense expense = CreateObject(reader);
                expenses.Add(expense);
            }
            reader.Close();
            DB.CloseConnection();
            return expenses;
        }
        public static void InsertExpense(DateTime date, Activity activity, decimal amount, string description)
        {
            string sql = $"INSERT INTO Expense (Amount, Date, Description, ActivityId) VALUES ('{amount}', '{date}', '{description}', '{activity.Id}')";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        private static Expense CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            decimal amount = decimal.Parse(reader["Amount"].ToString());
            DateTime date = DateTime.Parse(reader["Date"].ToString());
            string description = reader["Description"].ToString();

            int idActivity = int.Parse(reader["ActivityId"].ToString());
            var activity = ActivityRepository.GetActivity(idActivity);

            var expense = new Expense
            {
                Id = id,
                Amount = amount,
                Date = date,
                Description = description,
                Activity = activity

            };
            return expense;
        }
    }
}
