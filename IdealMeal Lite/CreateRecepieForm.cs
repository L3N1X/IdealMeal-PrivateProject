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
    public partial class CreateRecepieForm : Form
    {
        //Lista sastojaka od kojih ćemo napraviti recept (to su svi oni sastojci koje je korisnik dodao, onda je odabrao opciju kreiraj recept!).
        public IList<Ingridient> Ingridients { get; set; }
        //Ovo je recept koji će se kreirati. Ili neće! - neće ako korisnik klikne X umjesto kreiraj recept
        public Recepie Recepie { get; set; }
        public CreateRecepieForm(IList<Ingridient> ingridients)
        {
            this.Ingridients = ingridients;
            InitializeComponent();
        }

        private void CreateRecepieForm_Load(object sender, EventArgs e)
        {
            double totalRecepieCalories = 0.0; //Koliko ukupno kalorija ima cijeli recept

            //Prolazimo kroz sve sastojke za recept
            foreach (Ingridient ingridients in Ingridients)
            {
                lbIngridients.Items.Add(ingridients); //U popis sastojaka recepta, dodajemo sve sastojke koje je korisnik odabrao (listbox) (To je da korisnik vidi što je sve dodao)

            }

            this.lblCalories.Text = temp.Nutrition.Calories.ToString();

            Tools.CenterControlInParentHorizontally(this.lblCalories);

            this.lblFat.Text = "Masnoće: " + temp.Nutrition.Fat.ToString() + "g";
            this.lblProtein.Text = "Bjelančevine: " + temp.Nutrition.Protein.ToString() + "g";
            this.lblCarbs.Text = "Ugljikohidrati: " + temp.Nutrition.Carbs.ToString() + "g";
        }

        private void btnCreateRecepie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtName.Text))
            {
                MessageBox.Show("Navedite naziv namirnice");
                return;
            }
            this.Recepie = new Recepie(this.txtName.Text, this.txtDesription.Text, Ingridients);
            this.Close();
        }
    }
}
