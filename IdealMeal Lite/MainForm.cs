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
    public partial class MainForm : Form
    {
        public List<Recepie> AllRecepies { get; set; } = new List<Recepie>();
        public List<Grocery> AllGroceries { get; set; } = new List<Grocery>();
        public List<Ingridient> SelectedIngridients { get; set; } = new List<Ingridient>(); 
        public MainForm()
        {
            //ovo je konstruktor naše glavne forme, on se odvrti samo jednom u životnom ciklusu aplikacije. 
            //To je savršeno mjesto gdje ćemo mi napraviti par namirnica i jedan recept, kako korisnika nebi dočekala prazna aplikacija.
            //Tu ćemo kreirati sve da u aplikaciji postoji jedan recept (kikiriki maslac sendvič i namirnice: kikiriki maslac, pekmez, i pecivo)

            //Ovdje kreiramo recept koji je uvijek pohranjem u aplikaciji
            Grocery peanutButter = new Grocery("Kikiriki maslac", 590);
            Grocery jam = new Grocery("Pekmez", 180);
            Grocery toast = new Grocery("Pecivo", 195);

            //Kreiramo od namirnica sastojke kako bi napravili kikiriki maslac sendvič recept (to je jedini recept spremljen u aplikaciji)
            Ingridient peanutButter_ingridient = new Ingridient(peanutButter, 20);
            Ingridient jam_ingridient = new Ingridient(jam, 35);
            Ingridient toast_ingridient = new Ingridient(toast, 220);
            
            //Spremamo sve ove namrinice u popis svih namirnica, to su jedine namirnice koje možemo odabrati u aplikaciji, dok ne dodamo nove sami!
            AllGroceries.Add(peanutButter);
            AllGroceries.Add(jam);
            AllGroceries.Add(toast);

            //Kreiramo listu sastojaka za kikiriki maslac sendvič i dodajemo sve sastojke, kako bi mogli naoraviti recept
            List<Ingridient> peanutButterSandwichIngridients = new List<Ingridient>();
            peanutButterSandwichIngridients.Add(peanutButter_ingridient);
            peanutButterSandwichIngridients.Add(jam_ingridient);
            peanutButterSandwichIngridients.Add(toast_ingridient);

            Recepie peanutButterAndJellySandwich = new Recepie("Kikiriki maslac sendvič", "Uzmi kruh namaži kikiriki maslac", peanutButterSandwichIngridients); //receptu trebamo proslijediti listu sastojaka kako bi se kreirao


            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Prilikom loadanja forme, za svaku postojeću namirnicu, kreiramo svoju custom (GroceryControl) kontrolu i dodajemo ih u panel zaslužan za popis svih mogućih namirnica.
            //GroceryControl je kontrola koju smo mi sami dizajnirali i rekli da u sebi sadrži pohranjenu namirnicu i onda na ekran ispisuje naziv te namirnice kalorije i sliku. 
            //Služi samo da je korisniku intiutivno za gledati namirnice, umjesto da samo vidi neku listu namirnica (tekstualnu).
            foreach (Grocery grocery in AllGroceries)
            {
                //Za svaku namrinicu kreiramo kontrolu, proslijeđujemo namirnicu svakoj kontroli
                GroceryControl groceryControl = new GroceryControl(grocery);

                groceryControl.ContextMenuStrip = ContextMenuStripGrocery; //Svakoj kontroli dajemo ovaj naš izbornik koji se pojavljuje desnim klikom miša. Na taj način znamo da korisnik želi od te namirnice kreirati sastojak

                //Dodajemo tu kontrolu u panel za popis svih namirnica
                flpGroceries.Controls.Add(groceryControl); //Vidite ovaj .Controls? to je lista kontrola koje ovaj panel ima, mi u tu njegovu listu samo ubacijemo svoje ove kontrole.
            }
        }

        //Sada kliknutu namrinicu želimo dodati kao sastojak, od kojeg ćemo ili napraviti novi recept ili ćemo pretraživati recepte
        private void btnAddIngridient(object sender, EventArgs e)
        {
            //Klinuti je gumb koji je dio "ContextMenuStripGrocery" ContextMenuStrip je posebna kontrola koja sluša svaku GroceryControl, ima posebno svojstvo
            GroceryControl clickedGroceryControl = (GroceryControl)ContextMenuStripGrocery.SourceControl; //Ima svojstvo koje kaže "koja kontrola je bila kliknuta i mene je pozvala"
            Grocery clickedGrocery = clickedGroceryControl.Grocery; //vadimo namirnicu iz naše custom kontrole (GroceryControl u sebi sadrži namirnicu (Grocery))
            //Kreiramo formu za dodavanje sastojka, i pokazujemo je na ekran. Ne koristimo metodu show, već koristimo metodu ShowDialog, jer onda korisnik ne može kliknuti ništa izvan forme
            AddIngridientForm AddIngridientForm = new AddIngridientForm(clickedGrocery);
            AddIngridientForm.ShowDialog();
            //Ako se sastojak kreirao, dodaj ga u popis sastojaka
            if(AddIngridientForm.Ingridient != null) //!= znači da "nije ne postojan"
            {
                Ingridient newIngridient = AddIngridientForm.Ingridient;
                //Kreiramo kontrolu za sastojak, isto kako i imamo za namirnicu
                IngridientControl ingridientControl = new IngridientControl(newIngridient);
                //Dodajemo ju u panel sastojka koje imamo doma
                flpIngridients.Controls.Add(ingridientControl);
            }
        }

        private void pbCreateGrocery_Click(object sender, EventArgs e)
        {
            CreateGroceryForm createGroceryForm = new CreateGroceryForm();
            createGroceryForm.ShowDialog();
            //Ako se namirnica kreirala, dodaj je u popis namirnica
            if (createGroceryForm.Grocery != null) //!= znači da "nije ne postojan"
            {
                Grocery newGrocery = createGroceryForm.Grocery;
                //Kreiramo kontrolu za namrinicu, isto kako i imamo za sastojak
                GroceryControl groceryControl = new GroceryControl(newGrocery);
                //Dodjeljujemo joj kontrkstni izbornik
                groceryControl.ContextMenuStrip = ContextMenuStripGrocery;
                //Dodajemo ju u panel sastojka koje imamo doma
                flpGroceries.Controls.Add(groceryControl);
            }
        }

        //private void FillRecepiesPanel(IList<Ingridient> ingridients)
        //{
        //    this.flpRecepies.Controls.Clear();
        //    this.dataManager.GetValidRecepies(ingridients).ToList().ForEach(recepie => this.flpRecepies.Controls.Add(new RecepieControl(recepie)));
        //}

        //private void pbCreateGrocery_MouseHover(object sender, EventArgs e)
        //{
        //    this.ttCreateGrocery.Show("Dodaj novu namrinicu", sender as Control);
        //}

        //private void FillAndResetGroceriesPanel()
        //{
        //    this.flpGroceries.Controls.Clear();
        //    dataManager.GetGroceries().ToList().ForEach(grocery =>
        //    {
        //        GroceryControl groceryControl = new GroceryControl(grocery);
        //        groceryControl.GroceryAddedToHome += GroceryControl_GroceryAddedToHome;
        //        groceryControl.GroceryRemovedFromHome += GroceryControl_GroceryRemovedFromHome;
        //        this.flpGroceries.Controls.Add(groceryControl);

        //    });
        //}

        //private void GroceryControl_GroceryRemovedFromHome(object sender, EventArgs args)
        //{
        //    this.flpHomeGroceries.Controls.Remove(((Control)sender));
        //}

        //private void GroceryControl_GroceryAddedToHome(object sender, EventArgs args)
        //{
        //    Grocery grocery = ((GroceryControl)sender).Grocery;
        //    //GroceryControl groceryControl = new GroceryControl(grocery, isHomeGrocery: true);
        //    //groceryControl.GroceryRemovedFromHome += GroceryControl_GroceryRemovedFromHome;
        //    //this.flpHomeGroceries.Controls.Add(groceryControl);

        //    AddIngridientForm dialog = new AddIngridientForm(grocery);
        //    dialog.ShowDialog();
        //    if (dialog.Ingridient == null)
        //        return;
        //    IngridientControl ingridientControl = new IngridientControl(dialog.Ingridient);
        //    ingridientControl.IngridentRemoved += IngridientControl_IngridentRemoved;
        //    this.flpHomeGroceries.Controls.Add(ingridientControl);
        //}

        //private void IngridientControl_IngridentRemoved(object sender, EventArgs args)
        //{
        //    throw new NotImplementedException();
        //}

        //private void pbCreateGrocery_Click(object sender, EventArgs e)
        //{
        //    CreateGroceryForm dialog = new CreateGroceryForm();
        //    dialog.ShowDialog();
        //    if (dialog.Grocery == null)
        //        return;
        //    try
        //    {
        //        dataManager.CreateGrocery(dialog.Grocery);
        //        GroceryControl groceryControl = new GroceryControl(dialog.Grocery);
        //        groceryControl.GroceryAddedToHome += GroceryControl_GroceryAddedToHome;
        //        this.flpGroceries.Controls.Add(new GroceryControl(dialog.Grocery));
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void MainTab_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnCreateRecepie_Click(object sender, EventArgs e)
        //{
        //    if (this.flpHomeGroceries.Controls.Count == 0)
        //    {
        //        MessageBox.Show("Molimo vas da odaberete namirnice za recept");
        //        return;
        //    }

        //    IList<Ingridient> ingridients = new List<Ingridient>();
        //    foreach (var control in this.flpHomeGroceries.Controls)
        //        ingridients.Add(((IngridientControl)control).Ingridient);

        //    CreateRecepieForm dialog = new CreateRecepieForm(ingridients);
        //    dialog.ShowDialog();
        //    if (dialog.Recepie == null)
        //        return;
        //    try
        //    {
        //        dataManager.CreateRecepie(dialog.Recepie);
        //        this.flpHomeGroceries.Controls.Clear();
        //        MessageBox.Show($"Recept: {dialog.Recepie.Name} je uspješno dodan!");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void btnSearchRecepie_Click(object sender, EventArgs e)
        //{
        //    IList<Ingridient> ingridients = new List<Ingridient>();
        //    foreach (var control in this.flpHomeGroceries.Controls)
        //    {
        //        ingridients.Add(((IngridientControl)control).Ingridient);
        //    }
        //    this.FillRecepiesPanel(ingridients);
        //    if (this.flpRecepies.Controls.Count == 0)
        //        MessageBox.Show("Nismo pronašli niti jedan recept:(");
        //}
    }
}
