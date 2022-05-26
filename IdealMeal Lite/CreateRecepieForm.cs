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
        public List<Ingridient> Ingridients { get; set; }
        //Ovo je recept koji će se kreirati. Ili neće! - neće ako korisnik klikne X umjesto kreiraj recept
        public Recepie RecepieToCreate { get; set; }
        public CreateRecepieForm(List<Ingridient> ingridients)
        {
            this.Ingridients = ingridients;
            InitializeComponent();
        }

        private void CreateRecepieForm_Load(object sender, EventArgs e)
        {
            double totalRecepieCalories = 0.0; //Koliko ukupno kalorija ima cijeli recept

            //Prolazimo kroz sve sastojke za recept
            foreach (Ingridient ingridient in Ingridients)
            {
                lbIngridients.Items.Add(ingridient); //U popis sastojaka recepta, dodajemo sve sastojke koje je korisnik odabrao (listbox) (To je da korisnik vidi što je sve dodao)
                double caloriesPerHunderdGrams = ingridient.Grocery.Calories;
                double totalAmount = ingridient.Amount; //Ovdje tu smo spremili kolicinu u gramima npr. Korisnik je upisao da ima 200 grama tog sastojka
                                                        //Tu samo trebamo ispisati koliko taj sastojak u toj količini ima kalorija. Pošto mi u svojoj namirnici(Grocery) izražavamo kalorije kao broj kalorija po 100 grama (npr Grocery namirnica = new Namrinica("Pekmez", 180))
                totalAmount = totalAmount / 100.0; //Sada smo od 180g dobili 1.8
                totalRecepieCalories = totalRecepieCalories + (totalAmount * ingridient.Grocery.Calories); //npr pekmez koji ima 100kcal na 100g sada smo dobili 100 * 1.8 == 180 kcal na 180g i sve to zbrajamo sa ukupnim kalorijama i tak za svaki 
            }

            lblCalories.Text = totalRecepieCalories.ToString(); //Ispisujemo koliko ukupno recept ima kalorija

            //Tools.CenterControlInParentHorizontally(this.lblCalories);
        }

        private void btnCreateRecepie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtName.Text))
            {
                MessageBox.Show("Navedite naziv namirnice");
                return;
            }
            //Kreiramo novi recept ako je korisnik kliknuo kreiraj recept
            string recepieName = txtName.Text;
            string description = txtDesription.Text;
            RecepieToCreate = new Recepie(txtName.Text, txtDesription.Text, Ingridients);
            Close();
        }
    }
}
