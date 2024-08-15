using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class BMI
    {
        public static void bmiExercise()
        {
            //Body Mass Index
            Console.WriteLine("Enter your weight in kilograms: ");
            var weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height in meters: ");
            var height = Convert.ToDouble(Console.ReadLine());

            var bmi = calculateBMI(weight, height);
            Console.WriteLine("Body Mass Index: " + bmi);
            Console.WriteLine("BMI: Category: " + getCategory(bmi));

        }

        static double calculateBMI(double weight, double height)
        {
            return weight /(height*height); 
        }

        static string getCategory(double bmi)
        {
            if (bmi < 18.5)
                return "Underweight";
            if (bmi < 24.9)
                return "Normal";
            if (bmi < 29.9)
                return "Overweight";
            else
                return "Obesity";
        }
    }
}
