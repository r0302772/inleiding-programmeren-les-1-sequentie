using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Edit window title
            Console.Title = "Exercise 5";

            //Declare variables
            double degreesCelsius, degreesFahrenheit;

            Console.WriteLine("Convert Celsius to Fahrenheit.");
            Console.WriteLine();
            //Ask the user what is the temperature
            Console.Write("Degrees Celsius: ");
            degreesCelsius = double.Parse(Console.ReadLine());

            //Calculations
            degreesFahrenheit = degreesCelsius * 9 / 5 + 32;

            //Results
            Console.WriteLine();
            //Console.WriteLine(); creates a blank line
            Console.WriteLine("{0} degress Celsius is {1} degrees Fahrenheit.", degreesCelsius, degreesFahrenheit);

            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
