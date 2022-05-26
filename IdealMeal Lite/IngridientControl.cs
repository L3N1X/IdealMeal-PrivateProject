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
    public partial class IngridientControl : UserControl
    {
        public Ingridient Ingridient { get; set; }
        public IngridientControl(Ingridient ingridient)
        {
            this.Ingridient = ingridient;
            InitializeComponent();
        }
        private void IngridientControl_Load(object sender, EventArgs e)
        {
            double caloriesPerHunderdGrams = Ingridient.Grocery.Calories;
            double totalAmount = Ingridient.Amount; //Ovdje tu smo spremili kolicinu u gramima npr. Korisnik je upisao da ima 200 grama tog sastojka
            //Tu samo trebamo ispisati koliko taj sastojak u toj količini ima kalorija. Pošto mi u svojoj namirnici(Grocery) izražavamo kalorije kao broj kalorija po 100 grama (npr Grocery namirnica = new Namrinica("Pekmez", 180))
            totalAmount = totalAmount / 100.0; //Sada smo od 180g dobili 1.8
            double finalCalories = caloriesPerHunderdGrams * totalAmount;

            this.lblGrocery.Text = Ingridient.Grocery.Name;
            this.lblAmount.Text = Ingridient.Amount.ToString() + "g";
            this.lblCalories.Text = finalCalories.ToString();

            //Tools.CenterControlInParentHorizontally(this.lblGrocery);
            //Tools.CenterControlInParentHorizontally(this.lblAmount);
            //Tools.CenterControlInParentHorizontally(this.lblCalories);
        }
    }
}
