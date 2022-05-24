using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Ingridient
    {
        public const char DEL = ';';
        private double amount;

        public Grocery Grocery { get; private set; }
        public double Amount { get => amount; set => amount = value; }
        private Nutrition nutrition;
        public Nutrition Nutrition
        {
            get
            {
                double hundreth = amount / 100.0;
                return nutrition * hundreth;
            }
        }
        public Ingridient(Grocery grocery, double amount)
        {
            this.Grocery = grocery;
            this.Amount = amount;
        }

        public string FormatForFileLine()
            => $"{this.Grocery.FormatForFileLine()}{DEL}" +
            $"{this.Amount}";

        public static Ingridient ParseFromFileLine(string line)
        {
            string[] data = line.Split(DEL);
            return new Ingridient
                (
                    Grocery.ParseFromFileLine(data[0]),
                    double.Parse(data[1])
                );
        }

        public override bool Equals(object obj)
        {
            return obj is Ingridient ingridient &&
                   EqualityComparer<Grocery>.Default.Equals(Grocery, ingridient.Grocery);
        }

        public override int GetHashCode()
        {
            return -676798384 + EqualityComparer<Grocery>.Default.GetHashCode(Grocery);
        }
    }
}
