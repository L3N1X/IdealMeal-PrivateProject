using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Recepie
    {
        public const char DEL = '|';
        public const char INGRIDIENTS_LIST_DEL = ',';
        public string Name { get; private set; }
        public string Description { get; private set; }
        public IList<Ingridient> Ingridients { get; private set; } //SET?
        public string ImagePath { get; set; } = string.Empty;
        public Nutrition Nutrition 
        {
            get
            {
                var totalNutrition = new Nutrition();
                foreach (var ingridient in Ingridients)
                    totalNutrition = totalNutrition + ingridient.Grocery.Nutrition;
                return totalNutrition;
            } 
        }
        public Recepie(string name, string description, IList<Ingridient> ingridients)
        {
            this.Name = name;
            this.Description = description;
            this.Ingridients = ingridients;
        }

        public bool CanMakeWithGivenIngridients(IList<Ingridient> avaliableIngridients)
        {
            int ingridentsValid = 0;
            foreach (var ingridient in this.Ingridients)
            {
                foreach (var avaliableIngridient in avaliableIngridients)
                {
                    if (ingridient.Equals(avaliableIngridient) 
                        && ingridient.Amount <= avaliableIngridient.Amount)
                        ingridentsValid++;
                }
            }
            return ingridentsValid.Equals(this.Ingridients.Count);
        }

        public string FormatForFileLine()
        {
            StringBuilder sb = new StringBuilder();
            sb
                .Append(this.Name)
                .Append(DEL)
                .Append(this.Description)
                .Append(DEL)
                .Append(this.ImagePath)
                .Append(DEL);
            foreach (var ingridient in this.Ingridients)
            {
                sb.Append(ingridient.FormatForFileLine());
                if (this.Ingridients.IndexOf(ingridient) == this.Ingridients.Count - 1)
                    break;
                sb.Append(INGRIDIENTS_LIST_DEL);
            }
            return sb.ToString();
        }

        public static Recepie ParseFromFileLine(string line)
        {
            string[] data = line.Split(DEL);
            string name = data[0];
            string description = data[1];
            string imagePath = data[2];
            string[] ingridentsData = data[3].Split(INGRIDIENTS_LIST_DEL);
            IList<Ingridient> ingridients = new List<Ingridient>();

            foreach (var ingridientRaw in ingridentsData)
                ingridients.Add(Ingridient.ParseFromFileLine(ingridientRaw));

            return new Recepie(name, description, ingridients);
        }

        public override bool Equals(object obj)
        {
            return obj is Recepie recepie &&
                   Name == recepie.Name;
        }

        public override int GetHashCode()
        {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
        }
    }
}
