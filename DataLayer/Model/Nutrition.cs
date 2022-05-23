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

        public static Nutrition operator +(Nutrition left, Nutrition right)
        {
            return new Nutrition
            {
                Calories =      left.Calories + right.Calories,
                Fat =           left.Fat + right.Fat,
                Carbs =         left.Carbs + right.Carbs,
                Protein =       left.Protein + right.Protein,
                Cholesterol =   left.Cholesterol + right.Cholesterol,
                Sodium =        left.Sodium + right.Sodium,
                Calcium =       left.Calcium + right.Calcium,
                Iron =          left.Iron + right.Iron
            };
        }

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
                $"{this.Fat}{DEL}" +
                $"{this.Carbs}{DEL}" +
                $"{this.Protein}{DEL}" +
                $"{this.Cholesterol}{DEL}" +
                $"{this.Sodium}{DEL}" +
                $"{this.Calcium}{DEL}" +
                $"{this.Iron}";

        public static Nutrition ParseFromFileLine(string line)
        {
            string[] data = line.Split(DEL);
            return new Nutrition
            {
                Calories = double.Parse(data[0]),
                Fat = double.Parse(data[1]),
                Carbs = double.Parse(data[2]),
                Protein = double.Parse(data[3]),
                Cholesterol = double.Parse(data[4]),
                Sodium = double.Parse(data[5]),
                Calcium = double.Parse(data[6]),
                Iron = double.Parse(data[7]),
            };
        }
    }
}
