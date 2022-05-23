using DataLayer;
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
    public partial class DefaultForm : Form
    {
        private DataManager dataManager;
        public DefaultForm()
        {
            try
            {
                this.dataManager = new DataManager();    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
            Form dialog = new LoginForm(dataManager);
            var result = dialog.ShowDialog();
            if (!DialogResult.OK.Equals(result))
                Close();
            InitializeComponent();
        }

        private void DefaultForm_Load(object sender, EventArgs e)
        {
            dataManager.GetGroceries().ToList().ForEach(grocery => this.flpGroceries.Controls.Add(new GroceryControl(grocery)));
        }

        private void pbCreateGrocery_MouseHover(object sender, EventArgs e)
        {
            this.ttCreateGrocery.Show("Dodaj novu namrinicu", sender as Control);
        }
    }
}
