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
                Console.WriteLine(numberString);
            }
            Console.WriteLine($"The final result is:  {finalOutput}");
            Console.ReadLine();
        }
    }
}
