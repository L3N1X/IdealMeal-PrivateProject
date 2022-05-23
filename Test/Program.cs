using DataLayer;
using DataLayer.Constants;
using DataLayer.Model;
using DataLayer.Repositories.Factories;
using DataLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nutrition pecivo_nutrition = new Nutrition() { Calories = 100};
            Nutrition pekmez_nutrition = new Nutrition() { Calories = 50 };

            Grocery pecivo = new Grocery("pecivo", "mlinar", pecivo_nutrition);
            Grocery pekmez = new Grocery("pekmez", "julius", pekmez_nutrition);

            //Recept
            Ingridient sastojak_pecivo = new Ingridient(pecivo, Unit.g, 250);
            Ingridient sastojak_pekmez = new Ingridient(pekmez, Unit.g, 25);
            Recepie rein_sendvic = new Recepie("rein senvdic", "fini", new List<Ingridient>{ sastojak_pekmez, sastojak_pecivo });
            //Recept
               
            //Privremeni recept
            Ingridient moje_pecivo = new Ingridient(pecivo, Unit.g, 250);
            Ingridient moj_pekmez = new Ingridient(pekmez, Unit.g, 50);
            //Privremeni recept

            Console.WriteLine(rein_sendvic.CanMakeWithGivenIngridients(new List<Ingridient> { moje_pecivo, moj_pekmez }));

            Irepo repo = RepoFactory.GetRepo();
            var recepie = repo.GetRecepies()[0];
            Console.WriteLine($"{recepie.Name} Calories: {recepie.Nutrition.Calories}");
        }
    }
}
