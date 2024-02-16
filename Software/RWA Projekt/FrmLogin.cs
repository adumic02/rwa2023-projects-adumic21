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
    public partial class FrmLogin : Form
    {
        public static User loggedUser { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUserName.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text)) 
            {
                loggedUser = UserRepository.GetUser(txtUserName.Text);
                if (loggedUser != null && loggedUser.CheckPassword(txtPassword.Text))
                {
                    Hide();
                    var form = new FrmExpenses();
                    form.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Neispravni korisnički podaci!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Unesite sve potrebne korisničke podatke!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

