using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Basics!");
            Console.WriteLine(@"

    *************
    Calculator
    *************

             ");

            Console.WriteLine("What would you like to do today?  Type in * if you would like to multiply and ^ if you would like to square the list of numbers:");
            var mathMethodToUse = Console.ReadLine();

            // Squares
            if (mathMethodToUse == "^")
            {
                Console.WriteLine("Please enter some numbers you would like to square separated by a comma (NO SPACES!)");
                var numbersToSquareString = Console.ReadLine();
                var numberToSquareList = numbersToSquareString.Split(",");

                var squareOutput = "";

                foreach (var number in numberToSquareList)
                {
                    var numToSquare = int.Parse(number);
                    var result = numToSquare * numToSquare;
                    squareOutput += ($"{result.ToString()},");
                }

                squareOutput = squareOutput.Remove(squareOutput.Length - 1);

                Console.WriteLine($"Result is: {squareOutput}");
            }
            else if (mathMethodToUse == "*")
            {


                // Multiplication

                Console.WriteLine("Please enter some numbers you would like to multiply separated by a comma (NO SPACES!):");
                var numberStringInput = Console.ReadLine();

                string[] numberStringList = numberStringInput.Split(",");

                var finalOutput = 0;

                foreach (var numberString in numberStringList)
                {
                    var result = int.Parse(numberString);
                    if (finalOutput == 0)
                    {
                        finalOutput = result;
                    }
                    else
                    {
                        finalOutput *= result;
                    }
                }
                Console.WriteLine($"The final result is:  {finalOutput}");
            }
            else
            {
                Console.WriteLine("You did not enter a valid character, sorry, no math for you today...");
            }

            Console.ReadLine();
        }
    }
}
