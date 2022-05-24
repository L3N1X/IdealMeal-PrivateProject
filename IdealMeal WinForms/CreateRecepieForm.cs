using DataLayer.Model;
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
    public partial class CreateRecepieForm : Form
    {
        public IList<Ingridient> Ingridients { get; set; }
        public Recepie Recepie { get; set; }
        public CreateRecepieForm(IList<Ingridient> ingridients)
        {
            this.Ingridients = ingridients;
            InitializeComponent();
        }

        private void CreateRecepieForm_Load(object sender, EventArgs e)
        {
            this.Ingridients.ToList().ForEach(ingridient => this.lbIngridients.Items.Add(ingridient));
            Recepie temp = new Recepie("", "", this.Ingridients);

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
