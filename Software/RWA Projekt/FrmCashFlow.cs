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
    public partial class FrmCashFlow : Form
    {
        public FrmCashFlow()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIncomeShow_Click(object sender, EventArgs e)
        {
            FrmIncomes frmIncomes = new FrmIncomes();
            frmIncomes.ShowDialog();
        }

        private void FrmCashFlow_Load(object sender, EventArgs e)
        {
            List<Expense> expenses = ExpenseRepository.GetExpenses();
            List<Income> incomes = IncomeRepository.GetIncomes();

            decimal sumOfExpenses = expenses.Sum(se => se.Amount);
            decimal sumOfIncomes = incomes.Sum(si => si.Amount);
            decimal profitLoss = sumOfIncomes - sumOfExpenses;
            decimal averageOfIncomes = incomes.Average(ai => ai.Amount);
            decimal averageOfExpenses = expenses.Average(ae => ae.Amount);

            txtExpenseSum.Text = sumOfExpenses.ToString("0.00");
            txtIncomeSum.Text = sumOfIncomes.ToString("0.00");
            txtProfitLoss.Text = profitLoss.ToString("0.00");
            txtAverageIncomes.Text = averageOfIncomes.ToString("0.00");
            txtAverageExpenses.Text = averageOfExpenses.ToString("0.00");

            chrGraph.Titles.Add("Omjer prihoda i rashoda");
            chrGraph.Series["sExpenseIncome"].IsValueShownAsLabel = true;

            chrGraph.Series["sExpenseIncome"].Points.AddXY("Rashodi", sumOfExpenses);
            chrGraph.Series["sExpenseIncome"].Points.AddXY("Prihodi", sumOfIncomes);
        }
    }
}