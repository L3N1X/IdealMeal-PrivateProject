using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    //Ova klasa predstavlja objekt namrinicu
    public class Grocery
    {
        //Namrinica ima
        //Svoj naziv
        public string Name { get; set; }
        //Broj kalorija (pretvaramo se da je to kao broj kalorija na 100 grama)
        public int Calories { get; set; }
        //Konstruktor: Namrinicu ne možemo kreirati bez da joj damo ime i broj kalorija
        public Grocery(string name, int calories)
        {
            Calories = calories;
            Name = name;
        }

        //Ovaj kod je generirao Visual Studio
        public override bool Equals(object obj)
        {
            return obj is Grocery grocery &&
                   Name == grocery.Name;
        }

        public override int GetHashCode()
        {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
        }
        //Ovaj kod je generirao Visual Studio
    }
}
