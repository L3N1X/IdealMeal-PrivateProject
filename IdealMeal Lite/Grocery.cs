using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Grocery
    {
        public const char DEL = '/';
        public string Name { get; private set; }
        public string Description { get; private set; }
        public Nutrition Nutrition { get; private set; }

        public string ImagePath { get; set; } = string.Empty;
        public Grocery(string name, string description, Nutrition nutrition)
        {
            this.Nutrition = nutrition;
            this.Name = name;
            this.Description = description;
        }

        public string FormatForFileLine()
            => $"{this.Name}{DEL}" +
            $"{this.Description}{DEL}" +
            $"{this.ImagePath}{DEL}"+
            $"{this.Nutrition.FormatForFileLine()}";

        public static Grocery ParseFromFileLine(string line)
        {
            string[] data = line.Split(DEL);
            Grocery grocery = new Grocery(name: data[0], description: data[1], nutrition: Nutrition.ParseFromFileLine(data[3]));
            grocery.ImagePath = data[2];
            return grocery;
        }

        public override bool Equals(object obj)
        {
            return obj is Grocery grocery &&
                   Name == grocery.Name;
        }

        public override int GetHashCode()
        {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
        }
    }
}
