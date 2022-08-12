using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Edit window title
            Console.Title = "Exercise 3";

            //Declare variables
            int adultTotal, kidTotal;
            double costAdult = 10.0, costKid = 7.5, costTotal;

            //Ask the user how many adults are coming along
            Console.Write("Total adults: ");
            adultTotal = int.Parse(Console.ReadLine());
            //int.Parse will convert the input of type string to type int
            Console.Write("Total kids: ");
            kidTotal = int.Parse(Console.ReadLine());

            //Calculations
            costAdult *= adultTotal;
            costKid *= kidTotal;

            costTotal = costAdult + costKid;

            //Results
            Console.WriteLine();
            //Console.WriteLine(); creates a blank line
            Console.WriteLine("Total entrance fee: {0}", costTotal);
            //Console.WriteLine($"Total entrance fee: {costTotal}");

            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter

        }
    }
}
