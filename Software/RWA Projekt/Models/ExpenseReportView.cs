using RWA_Projekt.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWA_Projekt.Models
{
    public class ExpenseReportView
    {
        public string TypeName { get; set; }
        public int Tag { get; set; }

        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public ExpenseReportView(Expense expense)
        {
            Id = expense.Id;
            Amount = expense.Amount;
            Date = expense.Date;
            Description = expense.Description;

            var activities = ActivityRepository.GetActivities(expense);

            var typeName = activities.FirstOrDefault(a => a.TypeName == expense.Activity.TypeName);
            TypeName = typeName.TypeName;

            var tag = activities.FirstOrDefault(a => a.Tag == expense.Activity.Tag);
            Tag = tag.Tag;
        }
    }
}
