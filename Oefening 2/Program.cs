using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Edit window title
            Console.Title = "Exercise 2";

            //Declare variables
            double priceExcluded, priceIncluded;
            int tax;

            //Ask the user for a price
            Console.Write("Price (tax excluded): ");
            //Read input of the user and put it into a variable
            priceExcluded = double.Parse(Console.ReadLine());
            //double.Parse will convert the input of type string to type double
            Console.Write("Tax-%: ");
            tax = int.Parse(Console.ReadLine());

            //Calculations
            priceIncluded = priceExcluded * tax / 100 + priceExcluded;

            //Results
            Console.WriteLine();
            //Console.WriteLine(); creates a blank line
            Console.WriteLine("Price (tax included): {0}", priceIncluded);
            //Console.WriteLine($"Price (tax included): {priceIncluded}");

            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter

        }
    }
}
