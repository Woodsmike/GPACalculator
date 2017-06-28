using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is my GPA?");
            Console.WriteLine("Please state how many of each grade you received.");
            Console.WriteLine("How many A's?");
            double gradeA = double.Parse(Console.ReadLine());
            Console.WriteLine("How many B's?");
            double gradeB = double.Parse(Console.ReadLine());
            Console.WriteLine("How many C's?");
            double gradeC = double.Parse(Console.ReadLine());
            Console.WriteLine("How many D's?");
            double gradeD = double.Parse(Console.ReadLine());
            Console.WriteLine("How many F's?");
            double gradeF = double.Parse(Console.ReadLine());

            double totalGPA = ((gradeA * 4) + (gradeB * 3) + (gradeC * 2) + (gradeD * 1) + (gradeF * 0));
            double totalGrades = (gradeA + gradeB + gradeC + gradeD + gradeF);
            double GPA = (totalGPA / totalGrades);

            Console.WriteLine("Your GPA: " + GPA);

        }
    }
}
