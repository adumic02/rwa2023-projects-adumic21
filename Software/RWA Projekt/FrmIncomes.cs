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
    public partial class FrmIncomes : Form
    {
        public FrmIncomes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIncomeEntry_Click(object sender, EventArgs e)
        {
            FrmIncomeEntry frmIncomeEntry = new FrmIncomeEntry();
            frmIncomeEntry.ShowDialog();
        }

        private void ShowIncomes(List<Income> incomes)
        {
            dgvIncomes.DataSource = incomes;

            dgvIncomes.Columns["Id"].DisplayIndex = 0;
            dgvIncomes.Columns["Amount"].DisplayIndex = 1;

            dgvIncomes.Columns["Id"].HeaderText = "ID prihoda";
            dgvIncomes.Columns["Amount"].HeaderText = "Visina prihoda (€)";
        }

        private void FrmIncomes_Load(object sender, EventArgs e)
        {
            ShowIncomes(IncomeRepository.GetIncomes());
        }
    }
}
