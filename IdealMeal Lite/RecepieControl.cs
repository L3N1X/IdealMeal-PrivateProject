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
    public partial class RecepieControl : UserControl
    {
        public Recepie Recepie { get; set; }
        public RecepieControl(Recepie recepie)
        {
            Recepie = recepie;
            InitializeComponent();
        }

        private void RecepieControl_Load(object sender, EventArgs e)
        {
            this.lblName.Text = Recepie.Name;

            double totalRecepieCalories = 0.0; //Koliko ukupno kalorija ima cijeli recept

            List<Ingridient> ingridients = Recepie.Ingridients; //Ovdje spremamo sve sastojke od recepta kako bi ih mogli sve proći i pozbrajati sve ukupne kalorije

            //Prolazimo kroz sve sastojke za recept
            foreach (Ingridient ingridient in ingridients)
            {
                double caloriesPerHunderdGrams = ingridient.Grocery.Calories;
                double totalAmount = ingridient.Amount; //Ovdje tu smo spremili kolicinu u gramima npr. Korisnik je upisao da ima 200 grama tog sastojka
                                                        //Tu samo trebamo ispisati koliko taj sastojak u toj količini ima kalorija. Pošto mi u svojoj namirnici(Grocery) izražavamo kalorije kao broj kalorija po 100 grama (npr Grocery namirnica = new Namrinica("Pekmez", 180))
                totalAmount = totalAmount / 100.0; //Sada smo od 180g dobili 1.8
                totalRecepieCalories = totalRecepieCalories + (totalAmount * caloriesPerHunderdGrams); //npr pekmez koji ima 100kcal na 100g sada smo dobili 100 * 1.8 == 180 kcal na 180g i sve to zbrajamo sa ukupnim kalorijama i tak za svaki 
            }

            lblCalories.Text = totalRecepieCalories.ToString(); //Ispisujemo koliko ukupno recept ima kalorija

            //Tools.CenterControlInParentHorizontally(this.lblName);
            //Tools.CenterControlInParentHorizontally(this.lblCalories);
        }
    }
}
