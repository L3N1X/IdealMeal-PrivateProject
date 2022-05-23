using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdealMeal_WinForms
{
    public partial class LoginForm : Form
    {
        private DataManager dataManager;
        public LoginForm(DataManager dataManager)
        {
            InitializeComponent();
            this.txtPassword.PasswordChar = '*';
            this.dataManager = dataManager;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text;
            string password = this.txtPassword.Text;
            dataManager.User = dataManager.AuthAdminUser(username, password);
            if (dataManager.User is null)
            {
                MessageBox.Show("Korisničko ime ili lozinka su krivi");
                this.txtUsername.Text = string.Empty;
                this.txtPassword.Text = string.Empty;
            }
            else
                this.DialogResult = DialogResult.OK;
        }
    }
}
