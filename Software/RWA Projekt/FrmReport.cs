using RWA_Projekt.Models;
using RWA_Projekt.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RWA_Projekt
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private List<ExpenseReportView> GenerateExpenses()
        {
            var allExpenses = ExpenseRepository.GetExpenses();
            var reports = new List<ExpenseReportView>();

            foreach (var expense in allExpenses)
            {
                var report = new ExpenseReportView(expense);
                reports.Add(report);
            }
            return reports;
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            var results = GenerateExpenses();
            expenseReportViewBindingSource.DataSource = results;
            rpvResults.RefreshReport();
        }
    }
}
