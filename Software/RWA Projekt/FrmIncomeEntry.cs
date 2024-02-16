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
    public partial class FrmIncomeEntry : Form
    {
        public FrmIncomeEntry()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAmount.Text))
            {
                var user = FrmLogin.loggedUser;
                decimal amount;

                if (decimal.TryParse(txtAmount.Text, out amount) && amount > 0)
                {
                    user.PerformIncomeEntry(amount);
                    MessageBox.Show("Prihod uspješno unesen!", "Potvrda!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Visina prihoda može poprimiti isključivo brojčanu vrijednost veću od 0!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Unesite sve potrebne podatke o prihodu!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
