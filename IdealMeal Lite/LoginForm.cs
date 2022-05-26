using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace IdealMeal_Lite
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //Kliknuti je login gumb
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //kreiramo listu svih korisnika ove aplikacije
            List<User> users = new List<User>();
            User lucija = new User("Lucija Zidarić", "lucija", "1234");
            User marta = new User("Marta Vlahek", "marta", "1234");

            //Dodajemo ove korisnike
            users.Add(lucija);
            users.Add(marta);

            bool loginSucessful = false;
            //Dohvati vrijednosti iz tekstualih polja
            string username = this.txtUsername.Text;
            string password = this.txtPassword.Text;

            //Idemo kroz svakog korisnika i pokušavamo naći onog koji ima isto korisničko ime koje smo upisali i password, ako nađemo neki, korisnik se uspješno prijavio.
            foreach (User user in users)
            {
                if(username == user.Username && password == user.Password)
                {
                    loginSucessful = true;
                }
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
            //Ako je kriva kombinacija
            else
            {
                MessageBox.Show("Korisničko ime ili lozinka su krivi");
            }
        }
    }
}
