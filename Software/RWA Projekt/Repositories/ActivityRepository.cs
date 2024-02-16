using DBLayer;
using RWA_Projekt.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RWA_Projekt.Repositories
{
    public class ActivityRepository
    {
        public static Activity GetActivity(int activityId)
        {
            Activity activity = null;
            string sql = $"SELECT * FROM Activity WHERE Id = '{activityId}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                activity = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return activity;
        }
        public static List<Activity> GetActivities(Expense expense)
        {
            List<Activity> activities = new List<Activity>();
            string sql = $"SELECT * FROM Activity WHERE Id = '{expense.Activity.Id}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Activity activity = CreateObject(reader);
                activities.Add(activity);
            }
            reader.Close();
            DB.CloseConnection();
            return activities;
        }
        public static List<Activity> GetActivities2()
        {
            List<Activity> activities = new List<Activity>();
            string sql = "SELECT * FROM Activity";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Activity activity = CreateObject2(reader);
                activities.Add(activity);
            }
            reader.Close();
            DB.CloseConnection();
            return activities;
        }
        public static bool CheckActivity(ExpenseType expenseType, int tag)
        {
            if (expenseType.Id == 1 && !(tag >= 11 && tag <= 19))
            {
                MessageBox.Show("Oznaka aktivnosti može biti isključivo broj od 11 do 19!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (expenseType.Id == 2 && !(tag >= 21 && tag <= 29))
            {
                MessageBox.Show("Oznaka aktivnosti može biti isključivo broj od 21 do 29!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (expenseType.Id == 3 && !(tag >= 31 && tag <= 39))
            {
                MessageBox.Show("Oznaka aktivnosti može biti isključivo broj od 31 do 39!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (expenseType.Id == 4 && !(tag >= 41 && tag <= 49))
            {
                MessageBox.Show("Oznaka aktivnosti može biti isključivo broj od 41 do 49!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (expenseType.Id == 5 && !(tag >= 51 && tag <= 59))
            {
                MessageBox.Show("Oznaka aktivnosti može biti isključivo broj od 51 do 59!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool CheckIfTagExist(int tag)
        {
            bool checker = false;
            string sql = $"SELECT * FROM Activity WHERE Tag = '{tag}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                checker = true;
            }
            DB.CloseConnection();
            return checker;
        }
        public static bool CheckIfTypeNameExist(string typeName)
        {
            bool checker = false;
            string sql = $"SELECT * FROM Activity WHERE TypeName = '{typeName}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                checker = true;
            }
            DB.CloseConnection();
            return checker;
        }
        public static void InsertActivity(ExpenseType expenseType, int tag, string typeName)
        {
            string sql = $"INSERT INTO Activity (Tag, TypeName, ExpenseTypeId) VALUES ('{tag}', '{typeName}', '{expenseType.Id}')";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        private static Activity CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            int tag = int.Parse(reader["Tag"].ToString());
            string typeName = reader["TypeName"].ToString();

            int idExpenseType = int.Parse(reader["ExpenseTypeId"].ToString());
            var expenseType = ExpenseTypeRepository.GetExpenseType(idExpenseType);


            var activity = new Activity
            {
                Id = id,
                Tag = tag,
                TypeName = typeName,
                ExpenseType = expenseType
            };
            return activity;
        }
        private static Activity CreateObject2(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            int tag = int.Parse(reader["Tag"].ToString());
            string typeName = reader["TypeName"].ToString();

            var activity = new Activity
            {
                Id = id,
                Tag = tag,
                TypeName = typeName
            };
            return activity;
        }
    }
}
