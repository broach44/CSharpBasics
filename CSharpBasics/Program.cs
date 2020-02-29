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

            Console.WriteLine(@"
    What would you like to do today?

    Type in a character for type of math you would like to use.  
    * = Multiply all numbers together
    ^ = Square each number in list
    + = Add the string of numbers
    - = Subtract the numbers
    / = Divide the numbers
 
    ");
            var mathMethodToUse = Console.ReadLine();

            Console.WriteLine("Enter the numbers you want to use, separate with commas (**NO SPACES!**)");
            var numbersToMathString = Console.ReadLine();
            var numberToMathList = numbersToMathString.Split(",");

            switch (mathMethodToUse)
            {
                // Squares
                case "^":
                    var squareOutput = "";

                    foreach (var num in numberToMathList)
                    {
                        var numToSquare = int.Parse(num);
                        var result = numToSquare * numToSquare;
                        squareOutput += ($"{result.ToString()},");
                    }

                    squareOutput = squareOutput.Remove(squareOutput.Length - 1);

                    Console.WriteLine($"Result is: {squareOutput}");
                    break;

                // Multiply
                case "*":
                    var finalOutput = 0;

                    foreach (var numberString in numberToMathList)
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
                    Console.WriteLine($"Result is:  {finalOutput}");
                    break;

                // Addition
                case "+":
                    var additionOutput = 0;

                    foreach (var numberString in numberToMathList)
                    {
                        additionOutput += int.Parse(numberString);
                    }
                    Console.WriteLine($"Result is: {additionOutput}");
                    break;

                // Subtraction
                case "-":
                    var subtractionOutput = 0;
                    foreach (var numberString in numberToMathList)
                    {
                        if (subtractionOutput == 0)
                        {
                            subtractionOutput = int.Parse(numberString);
                        }
                        else
                        {
                            subtractionOutput -= int.Parse(numberString);
                        }
                    
                    }
                    Console.WriteLine($"Result is: {subtractionOutput}");
                    break;

                // Division
                case "/":
                    var divisionOutput = 0;
                    foreach (var numberString in numberToMathList)
                    {
                        if (divisionOutput == 0)
                        {
                            divisionOutput = int.Parse(numberString);
                        }
                        else
                        {
                            divisionOutput /= int.Parse(numberString);
                        }
                    }
                    Console.WriteLine($"Result is: {divisionOutput}");
                    break;

                // Capture any error in math type selection
                default:
                    Console.WriteLine("You did not enter a valid character, sorry, no math for you today...");
                    break;
            }

            Console.ReadLine();
        }
    }
}
