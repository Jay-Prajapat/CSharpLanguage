using System;
using System.Collections.Generic;


namespace CSharpBasics
{
    internal class Book
    {
        public Book(string name) { 
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void showStatstics()
        {
           
            var result = 0.0;
            var avgGrade = 0.0;
            var totalGrade = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (var number in grades)
            {
                lowGrade = Math.Min(lowGrade, number);
                highGrade = Math.Max(highGrade, number);
                result += number;
            }
            
            avgGrade = result / grades.Count;
            Console.WriteLine($"Hightst grade is {highGrade}");
            Console.WriteLine($"Lowest grade is {lowGrade}");

            Console.WriteLine($"Average Grede is {avgGrade}.");
            
        }

        private List<double> grades;
        private string name;
    }
}
