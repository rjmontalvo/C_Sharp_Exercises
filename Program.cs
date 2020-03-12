using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradeBook;

namespace CSharp_Coding_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("My Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            Console.WriteLine(book.AvgGrade());
            Console.WriteLine(book.LowestGrade());
            Console.WriteLine(book.HighestGrade());
        }
    }
}
