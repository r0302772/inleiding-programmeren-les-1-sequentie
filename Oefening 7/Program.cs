using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Edit window title
            Console.Title = "Exercise 7";

            //Declare variables
            string redBox, blueBox, extraBox;

            //Ask the user to give the contents of the boxes
            Console.Write("Enter the contents of the red box: ");
            redBox = (Console.ReadLine());
            Console.Write("Enter the contents of the blue box: ");
            blueBox = (Console.ReadLine());

            //Calculations
            extraBox = redBox;
            redBox = blueBox;
            blueBox = extraBox;

            //Results
            Console.WriteLine();
            //Console.WriteLine(); creates a blank line
            Console.WriteLine("The new value of the red box is {0} and the blue box is {1}.", redBox, extraBox);

            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
