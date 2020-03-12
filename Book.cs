using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        List<double> grades;
        string name;

        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            if (grade >= 0 || grade <= 100)
            {
                grades.Add(grade);
            }
        }

        public double HighestGrade()
        {
            var highGrade = double.MinValue;
            foreach (var grade in grades)
            {
                highGrade = Math.Max(highGrade, grade);
            }
            return highGrade;
        }

        public double LowestGrade()
        {
            var lowGrade = double.MaxValue;
            foreach (var grade in grades)
            {
                lowGrade = Math.Min(lowGrade, grade);
            }
            return lowGrade;
        }

        public double AvgGrade()
        {
            var total = 0.0;
            foreach (var grade in grades)
            {
                total += grade;
            }
            var result = total / grades.Count;
            return result;
        }
    }
}