using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Nutrition
    {
        public static double RecomendedDailyIntake = 2000;
        public const char DEL = '#';
        public double Calories { get; set; }
        public double Fat { get; set; }
        public double Carbs { get; set; }
        public double Protein { get; set; }

        public double GetPercentageOfDailyIntake()
            => this.Calories / Nutrition.RecomendedDailyIntake;

        public static Nutrition operator +(Nutrition left, Nutrition right)
        {
            return new Nutrition
            {
                Calories =      left.Calories + right.Calories,
                Fat =           left.Fat + right.Fat,
                Carbs =         left.Carbs + right.Carbs,
                Protein =       left.Protein + right.Protein,
            };
        }

        public static Nutrition operator *(Nutrition nutrition, double grams)
        {
            return new Nutrition
            {
                Calories =      nutrition.Calories * grams,
                Fat =           nutrition.Fat * grams,
                Carbs =         nutrition.Carbs * grams,
                Protein =       nutrition.Protein * grams
            };
        }

        public override string ToString()
            => $"Calories: {this.Calories}" +
                $" Fat: {this.Fat}" +
                $" Carbs: {this.Carbs}" +
                $" Protein: {this.Protein}";

        public string FormatForFileLine()
            => $"{this.Calories}{DEL}" +
                $"{this.Fat}{DEL}" +
                $"{this.Carbs}{DEL}" +
                $"{this.Protein}";

        public static Nutrition ParseFromFileLine(string line)
        {
            string[] data = line.Split(DEL);
            return new Nutrition
            {
                Calories = double.Parse(data[0]),
                Fat = double.Parse(data[1]),
                Carbs = double.Parse(data[2]),
                Protein = double.Parse(data[3])
            };
        }
    }
}
