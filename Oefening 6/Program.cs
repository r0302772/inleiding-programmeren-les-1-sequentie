using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Edit window title
            Console.Title = "Exercise 6";

            //Declare variables
            double weight, length, wrist, idealWeight;

            //Ask the user for his/her measurements
            Console.Write("Weight in kilogram -> ");
            weight = double.Parse(Console.ReadLine());
            Console.Write("Length in centimeter -> ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Wrist circumference in centimeter -> ");
            wrist = double.Parse(Console.ReadLine());

            //Calculations
            idealWeight = (length + 4 * wrist - 100) / 2;

            //Results
            Console.WriteLine();
            //Console.WriteLine(); creates a blank line
            Console.WriteLine($"Ideal weigth: {idealWeight}");

            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
