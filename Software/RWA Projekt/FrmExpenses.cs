using RWA_Projekt.Models;
using RWA_Projekt.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RWA_Projekt
{
    public partial class FrmExpenses : Form
    {
        public FrmExpenses()
        {
            InitializeComponent();
        }

        private void btnExpenseEntry_Click(object sender, EventArgs e)
        {
            FrmExpenseEntry frmExpenseEntry = new FrmExpenseEntry();
            frmExpenseEntry.ShowDialog();
        }

        private void btnCashFlow_Click(object sender, EventArgs e)
        {
            FrmCashFlow frmCashFlow = new FrmCashFlow();
            frmCashFlow.ShowDialog();
        }

        private void btnActivityEntry_Click(object sender, EventArgs e)
        {
            FrmActivityEntry frmActivityEntry = new FrmActivityEntry();
            frmActivityEntry.ShowDialog();
        }

        private void FrmExpenses_Load(object sender, EventArgs e)
        {
            ShowExpenses(ExpenseRepository.GetExpenses());
        }

        private void ShowExpenses(List<Expense> expenses)
        {
            dgvExpenses.DataSource = expenses;

            dgvExpenses.Columns["Id"].DisplayIndex = 0;
            dgvExpenses.Columns["Activity"].DisplayIndex = 1;
            dgvExpenses.Columns["Amount"].DisplayIndex = 2;
            dgvExpenses.Columns["Date"].DisplayIndex = 3;
            dgvExpenses.Columns["Description"].DisplayIndex = 4;

            dgvExpenses.Columns["Tag"].Visible = false;
            dgvExpenses.Columns["TypeName"].Visible = false;
            dgvExpenses.Columns["ExpenseType"].Visible = false;
            dgvExpenses.Columns["Type"].Visible = false;

            dgvExpenses.Columns["Id"].HeaderText = "ID troška";
            dgvExpenses.Columns["Activity"].HeaderText = "Vrsta troška";
            dgvExpenses.Columns["Amount"].HeaderText = "Visina troška (€)";
            dgvExpenses.Columns["Date"].HeaderText = "Datum troška";
            dgvExpenses.Columns["Description"].HeaderText = "Opis troška";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int month;
            if (int.TryParse(txtSearch.Text, out month))
            {
                ShowExpenses(ExpenseRepository.GetExpensesFromMonth(month));
            }
            else
            {
                MessageBox.Show("Unesite mjesec u brojčanom obliku (npr. 5 ukoliko želite troškove svibnja)!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = " ";
            ShowExpenses(ExpenseRepository.GetExpenses());
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            FrmReport frmReport = new FrmReport();
            frmReport.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowExpenses(ExpenseRepository.GetExpenses());
        }
    }
}