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
    public partial class FrmExpenseEntry : Form
    {
        public FrmExpenseEntry()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cboExpenseTag.Text) && !string.IsNullOrWhiteSpace(txtExpenseAmount.Text) && !string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                var currentActivity = cboExpenseTag.SelectedValue as Activity;
                var user = FrmLogin.loggedUser;
                DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                decimal amount;
                string description = txtDescription.Text;

                if (decimal.TryParse(txtExpenseAmount.Text, out amount) && amount > 0)
                {
                    user.PerformExpenseEntry(currentActivity, date, amount, description);
                    MessageBox.Show("Trošak uspješno unesen!", "Potvrda!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Visina troška može poprimiti isključivo brojčanu vrijednost veću od 0!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Unesite sve potrebne podatke o trošku!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmExpenseEntry_Load(object sender, EventArgs e)
        {
            var activities = ActivityRepository.GetActivities2();
            cboExpenseTag.DataSource = activities;
        }
    }
}