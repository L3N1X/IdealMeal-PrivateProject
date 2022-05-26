using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdealMeal_Lite
{
    //Ovo je korisnička kontrola, zapravo se ponaša kao mini forma koju možete isto postavljati kao oste kontrole, recimo možete otići u toolbox i dodati ovu vašu custom kontrolu na
    //formu isto kao i što bi stavili gumb, textbox i sl. Svi ti elementi ili "programski moduli??" se zovu kontrole (controls). Mi smo tu sada definirali svoju, ona ima sliku
    //namirnice, label gdje pise naziv namirnice i kalorije.
    public partial class GroceryControl : UserControl
    {
        //Korisnicka kontrola mora sadržavati namirnicu 
        public Grocery Grocery { get; set; }
        //Ne možemo je instancirati bez namirnice
        public GroceryControl(Grocery grocery)
        {
            this.Grocery = grocery;
            InitializeComponent();
        }

        private void GroceryControl_Load(object sender, EventArgs e)
        {
            //Kada se učita u label stavljamo naziv te namirnice
            this.lblName.Text = Grocery.Name;

            //Također dodajemo koliko kalorija ima u label.
            this.lblCalories.Text = this.Grocery.Calories.ToString();

            //Tools.CenterControlInParentHorizontally(this.lblName);
            //Tools.CenterControlInParentHorizontally(this.lblCalories);
        }
    }
}
