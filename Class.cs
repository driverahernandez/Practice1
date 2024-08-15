using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Class
    {

        List<Double> grades = new List<Double>();
        
        public void inputGrades()
        {
            while(true){
                Console.WriteLine("Type in the grade or press enter to finish:");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                grades.Add(Convert.ToDouble(input)); 
            }
        }

        public double calculateAverage()
        {
            return grades.Count > 0 ? grades.Average() : 0.0;
        }
        public double getMaxGrade()
        {
            return grades.Max();
        }
        public double getMinGrade()
        {
            return grades.Min();
        }


    }
}
