using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Edit window title
            Console.Title = "Exercise 4";

            //Declare variables
            int totalZonalCalls, totalInterzonalCalls, totalCalls;
            double costEx, taxFee, totalCost;

            //Ask the user how many zonal calls were made
            Console.Write("Total zonal calls: ");
            totalZonalCalls = int.Parse(Console.ReadLine());
            Console.Write("Total interzonal calls: ");
            totalInterzonalCalls = int.Parse(Console.ReadLine());

            //Calculations
            totalCalls = totalZonalCalls + totalInterzonalCalls;
            //Per zonal or interzonal call you have to pay 0,12-€ plus a fixed amount of €23.
            costEx = totalCalls * 0.12 + 23;
            //Currently the tax rate is 21%.
            taxFee = costEx * 21 / 100;

            totalCost = costEx + taxFee;

            //Results
            Console.WriteLine();
            //Console.WriteLine(); creates a blank line
            Console.WriteLine("Totaalbedrag: {0}", totalCost);

            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
