using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    //Ova klasa predstavlja objekt recept (objekt je instancirana klasa)
    public class Recepie
    {
        //Naziv recepta
        public string Name { get; set; }
        //Opis recepta
        public string Description { get; set; }
        //Lista svih Sastojaka u ovom receptu
        public List<Ingridient> Ingridients { get; set; }
        //Konstruktor, recept se ne može generirati
        public Recepie(string name, string description, List<Ingridient> ingridients)
        {
            this.Name = name;
            this.Description = description;
            this.Ingridients = ingridients;
        }

        //Ova funkcija provjerava da li se ovaj odredeni recept može napraviti sa danim sastojcima
        public bool CanMakeWithGivenIngridients(IList<Ingridient> avaliableIngridients)
        {
            int ingridentsValid = 0;
            //Za svaki sastojak ovog recepta
            foreach (var ingridient in Ingridients)
            {
                //Za svaki sastojak koji smo proslijedili receptu koje on mora provjeriti
                foreach (var avaliableIngridient in avaliableIngridients)
                {
                    //Ako je dani sastojak jednak sastojku recepta i tog danog sastojka ima vise ili jednako nego sastojka u receptu
                    if (ingridient == avaliableIngridient && ingridient.Amount <= avaliableIngridient.Amount)
                    {
                        //Dodaj jedan broju valjanih sastojaka
                        ingridentsValid = ingridentsValid + 1;
                    }
                }
            }
            //Ako je broj valjanih sastojaka recepta jednak broju sastojaka u receptu
            if(ingridentsValid == Ingridients.Count)
            {
                //Moze se napraviti ovaj recept
                return true;
            }
            else
            {
                //Ne moze
                return false;
            }
        }
        
        //Ova funkcija vraca ukupni broj kalorija ovog recepta, prolazi svaki sastojak i zbraja kalorije
        public int GetTotalCalories()
        {
            //Ukupni broj kalorija
            int totalCalories = 0;
            //Za svaki sastojak u sastojcima ovog recepta
            foreach (var ingridient in Ingridients)
            {
                //Zbroji kalorije (kalorije svakog sastojka se nalaze u njegovoj namirnici)
                totalCalories = totalCalories + ingridient.Grocery.Calories;
            }
            return totalCalories;
        }

        //Ovo je generirao Visual Studio
        public override bool Equals(object obj)
        {
            return obj is Recepie recepie &&
                   Name == recepie.Name;
        }

        public override int GetHashCode()
        {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
        }
        //Ovo je generirao Visual Studio
    }
}
