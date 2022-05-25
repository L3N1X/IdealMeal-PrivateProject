using System;
using System.Windows.Forms;

namespace IdealMeal_Lite
{
    public partial class CreateGroceryForm : Form
    {
        public Grocery Grocery { get; set; }
        public CreateGroceryForm()
        {
            InitializeComponent();
        }

        private void btnCreateGrocery_Click(object sender, EventArgs e)
        {
            string name = this.txtName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Navedite naziv namirnice");
                return;
            }
            int calories = (int)nudKcal.Value;
            Grocery = new Grocery(name, calories);
            this.Close();
        }
    }
}
