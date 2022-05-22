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
        public Grocery(string name, string description, Nutrition nutrition)
        {
            this.Nutrition = nutrition;
            this.Name = name;
            this.Description = description;
        }

        public string FormatForFileLine()
            => $"{this.Name}{DEL}" +
            $"{this.Description}{DEL}" +
            $"{this.Nutrition.FormatForFileLine()}";

        public static Grocery ParseFromFileLine(string line)
        {
            string[] data = line.Split(DEL);
            return new Grocery(data[0], data[1], Nutrition.ParseFromFileLine(data[2]));
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
