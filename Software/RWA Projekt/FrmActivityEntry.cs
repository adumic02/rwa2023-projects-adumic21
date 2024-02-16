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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RWA_Projekt
{
    public partial class FrmActivityEntry : Form
    {
        public FrmActivityEntry()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cboExpenseType.Text) && !string.IsNullOrWhiteSpace(txtActivityTag.Text) && !string.IsNullOrWhiteSpace(txtExpenseTypeName.Text))
            {
                var currentExpenseType = cboExpenseType.SelectedValue as ExpenseType;
                var user = FrmLogin.loggedUser;

                int selectedTag;
                string typeName = txtExpenseTypeName.Text;
                if (int.TryParse(txtActivityTag.Text, out selectedTag) && selectedTag > 0)
                {
                    if (ActivityRepository.CheckActivity(currentExpenseType, selectedTag))
                    {
                        if (ActivityRepository.CheckIfTagExist(selectedTag))
                        {
                            MessageBox.Show("Oznaka aktivnosti već postoji, unesite drugu oznaku aktivnosti iz odgovarajućeg raspona!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (ActivityRepository.CheckIfTypeNameExist(typeName))
                        {
                            MessageBox.Show("Naziv aktivnosti već postoji, unesite drugi naziv aktivnosti!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            user.PerformActivityEntry(currentExpenseType, selectedTag, typeName);
                            MessageBox.Show("Aktivnost uspješno unesena!", "Potvrda!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Oznaka aktivnost može poprimiti isključivo brojčanu vrijednost veću od 0!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Unesite sve potrebne podatke o aktivnosti!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmActivityEntry_Load(object sender, EventArgs e)
        {
            var expenseTypes = ExpenseTypeRepository.GetExpenseTypes();
            cboExpenseType.DataSource = expenseTypes;
        }
    }
}
