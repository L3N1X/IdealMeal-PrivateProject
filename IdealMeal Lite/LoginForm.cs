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
            //Kreiramo nekakvog korisnika. ako su upisani podaci jednaki ovome korisniku, pusti ga u aplikaciju

            User user = new User("lucija", "lzidaric", "1234");
            bool loginSucessful = false;
            //Dohvati vrijednosti iz tekstualih polja
            string username = this.txtUsername.Text;
            string password = this.txtPassword.Text;
            //Ako je upisan tekst jednak ovim podacima, 
            if(username == user.Username && password == user.Password)
            {
                //login je prosao
                loginSucessful = true;
            }

            /*
            
            mogli smo takoder

            if(username == "lzidaric" && password == "1234")
            {
                //login je prosao
                loginSucessful = true;
            }

            ali onda nam User ne bi uopce trebao, a zelimo glumiti da je nasa aplikacija nadogradiva ako zelimo u buducnosti dodati jos korisnika.
            recimo moglu bi napraviti listu korisnika, proci kroz nju sa foreach i pitati svakog korisnika da li ima upisane podatke, ako nademo 
            covjeka koji ima, pogodili smo username i password i uspjesno se ulogriali u aplikaciju!

             */

            if (loginSucessful == true)
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
