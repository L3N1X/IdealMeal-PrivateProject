using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    //Ova klasa predstavlja objekt sastojak
    public class Ingridient
    {
        //Sastojak ima:

        //Namrinicu npr: spagetti
        public Grocery Grocery { get; set; }
        //I danu kolicinu, mi se pretvaramo da su ovo grami, double jer zelimo imati decimalna mjesta
        public double Amount { get; set; }
        
        //Konstruktor: sastojak se ne može generirati bez da mu proslijedimo namirnicu i količinu (opet, glumimo da su to grami, ne znamo bolje)
        public Ingridient(Grocery grocery, double amount)
        {
            Grocery = grocery;
            Amount = amount;
        }

        //Ovo je generirao Visual Studio
        public override bool Equals(object obj)
        {
            return obj is Ingridient ingridient &&
                   EqualityComparer<Grocery>.Default.Equals(Grocery, ingridient.Grocery);
        }

        public override int GetHashCode()
        {
            return -676798384 + EqualityComparer<Grocery>.Default.GetHashCode(Grocery);
        }
        //Ovo je generirao Visual Studio
    }
}
