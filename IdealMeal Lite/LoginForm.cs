using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdealMeal_Lite
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool loginSucessful = false;
            //Dohvati vrijednosti iz tekstualih polja
            string username = this.txtUsername.Text;
            string password = this.txtPassword.Text;
            //Ako je upisan tekst jednak ovim podacima, 
            if(username == "lucija" && password == "1234")
            {
                //login je prosao
                loginSucessful = true;
            }
            if(loginSucessful == true)
            {
                //Ako je login prosao, otvori glavnu formu (glavni dio aplikacije) i sakri trenutnu formu
                Hide();
                //Napravi novu MainFormu
                MainForm form = new MainForm();
                //Iscrtaj je na ekran
                form.Show();
            }
        }
    }
}
