using RWA_Projekt.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWA_Projekt.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public bool CheckPassword(string password)
        {
            return Password == password;
        }
        public void PerformActivityEntry(ExpenseType expenseType, int tag, string typeName)
        {
            ActivityRepository.InsertActivity(expenseType, tag, typeName);
        }
        public void PerformExpenseEntry(Activity activity, DateTime date, decimal amount, string description)
        {
            ExpenseRepository.InsertExpense(date, activity, amount, description);
        }
        public void PerformIncomeEntry(decimal amount)
        {
            IncomeRepository.InsertIncome(amount);
        }
    }
}
