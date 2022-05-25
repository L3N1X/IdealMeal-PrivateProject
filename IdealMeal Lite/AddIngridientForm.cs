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
    public partial class AddIngridientForm : Form
    {
        //Forma ima svoju namrinicu
        public Grocery Grocery { get; set; }
        //Ima i sastojak koji hoce ili nece ispuniti, ovisi klikne li korisnik gumb za dodavanje ili samo X
        public Ingridient Ingridient { get; set; }
        //Ne možemo kreirati formu bez namirnice (namirnica je odmah odabrana kada se otvori forma).
        //Mi smo kliknuli dodaj sastojak, forma ima odabranu namirnicu i ona samo od nas očekuje da upišemo količinu, kako
        //bi stvorili sastojak.
        public AddIngridientForm(Grocery grocery)
        {
            this.Grocery = grocery;
            InitializeComponent();
        }

        //Forma se učitala
        private void AddIngridientForm_Load(object sender, EventArgs e)
        {
            lblGroceryName.Text = Grocery.Name;
            //Tools.CenterControlInParentHorizontally(groceryControl);
        }

        //Kliknuli smo na gumb za dodati sastojak unutar te forme
        private void btnAddIngridient_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(txtAmount.Text);
            if (string.IsNullOrEmpty(this.txtAmount.Text))
            {
                MessageBox.Show("Navedite količinu");
                return;
            }
            //Kreiramo sastojak, ako je upisan neki broj za količinu. Sastojku u konstruktor stavljamo namirnicu i količinu
            //Ovom sastojku ćemo pristupiti iz MainForm.
            this.Ingridient = new Ingridient(Grocery, amount);
            //Kliknuli smo gumb za dodati, odabrali količinu, kreirali sastojak, možemo zatvoriti ovu formu.
            this.Close();
        }
    }
}
