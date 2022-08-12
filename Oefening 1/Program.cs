using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Edit screencolors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            //Reset console
            Console.Clear();

            //Edit window title
            Console.Title = "Exercise 1";

            //Declare variables
            int number1, number2, number3, number4, sum, product;

            //Ask the user for the first number
            Console.Write("Give a first number: ");
            //Read input of the user and put it into a variable
            number1 = int.Parse(Console.ReadLine());
            //int.Parse will convert the input of type string to type integer

            //Ask the user for the first number
            Console.Write("Give a second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Give a third number: ");
            number3 = int.Parse(Console.ReadLine());

            Console.Write("Give a fourth number: ");
            number4 = int.Parse(Console.ReadLine());

            //Calculations
            sum = number1 + number3;
            product = number2 * number4;

            //Results
            Console.WriteLine();
            //Console.WriteLine(); creates a blank line
            Console.WriteLine("The sum of {0} and {1} is {2}", number1, number3, sum);

            Console.WriteLine("The product of " + number2.ToString() + " and " + number4.ToString() + " is " + product.ToString());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
