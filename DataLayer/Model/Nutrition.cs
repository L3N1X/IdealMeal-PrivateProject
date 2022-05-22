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
        public const Constants.Unit MEASURING_UNIT = Constants.Unit.g;
        public double Calories { get; set; }
        public double Fat { get; set; }
        public double Carbs { get; set; }
        public double Protein { get; set; }
        public double Cholesterol { get; set; }
        public double Sodium { get; set; }
        public double Calcium { get; set; }
        public double Iron { get; set; }

        public double GetPercentageOfDailyIntake()
            => this.Calories / Nutrition.RecomendedDailyIntake;

        public override string ToString()
            =>  $"Calories: {this.Calories}" +
                $" Fat: {this.Fat}{MEASURING_UNIT}" +
                $" Carbs: {this.Carbs}{MEASURING_UNIT}" +
                $" Protein: {this.Protein}{MEASURING_UNIT}" +
                $" Cholesterol: {this.Cholesterol}{MEASURING_UNIT}" +
                $" Sodium: {this.Sodium}{MEASURING_UNIT}" +
                $" Calcium: {this.Calcium}{MEASURING_UNIT}" +
                $" Iron: {this.Iron}{MEASURING_UNIT} ";

        public string FormatForFileLine()
            => $"{this.Calories}{DEL}" +
                $"{this.Fat}{MEASURING_UNIT}{DEL}" +
                $"{this.Carbs}{MEASURING_UNIT}{DEL}" +
                $"{this.Protein}{MEASURING_UNIT}{DEL}" +
                $"{this.Cholesterol}{MEASURING_UNIT}{DEL}" +
                $"{this.Sodium}{MEASURING_UNIT}{DEL}" +
                $"{this.Calcium}{MEASURING_UNIT} {DEL}" +
                $"{this.Iron}{MEASURING_UNIT}";

        public static Nutrition ParseFromFileLine(string line)
        {
            string[] data = line.Split(DEL);
            return new Nutrition
            {
                Calories = double.Parse(data[1]),
                Fat = double.Parse(data[2]),
                Carbs = double.Parse(data[3]),
                Protein = double.Parse(data[4]),
                Cholesterol = double.Parse(data[5]),
                Sodium = double.Parse(data[6]),
                Calcium = double.Parse(data[7]),
                Iron = double.Parse(data[8]),
            };
        }
    }
}
