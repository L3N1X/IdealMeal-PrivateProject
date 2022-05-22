using DataLayer.Constants;
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
        public Grocery Grocery { get; private set; }
        public Unit Unit { get; private set; }
        public double Amount { get; set; }
        public Ingridient(Grocery grocery, Unit unit, double amount)
        {
            this.Grocery = grocery;
            this.Unit = unit;
            this.Amount = amount;
        }

        public bool HasEnoughFor(Ingridient target)
            => this.Equals(target) && this.Amount >= target.Amount;

        public string FormatForFileLine()
            => $"{this.Grocery.FormatForFileLine()}{DEL}" +
            $"{this.Unit}{DEL}" +
            $"{this.Amount}";

        public static Ingridient ParseFromFileLine(string line)
        {
            string[] data = line.Split(DEL);
            return new Ingridient
                (
                    Grocery.ParseFromFileLine(data[0]),
                    (Unit) Enum.Parse(typeof(Unit), data[1]), 
                    double.Parse(data[2])
                );
        }

        public override bool Equals(object obj)
        {
            return obj is Ingridient ingridient &&
                   EqualityComparer<Grocery>.Default.Equals(Grocery, ingridient.Grocery) &&
                   Unit == ingridient.Unit;
        }

        public override int GetHashCode()
        {
            int hashCode = 1082803831;
            hashCode = hashCode * -1521134295 + EqualityComparer<Grocery>.Default.GetHashCode(Grocery);
            hashCode = hashCode * -1521134295 + Unit.GetHashCode();
            return hashCode;
        }
    }
}
